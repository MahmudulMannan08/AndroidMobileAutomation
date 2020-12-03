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
    public class MMSNewDealPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ucUploadDocument_cboLender")]
        public IWebElement ddlLender;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ucUploadDocument_txtClientName")]
        public IWebElement txtClientLastName;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ucUploadDocument_txtLenderRefNo")]
        public IWebElement txtLenderRefNo;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ucUploadDocument_txtClosingDate_txtDate")]
        public IWebElement txtClosingDate;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ucUploadDocument_txtRFIReceiveDate")]
        public IWebElement txtRFIReceiveDate;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ucUploadDocument_FileUpload1")]
        public IWebElement txtFileUpload;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ucUploadDocument_btnUpload")]
        public IWebElement btnUpload;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1__backToHomeLink")]
        public IWebElement btnBacktoHome;

        [FindsBy(How = How.XPath, Using = "//span[@id='ctl00_ContentPlaceHolder1__thankYouText']/b[1]")]
        public IWebElement lblMMSFctUrn;

        public static MMSLoginPage mmsLoginPage;
        public static MMSHomePage mmsHomePage;

        public void CreateNewMMSDeal(string mmsLender, string clientLastName, string lenderRefNo, string closingDate, string filePath)
        {
            UIHelper.WaitForElementVisible(ddlLender, 30);
            UIHelper.SelectComboElement(ddlLender, mmsLender);
            UIHelper.EnterText(txtClientLastName, clientLastName);
            UIHelper.EnterText(txtLenderRefNo, lenderRefNo);
            UIHelper.EnterText(txtClosingDate, closingDate);
            UIHelper.EnterText(txtFileUpload, filePath);
            UIHelper.ClickOnLink(btnUpload);
            UIHelper.WaitForPageLoad(30);

            int loginTrial = 0;

            while (loginTrial < 5)
            {
                if (!UIHelper.IsElementDisplayed(By.Id("ctl00_ContentPlaceHolder1__backToHomeLink")))
                {
                    loginTrial++;
                    UIHelper.GoTo<MMSLoginPage>(MMSPortal);

                    mmsLoginPage = UIHelper.PageInit<MMSLoginPage>(driver);
                    mmsLoginPage.SigninToMMSPortal(MMSUsername, MMSPassword);

                    mmsHomePage = UIHelper.PageInit<MMSHomePage>(driver);
                    mmsHomePage.MMSSwitchToTab("New Deal");

                    UIHelper.WaitForElementVisible(ddlLender, 30);
                    UIHelper.SelectComboElement(ddlLender, mmsLender);
                    UIHelper.EnterText(txtClientLastName, clientLastName);
                    UIHelper.EnterText(txtLenderRefNo, lenderRefNo);
                    UIHelper.EnterText(txtClosingDate, closingDate);
                    UIHelper.EnterText(txtFileUpload, filePath);
                    UIHelper.ClickOnLink(btnUpload);
                    UIHelper.WaitForPageLoad(30);
                }
                else
                {
                    break;
                }
            }
        }

        public string GetMMSFCTUrn()
        {
            UIHelper.WaitForElementVisible(btnBacktoHome, 15);
            if (driver.FindElements(By.Id("ctl00_ContentPlaceHolder1__backToHomeLink")).Count <= 0)
            {
                return null;
            }
            else
            {
                return lblMMSFctUrn.Text;
            }
        }
    }
}
