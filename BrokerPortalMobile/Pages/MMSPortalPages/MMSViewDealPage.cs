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
    public class MMSViewDealPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder2_txtFCTReferenceNumber")]
        public IWebElement txtFCTRefNo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder2_btnSearch")]
        public IWebElement btnSearch;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ucDealList_gvDeals")]
        public IWebElement tblViewDeal;

        [FindsBy(How = How.Id, Using = "LeftMenu1_btnClose")]
        public IWebElement btnClose;

        [FindsBy(How = How.Id, Using = "LeftMenu1_lbPolicyStatus")]
        public IWebElement btnStatus;

        [FindsBy(How = How.Id, Using = "LeftMenu1_lbLender")]
        public IWebElement btnLender;

        //[FindsBy(How = How.Id, Using = "LeftMenu1_lbNotes")]
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Notes')]")]
        public IWebElement btnNotes;

        [FindsBy(How = How.Id, Using = "LeftMenu1_lbProperty")]
        public IWebElement btnProperty;

        [FindsBy(How = How.Id, Using = "LeftMenu1_lbMortgagor")]
        public IWebElement btnMortgagor;

        [FindsBy(How = How.Id, Using = "LeftMenu1_lbDealDocuments")]
        public IWebElement btnDocuments;

        [FindsBy(How = How.Id, Using = "LeftMenu1_lbSolicitorInstructions")]
        public IWebElement btnSolicitorsIns;

        [FindsBy(How = How.Id, Using = "LeftMenu1_btnClose")]
        public IWebElement btnCloseDeal;

        public void SearchMMSDeal(string fctUrn)
        {
            UIHelper.EnterText(txtFCTRefNo, fctUrn);
            UIHelper.ClickOnLink(btnSearch);
            UIHelper.WaitForPageLoad(20);
            Assert.True(UIHelper.SearchGridAndVerify(driver, tblViewDeal, fctUrn, 1, 2), "Unable to find MMS deal");
            UIHelper.SwitchToWindow(30, 1);
            UIHelper.WaitForElementVisibleEC(By.Id("LeftMenu1_btnClose"), 30);
        }

        public void MMSSwitchToMenu(string menuName)
        {
            //UIHelper.WaitForElementVisibleEC(By.Id("LeftMenu1_btnClose"), 30);

            switch (menuName)
            {
                case "Status":
                    UIHelper.ClickOnLink(btnStatus);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//b[contains(text(),'Status')]")), "Status page is not displayed");
                    break;

                case "Lender":
                    UIHelper.ClickOnLink(btnLender);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//b[contains(text(),'Lender Information')]")), "Lender page is not displayed");
                    break;

                case "Notes":
                    UIHelper.ClickOnLink(btnNotes);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("LeftMenu1_Notes_lblTitle")), "Notes page is not displayed");
                    break;

                case "Property":
                    UIHelper.ClickOnLink(btnProperty);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//b[contains(text(),'Property')]")), "Property page is not displayed");
                    break;

                case "Mortgagor":
                    UIHelper.ClickOnLink(btnMortgagor);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//b[contains(text(),'Mortgagor Information')]")), "Mortgagor page is not displayed");
                    break;

                case "Documents":
                    UIHelper.ClickOnLink(btnDocuments);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//b[contains(text(),'Documents')]")), "Documents page is not displayed");
                    break;

                case "Solicitors Instructions":
                    UIHelper.ClickOnLink(btnSolicitorsIns);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//b[contains(text(),'Special Instructions')]")), "Solicitors Instructions page is not displayed");
                    break;

                default:
                    break;
            }
        }

        public void TerminateViewDeal()
        {
            UIHelper.ClickOnLink(btnCloseDeal);
            UIHelper.SwitchToBaseWindow();
        }

        public void CloseMMSFCTPortal()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
