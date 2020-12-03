using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MobileAppPages.BrokerTrackerPages
{
    public class BTLoginPage : TestBase
    {
        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.EditText")]
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[contains(@text, 'Username')]")]
        public IWebElement txtLoginId;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.widget.EditText")]
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[contains(@text, 'Password')]")]
        public IWebElement txtPassword;

        [FindsBy(How = How.ClassName, Using = "android.widget.EditText")]
        public IList<IWebElement> txtLogin;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.widget.Button")]
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text, 'LOGIN')]")]
        public IWebElement btnLogin;

        [FindsBy(How = How.XPath, Using = "//android.widget.RadioButton[contains(@text, 'FCT closed deals')]")]
        public IWebElement tabFCTClosedDeals;

        [FindsBy(How = How.LinkText, Using = "Contact Us")]
        public IWebElement btnContactUs;

        [FindsBy(How = How.Id, Using = "android:id/message")]
        public IWebElement lblUnsuccessfulMsg;

        [FindsBy(How = How.Id, Using = "android:id/button2")]
        public IWebElement btnUnsuccessfulMsgConfirm;

        //public void LoginToBrokerTracker(string loginid, string password)
        //{
        //    int loginTrial = 0;
        //    UIHelperAndroid.EnterText(txtLoginId, loginid);
        //    UIHelperAndroid.EnterText(txtPassword, password);
        //    btnLogin.Click();
        //    UIHelperAndroidApp.WaitForSpinnerInvisible(45);
        //    UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]"), 30);
        //    while (loginTrial < 5)
        //    {
        //        if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]")))
        //        {
        //            loginTrial++;
        //            UIHelperAndroid.ClickOnLink(btnLogin);
        //            UIHelperAndroidApp.WaitForSpinnerInvisible(45);
        //            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]"), 30);
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //}

        public void LoginToBrokerTracker(string loginid, string password)
        {
            int loginTrial = 0;
            UIHelperAndroidApp.EnterText(txtLoginId, loginid);
            UIHelperAndroidApp.EnterText(txtPassword, password);
            UIHelperAndroidApp.ClickOnLink(btnLogin);
            UIHelperAndroidApp.WaitForSpinnerInvisible(45);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]"), 15);
            while (loginTrial < 5)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]")))
                {
                    loginTrial++;
                    if (androidDriver.FindElements(By.XPath("//android.widget.EditText[contains(@text, 'Username')]")).Count > 0)
                    {
                        UIHelperAndroidApp.EnterText(txtLoginId, loginid);
                        UIHelperAndroidApp.EnterText(txtPassword, password);
                    }
                    if (androidDriver.FindElements(By.XPath("//android.widget.Button[contains(@text, 'LOGIN')]")).Count > 0)
                    {
                        UIHelperAndroidApp.ClickOnLink(btnLogin);
                        UIHelperAndroidApp.WaitForSpinnerInvisible(45);
                        UIHelperAndroidApp.AcknAlertIfAvailable();
                        UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]"), 15);
                    }
                    else
                    {
                        UIHelperAndroidApp.GoBackAndroid();
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void LoginToBrokerTrackerMotion(string loginid, string password)
        {
            int loginTrial = 0;
            UIHelperAndroidApp.EnterText(txtLoginId, loginid);
            UIHelperAndroidApp.EnterText(txtPassword, password);
            UIHelperAndroidApp.ClickOnLink(btnLogin);
            UIHelperAndroidApp.WaitForSpinnerInvisible(45);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]"), 15);
            while (loginTrial < 5)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]")))
                {
                    loginTrial++;
                    if (androidDriver.FindElements(By.XPath("//android.widget.EditText[contains(@text, 'Username')]")).Count > 0)
                    {
                        UIHelperAndroidApp.EnterText(txtLoginId, loginid);
                        UIHelperAndroidApp.EnterText(txtPassword, password);
                    }
                    if (androidDriver.FindElements(By.XPath("//android.widget.Button[contains(@text, 'LOGIN')]")).Count > 0)
                    {
                        UIHelperAndroidApp.ClickOnLink(btnLogin);
                        UIHelperAndroidApp.WaitForSpinnerInvisible(45);
                        UIHelperAndroidApp.AcknAlertIfAvailable();
                        UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]"), 15);
                    }
                    else
                    {
                        UIHelperAndroidApp.GoBackAndroid();
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void VerifySignoutSuccess()
        {
            //Verify Login button is dispayed
            Thread.Sleep(1500);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.Button[contains(@text, 'LOGIN')]")), "Failed to logout");
        }

        public void UnauthorizedLoginToBT(string loginid, string password)
        {
            UIHelperAndroidApp.EnterText(txtLogin[0], loginid);
            UIHelperAndroidApp.EnterText(txtLogin[1], password);
            UIHelperAndroidApp.ClickOnLink(btnLogin);
            UIHelperAndroidApp.WaitForSpinnerInvisible(45);
            UIHelperAndroidApp.AcknAlertIfAvailable();
        }

        public void VerifyFailedLogin(string unsuccessMsg)
        {
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/message")), "Unauthorized login message is not displayed");
            Assert.True(lblUnsuccessfulMsg.Text.Equals(unsuccessMsg));

            UIHelperAndroidApp.ClickOnLink(btnUnsuccessfulMsgConfirm);
            UIHelperAndroid.WaitForElementInvisible(15, By.Id("android:id/message"));
        }
    }
}
