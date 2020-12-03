using AutoIt;
using BrokerPortalMobile.Steps.MotionSteps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MotionPages
{
    public class MotionLenderPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "tabLender")]
        public IWebElement btnLenderTab;

        [FindsBy(How = How.Id, Using = "tabThirdPartyContact")]
        public IWebElement btnBrokerTab;

        [FindsBy(How = How.Id, Using = "txtApptDate")]
        public IWebElement txtApptDate;

        [FindsBy(How = How.Id, Using = "txtTPCEmail")]
        public IWebElement txtBrokerEmail;

        [FindsBy(How = How.Id, Using = "cmdSearchCRM")]
        public IWebElement btnSearchCRM;

        [FindsBy(How = How.Id, Using = "cmdSave")]
        public IWebElement btnSave;

        //[FindsBy(How = How.Id, Using = "btnSearchPerson")]
        //[FindsBy(How = How.XPath, Using = "//a[contains(@href,\"javascript:__doPostBack('btnSearchPerson','')\")]")]
        [FindsBy(How = How.XPath, Using = "//a[contains(@text, 'Search Person')]")]
        public IWebElement btnSearchPerson;

        [FindsBy(How = How.Id, Using = "txtFirst")]
        public IWebElement txtFirstNameCRM;

        [FindsBy(How = How.Id, Using = "txtLast")]
        public IWebElement txtLastNameCRM;

        [FindsBy(How = How.Id, Using = "ddlOrgTypes")]
        public IWebElement ddlOrgTypeCRM;

        [FindsBy(How = How.Id, Using = "cmdSearch")]
        public IWebElement btnSearchCRMPerson;

        [FindsBy(How = How.Id, Using = "dgPerson")]
        public IWebElement tblCRMPerson;

        [FindsBy(How = How.Id, Using = "btnSelect")]
        public IWebElement btnSelectPerson;

        [FindsBy(How = How.Id, Using = "txtTPCGroup")]
        public IWebElement txtBrokerOffice;

        [FindsBy(How = How.Id, Using = "txtContactCRMGUID")]
        public IWebElement txtBrokerCRMGUID;

        [FindsBy(How = How.Id, Using = "txtTPContactName")]
        public IWebElement txtBrokerName;

        [FindsBy(How = How.Id, Using = "txtTPContactPhone")]
        public IWebElement txtBrokerPhone;

        [FindsBy(How = How.Id, Using = "txtTPContactEmail1")]
        public IWebElement txtBrokerEmail1;

        [FindsBy(How = How.Id, Using = "txtTPContactEmail2")]
        public IWebElement txtBrokerEmail2;

        public static MotionHomePage motionHomePage;

        //public void LenderSwitchToTab(string tabName)
        //{
        //    switch (tabName)
        //    {
        //        case "Broker":
        //            Thread.Sleep(6000);
        //            UIHelper.SwitchToWindow(30, 1);
        //            UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            UIHelper.ClickOnLink(btnBrokerTab);
        //            UIHelper.WaitForPageLoad(30);
        //            UIHelper.SwitchToWindow(30, 1);
        //            UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            Assert.True(UIHelper.IsElementDisplayed(By.Id("txtTPCEmail")));
        //            break;

        //        default:
        //            break;
        //    }
        //}

        public void LenderSwitchToTab(string tabName, string dealID)
        {
            switch (tabName)
            {
                case "Broker":
                    Thread.Sleep(2000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabThirdPartyContact"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    
                    UIHelper.ClickOnLink(btnBrokerTab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("txtTPCEmail"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("txtTPCEmail")));
                    break;

                default:
                    break;
            }
        }

        public void SearchCRM(string firstNameCRM, string lastNameCRM, string dealID)
        {
            UIHelper.ClickOnLink(btnSearchCRM);
            Thread.Sleep(4000);
            UIHelper.SwitchToWindow(30, 2);
            UIHelper.SwitchToWindow(30, 2);

            AutoItX.Send("+{TAB}");
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
            Thread.Sleep(2500);

            AutoItX.Send("" + firstNameCRM + "");
            Thread.Sleep(1000);
            AutoItX.Send("{TAB}");
            Thread.Sleep(1000);
            AutoItX.Send("" + lastNameCRM + "");
            Thread.Sleep(1000);
            //UIHelper.EnterText(txtFirstNameCRM, firstNameCRM);
            //UIHelper.EnterText(txtLastNameCRM, lastNameCRM);
            //UIHelper.SelectComboElement(ddlOrgTypeCRM, "Mortgage Brokerage");

            AutoItX.Send("{TAB 6}");
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
            Thread.Sleep(2000);

            AutoItX.Send("{TAB 8}");
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
            Thread.Sleep(4000);
            //UIHelper.ClickOnLink(btnSearchCRMPerson);
            //UIHelper.WaitForElementVisible(tblCRMPerson, 20);
            //UIHelper.SearchGridAndVerify(driver, tblCRMPerson, firstNameCRM, 2, 0);

            AutoItX.Send("+{TAB 4}");
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
            Thread.Sleep(2000);
            //UIHelper.ClickOnLink(btnSelectPerson);
            //UIHelper.SwitchToWindow(30, 1);
            UIHelper.SwitchToWindowbyTitle(20, 2, "Ref. " + dealID + " : Motion");
        }

        //public void SearchCRM(string firstNameCRM, string lastNameCRM, string dealID)
        //{
        //    UIHelper.ClickOnLink(btnSearchCRM);
        //    Thread.Sleep(4000);
        //    UIHelper.SwitchToWindowbyTitle(30, 3, "Motion CRM Frame -- Webpage Dialog");

        //    //UIHelper.ClickOnLink(btnSearchPerson);
        //    UIHelper.ClickOnLink(btnSearchPerson);

        //    UIHelper.EnterText(txtFirstNameCRM, firstNameCRM);
        //    UIHelper.EnterText(txtLastNameCRM, lastNameCRM);
        //    UIHelper.SelectComboElement(ddlOrgTypeCRM, "Mortgage Brokerage");

        //    UIHelper.ClickOnLink(btnSearchCRMPerson);
        //    //UIHelper.WaitForElementVisible(tblCRMPerson, 20);
        //    UIHelper.WaitForElementVisibleEC(By.Id("dgPerson"), 20);
        //    UIHelper.SearchGridAndVerify(driver, tblCRMPerson, firstNameCRM, 2, 0);

        //    UIHelper.ClickOnLink(btnSelectPerson);
        //    //UIHelper.SwitchToWindow(30, 1);
        //    UIHelper.SwitchToWindowbyTitle(20, 2, "Ref. " + dealID + " : Motion");
        //}

        //public void AddBroker(string brokerEmail)
        //{
        //    Thread.Sleep(4000);
        //    UIHelper.SwitchToWindow(30, 1);
        //    UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //    UIHelper.EnterText(txtBrokerEmail, brokerEmail);
        //}

        public void AddBroker(string brokerEmail, string dealID)
        {
            Thread.Sleep(2000);
            UIHelper.ReTargetLastWindowWithFrame(By.Id("txtTPCEmail"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
            UIHelper.EnterText(txtBrokerEmail, brokerEmail);
        }

        //public void SaveMotionDeal()
        //{
        //    UIHelper.SwitchToWindow(30, 1);
        //    UIHelper.SwitchToFrame(30, By.Name("fraUtilityBar"));
        //    UIHelper.ClickOnLink(btnSave);
        //    UIHelper.WaitForPageLoad(15);
        //}

        public void SaveMotionDeal()
        {
            UIHelper.SwitchToWindowbyTitle(20, 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
            UIHelper.SwitchToFrame(30, By.Name("fraUtilityBar"));
            UIHelper.ClickOnLink(btnSave);
            UIHelper.WaitForPageLoad(15);
        }

        public void SetUnsetApptDate(bool isSet)
        {
            UIHelper.SetUnsetDateIE(txtApptDate, isSet);
            SaveMotionDeal();
        }
    }
}
