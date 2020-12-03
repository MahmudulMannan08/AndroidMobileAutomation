using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MMSPortalPages
{
    public class MMSSolicitorsInsPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "LeftMenu1_SolicitorInstructions_Milestones_grdMilestones_ctl02_chkConfirmed")]
        public IWebElement chkBrConditions;

        //[FindsBy(How = How.Id, Using = "LeftMenu1_SolicitorInstructions_Milestones_grdMilestones_ctl02_CompletedDateTime")]
        //public IWebElement txtBrConditionsCompletedDate;

        public void ChkUnchBrokerConditions(string chkBrConditionsStatus)
        {
            UIHelper.SetCheckbox(chkBrConditions, chkBrConditionsStatus);
            UIHelper.WaitForPageLoad(15);
        }

        public string VerifyBrokerConditionsDate(bool populated)
        {
            Thread.Sleep(2000);
            IWebElement txtBrConditionsCompletedDate = driver.FindElement(By.XPath("//div[@class='milestones']//tr[2]")).FindElements(By.TagName("td"))[2];
            if (populated)
            {
                Assert.True(txtBrConditionsCompletedDate.Text.Length > 0, "Broker Conditions Satisfied completed date is not populated in MMS");

                var brConditionsTimeStamp = txtBrConditionsCompletedDate.Text;
                return brConditionsTimeStamp.Substring(brConditionsTimeStamp.IndexOf(' '));
            }
            else
            {
                Assert.False(txtBrConditionsCompletedDate.Text.Length > 0, "Broker Conditions Satisfied completed date is not removed in MMS");

                return null;
            }
        }
    }
}
