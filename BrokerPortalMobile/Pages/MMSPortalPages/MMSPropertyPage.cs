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
    public class MMSPropertyPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "LeftMenu1_Properties_btnAddProperty")]
        public IWebElement btnAdd;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Properties_txtStreetNumber")]
        public IWebElement txtStreetNumber;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Properties_txtAddress1")]
        public IWebElement txtAddress1;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Properties_txtCity")]
        public IWebElement txtCity;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Properties_ddlProvince")]
        public IWebElement ddlProvince;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Properties_txtPostalCode")]
        public IWebElement txtPostalCode;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Properties_grdProperty")]
        public IWebElement tblPropertyAddress;

        public void AddMMSProperty(string streetNumber, string address1, string city, string province, string postalCode)
        {
            UIHelper.EnterText(txtStreetNumber, streetNumber);
            UIHelper.EnterText(txtAddress1, address1);
            UIHelper.EnterText(txtCity, city);
            UIHelper.SelectComboElement(ddlProvince, province);
            Thread.Sleep(2000);
            UIHelper.EnterText(txtPostalCode, postalCode);
            UIHelper.ClickOnLink(btnAdd);
            UIHelper.WaitForPageLoad(15);
            UIHelper.WaitUntillExpectedTableEntry(tblPropertyAddress, 1, 1, 15);
        }
    }
}
