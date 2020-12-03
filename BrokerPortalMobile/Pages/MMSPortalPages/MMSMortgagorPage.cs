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
    public class MMSMortgagorPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_btnAdd")]
        public IWebElement btnAdd;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_rblMortgagorType_0")]
        public IWebElement btnIndividual;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_rblMortgagorType_1")]
        public IWebElement btnCorporation;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_txtLastName")]
        public IWebElement txtLastName;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_txtFirstName")]
        public IWebElement txtFirstName;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_txtStreetNumber")]
        public IWebElement txtStreetNumber;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_txtAddress1")]
        public IWebElement txtAddress1;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_txtCity")]
        public IWebElement txtCity;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_ddlProvince")]
        public IWebElement ddlProvince;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_txtPostal")]
        public IWebElement txtPostalCode;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_txtCompany")]
        public IWebElement txtCompanyName;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Mortgagor_grdMortgagors")]
        public IWebElement tblMortgagor;

        public bool SearchMortgagorGridAndVerify(IWebElement Table, String verify, int numberOfHeaderRows, int columnNumber)
        {
            var itemCount = Table.FindElements(By.TagName("tr")).Count();
            int flag = 0;
            IList<IWebElement> allOptions = Table.FindElements(By.TagName("tr"));

            if (itemCount > numberOfHeaderRows)
            {
                for (int i = numberOfHeaderRows; i < itemCount;)
                {
                    IList<IWebElement> Columns = allOptions[i].FindElements(By.TagName("td"));
                    if (Columns[columnNumber].FindElement(By.TagName("a")).Text.Contains(verify))
                    {
                        flag = 1;
                        IWebElement linkElement = Columns[columnNumber].FindElement(By.TagName("a"));
                        Assert.True(linkElement.Displayed && linkElement.Enabled);
                        UIHelper.ClickOnLink(linkElement);
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Assert.True(itemCount > 1, "Table contains no data");
                return false;
            }
        }

        public bool VerifyMortgagorGrid(IWebElement Table, String verify, int numberOfHeaderRows, int columnNumber)
        {
            var itemCount = Table.FindElements(By.TagName("tr")).Count();
            int flag = 0;
            IList<IWebElement> allOptions = Table.FindElements(By.TagName("tr"));

            if (itemCount > numberOfHeaderRows)
            {
                for (int i = numberOfHeaderRows; i < itemCount;)
                {
                    IList<IWebElement> Columns = allOptions[i].FindElements(By.TagName("td"));
                    if (Columns[columnNumber].FindElement(By.TagName("a")).Text.Contains(verify))
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Assert.True(itemCount > 1, "Table contains no data");
                return false;
            }
        }

        public void UpdateMMSMortgagor(string mortgagorType, string streetNumber, string mortgagorAddress1, string mortgagorCity, string mortgagorProvince, string mortgagorPostalCode, string mortgagorLastName = null, string mortgagorFirstName = null, string mortgagorCompany = null)
        {
            SearchMortgagorGridAndVerify(tblMortgagor, mortgagorLastName, 1, 0);
            //UIHelper.WaitUntilElementHasValue(txtLastName, mortgagorLastName, 15);
            Thread.Sleep(1500);

            switch (mortgagorType)
            {
                case "Person":
                    UIHelper.ClickOnLink(btnIndividual);
                    UIHelper.EnterText(txtFirstName, mortgagorFirstName);
                    UIHelper.EnterText(txtStreetNumber, streetNumber);
                    UIHelper.EnterText(txtAddress1, mortgagorAddress1);
                    UIHelper.EnterText(txtCity, mortgagorCity);
                    UIHelper.SelectComboElement(ddlProvince, mortgagorProvince);
                    UIHelper.EnterText(txtPostalCode, mortgagorPostalCode);
                    UIHelper.ClickOnLink(btnAdd);
                    Thread.Sleep(2500);
                    Assert.True(VerifyMortgagorGrid(tblMortgagor, mortgagorLastName + ", " + mortgagorFirstName, 1, 0));
                    break;

                case "Business":
                    UIHelper.ClickOnLink(btnCorporation);
                    UIHelper.EnterText(txtCompanyName, mortgagorCompany);
                    UIHelper.EnterText(txtStreetNumber, streetNumber);
                    UIHelper.EnterText(txtAddress1, mortgagorAddress1);
                    UIHelper.EnterText(txtCity, mortgagorCity);
                    UIHelper.SelectComboElement(ddlProvince, mortgagorProvince);
                    UIHelper.EnterText(txtPostalCode, mortgagorPostalCode);
                    UIHelper.ClickOnLink(btnAdd);
                    Thread.Sleep(2500);
                    Assert.True(VerifyMortgagorGrid(tblMortgagor, mortgagorCompany, 1, 0));
                    break;

                default:
                    break;
            }
        }

        public void AddMMSMortgagor(string mortgagorType, string streetNumber, string mortgagorAddress1, string mortgagorCity, string mortgagorProvince, string mortgagorPostalCode, string mortgagorLastName = null, string mortgagorFirstName = null, string mortgagorCompany = null)
        {
            switch (mortgagorType)
            {
                case "Person":
                    UIHelper.ClickOnLink(btnIndividual);
                    UIHelper.EnterText(txtLastName, mortgagorLastName);
                    UIHelper.EnterText(txtFirstName, mortgagorFirstName);
                    UIHelper.EnterText(txtStreetNumber, streetNumber);
                    UIHelper.EnterText(txtAddress1, mortgagorAddress1);
                    UIHelper.EnterText(txtCity, mortgagorCity);
                    UIHelper.SelectComboElement(ddlProvince, mortgagorProvince);
                    UIHelper.EnterText(txtPostalCode, mortgagorPostalCode);
                    UIHelper.ClickOnLink(btnAdd);
                    Thread.Sleep(1500);
                    Assert.True(VerifyMortgagorGrid(tblMortgagor, mortgagorLastName + ", " + mortgagorFirstName, 1, 0));
                    break;

                case "Business":
                    UIHelper.ClickOnLink(btnCorporation);
                    UIHelper.EnterText(txtCompanyName, mortgagorCompany);
                    UIHelper.EnterText(txtStreetNumber, streetNumber);
                    UIHelper.EnterText(txtAddress1, mortgagorAddress1);
                    UIHelper.EnterText(txtCity, mortgagorCity);
                    UIHelper.SelectComboElement(ddlProvince, mortgagorProvince);
                    UIHelper.EnterText(txtPostalCode, mortgagorPostalCode);
                    UIHelper.ClickOnLink(btnAdd);
                    Thread.Sleep(1500);
                    Assert.True(VerifyMortgagorGrid(tblMortgagor, mortgagorCompany, 1, 0));
                    break;

                default:
                    break;
            }
        }
    }
}
