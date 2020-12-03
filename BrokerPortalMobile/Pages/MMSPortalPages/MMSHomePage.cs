using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MMSPortalPages
{
    public class MMSHomePage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Home')]")]
        public IWebElement lblHome;

        [FindsBy(How = How.Id, Using = "ctl00_TopMenu1_TopMenuManagern1")]
        public IWebElement btnNewDeal;

        [FindsBy(How = How.Id, Using = "ctl00_TopMenu1_TopMenuManagern2")]
        public IWebElement btnEditViewDeal;

        [FindsBy(How = How.Id, Using = "ctl00_TopMenu1_TopMenuManagern8")]
        public IWebElement btnLogOut;

        public void MMSSwitchToTab(string tabName)
        {
            UIHelper.WaitForElementVisible(btnNewDeal, 30);

            switch (tabName)
            {
                case "New Deal":
                    UIHelper.ClickOnLink(btnNewDeal);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//span[contains(text(),'New Deal')]")));
                    break;

                case "Edit/View Deals":
                    UIHelper.ClickOnLink(btnEditViewDeal);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//span[contains(text(),'Edit/View Deals')]")));
                    break;

                case "Log Out":
                    UIHelper.ClickOnLink(btnLogOut);
                    break;

                default:
                    UIHelper.ClickOnLink(btnNewDeal);
                    break;
            }
        }
    }
}
