using AutoIt;
using BrokerPortalMobile.Steps.MotionSteps;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MotionPages
{
    public class MotionFundingPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "tabDisbursements")]
        public IWebElement btnDisbursementsTab;

        [FindsBy(How = How.Id, Using = "txtFundingCompDate")]
        public IWebElement txtFundingCompDate;

        [FindsBy(How = How.Id, Using = "cmdSave")]
        public IWebElement btnSave;

        public void FundingSwitchToTab(string tabName)
        {
            switch (tabName)
            {
                case "Disbursements":
                    Thread.Sleep(6000);
                    UIHelper.SwitchToWindow(30, 1);
                    UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
                    UIHelper.ClickOnLink(btnDisbursementsTab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.SwitchToWindow(30, 1);
                    UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("txtFundingCompDate")));
                    break;

                default:
                    break;
            }
        }

        public void SaveMotionDeal()
        {
            UIHelper.SwitchToWindowbyTitle(20, 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
            UIHelper.SwitchToFrame(30, By.Name("fraUtilityBar"));
            UIHelper.ClickOnLink(btnSave);
            UIHelper.WaitForPageLoad(15);
        }

        public void SetUnsetFundingCompletion(bool isSet)
        {
            UIHelper.SetUnsetDateIE(txtFundingCompDate, isSet);
            SaveMotionDeal();
        }
    }
}
