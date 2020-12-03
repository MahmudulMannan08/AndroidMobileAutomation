using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BrokerPortalMobile.Pages.MMSPortalPages
{
    public class MMSLenderPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "LeftMenu1_Lender_btnSearchCRM")]
        public IWebElement btnSearchCRM;

        [FindsBy(How = How.Id, Using = "btnSearchPerson")]
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

        [FindsBy(How = How.Id, Using = "LeftMenu1_Lender_txtBrokerFName")]
        public IWebElement txtFirstNameBrokerContact;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Lender_txtBrokerEmail")]
        public IWebElement txtEmailBrokerContact;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Lender_btnAddBrokerContact")]
        public IWebElement btnAddBrokerContact;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Lender_grdBrokerContact")]
        public IWebElement tblBrokerContact;

        public void SearchCRM(string firstNameCRM, string lastNameCRM)
        {
            UIHelper.ClickOnLink(btnSearchCRM);
            UIHelper.SwitchToIFrame(20, 0);
            UIHelper.WaitForElementVisible(btnSearchPerson, 20);
            UIHelper.ClickOnLink(btnSearchPerson);
            UIHelper.EnterText(txtFirstNameCRM, firstNameCRM);
            UIHelper.EnterText(txtLastNameCRM, lastNameCRM);
            UIHelper.SelectComboElement(ddlOrgTypeCRM, "Mortgage Brokerage");
            UIHelper.ClickOnLink(btnSearchCRMPerson);
            UIHelper.WaitForElementVisible(tblCRMPerson, 20);
            UIHelper.SearchGridAndVerify(driver, tblCRMPerson, firstNameCRM, 2, 0);
            UIHelper.ClickOnLink(btnSelectPerson);
            UIHelper.SwitchToWindow(30, 1);
        }

        public void AddBroker(string firstNameCRM, string brokerEmail)
        {
            UIHelper.WaitForPageLoad(15);
            Thread.Sleep(2000);
            UIHelper.EnterText(txtEmailBrokerContact, brokerEmail);
            UIHelper.ClickOnLink(btnAddBrokerContact);
            UIHelper.WaitForPageLoad(15);
            UIHelper.WaitUntillExpectedTableEntry(tblBrokerContact, 1, 1, 30);
        }
    }
}
