using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages
{
    public class BPLoginPage : TestBase, IPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@class='form-control form-control-md ng-untouched ng-pristine ng-invalid']")]
        public IWebElement txtLoginId;

        [FindsBy(How = How.XPath, Using = "//input[@class='form-control form-control-md form-control-sm ng-untouched ng-pristine ng-invalid']")]
        public IWebElement txtPassword;

        [FindsBy(How = How.TagName, Using = "input")]
        public IList<IWebElement> txtLoginIdPassword;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Log in')]")]
        public IWebElement btnLogin;

        [FindsBy(How = How.LinkText, Using = "Contact Us")]
        public IWebElement btnContactUs;

        [FindsBy(How = How.XPath, Using = "//span[@class='text-danger']")]
        public IWebElement lblUnsuccessfulMsg;

        public string Url
        {
            get
            {
                return "";
            }
        }

        public void LoginToBrokerPortal(string loginid, string password)
        {
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.EnterText(txtLoginIdPassword[0], loginid);
            UIHelperAndroid.EnterText(txtLoginIdPassword[1], password);
            UIHelperAndroid.ScrollToElement(androidDriver, btnContactUs);
            //btnLogin.Click();
            UIHelper.ClickOnLink(btnLogin);
            UIHelperAndroid.WaitForPageLoad(30);
            UIHelperAndroid.WaitForSpinnerInvisible(30);
        }

        public void VerifySignoutSuccess()
        {
            //Verify Login button is dispayed
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//button[contains(text(),'Log in')]")));
        }

        public void VerifyFailedLogin(string unsuccessMsg)
        {
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[@class='text-danger']")), "Unauthorized login message is not displayed");
            Assert.True(lblUnsuccessfulMsg.Text.Equals(unsuccessMsg));
        }
    }
}
