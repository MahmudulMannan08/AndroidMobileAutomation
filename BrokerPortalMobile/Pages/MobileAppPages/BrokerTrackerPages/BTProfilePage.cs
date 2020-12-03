using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MobileAppPages.BrokerTrackerPages
{
    public class BTProfilePage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View[3]/android.view.View[2]")]
        public IWebElement btnNavigationProfile;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text, 'Contact Information')]")]
        public IWebElement btnContactInfoMenu;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text, 'Delegated Authority')]")]
        public IWebElement btnDelegateAuthMenu;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text, 'Notification Preferences')]")]
        public IWebElement btnNotificationPrefMenu;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text, 'Security Questions')]")]
        public IWebElement btnSecurityQueMenu;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text, 'Change Password')]")]
        public IWebElement btnChangePassMenu;

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement cbBrokerAlertChk;

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement cbMilestoneNotChk;

        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text, 'Toggle navigation')]")]
        public IWebElement btnNavigation;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text, 'Sign Out')]")]
        public IWebElement btnSignOut;

        //public void SelectProfileMenu(string profileMenu)
        //{
        //    //UIHelperAndroid.ClickOnLink(btnNavigationProfile);
        //    Thread.Sleep(1000);
        //    UIHelperAndroidApp.TapElementByLocation(52, 724);

        //    switch (profileMenu)
        //    {
        //        case "Contact Information":
        //            UIHelperAndroid.ClickOnLink(btnContactInfoMenu);
        //            UIHelperAndroid.WaitForSpinnerInvisible(10);
        //            UIHelperAndroid.WaitUntilElementHasText(txtHeader, "Contact Information", 20);
        //            Assert.True(txtHeader.Text.Equals("Contact Information"), "Unable to load Contact Information page");
        //            break;

        //        case "Delegated Authority":
        //            UIHelperAndroid.ClickOnLink(btnDelegateAuthMenu);
        //            UIHelperAndroid.WaitForSpinnerInvisible(10);
        //            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.Button[contains(@text, 'Submit')]")), "Unable to load Delegated Authority page");
        //            break;

        //        case "Notification Preferences":
        //            UIHelperAndroid.ClickOnLink(btnNotificationPrefMenu);
        //            UIHelperAndroid.WaitForSpinnerInvisible(10);
        //            UIHelperAndroid.WaitForElementVisibleEC(By.Id("alertCheck"), 20);
        //            Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("alertCheck")), "Unable to load Notification Preferences page");
        //            break;

        //        default:
        //            break;
        //    }
        //}

        public void SelectProfileMenu(string profileMenu)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Thread.Sleep(1000);
            UIHelperAndroidApp.TapElementByLocation(52, 724);

            switch (profileMenu)
            {
                case "Contact Information":
                    UIHelperAndroidApp.ClickOnLink(btnContactInfoMenu);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text, 'Network:')]")), "Unable to load Contact Information page");
                    break;

                case "Delegated Authority":
                    UIHelperAndroidApp.ClickOnLink(btnDelegateAuthMenu);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.Button[contains(@text, 'Submit')]")), "Unable to load Delegated Authority page");
                    break;

                case "Notification Preferences":
                    UIHelperAndroidApp.ClickOnLink(btnNotificationPrefMenu);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.Button[contains(@text, 'Update')]")), "Unable to load Notification Preferences page");
                    break;

                default:
                    break;
            }
        }
    }
}
