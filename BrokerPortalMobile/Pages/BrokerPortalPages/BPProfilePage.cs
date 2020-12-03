using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BrokerPortalMobile.Pages.BrokerPortalPages
{
    public class BPProfilePage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//html//body//app-root//app-layouts-auth//fw-framework-body//div//div//div//fw-left-menu//div//em")]
        public IWebElement btnNavigationProfile;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Contact Information')]")]
        public IWebElement btnContactInfoMenu;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Delegated Authority')]")]
        public IWebElement btnDelegateAuthMenu;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Notification Preferences')]")]
        public IWebElement btnNotificationPrefMenu;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Security Questions')]")]
        public IWebElement btnSecurityQueMenu;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Change Password')]")]
        public IWebElement btnChangePassMenu;

        [FindsBy(How = How.XPath, Using = "//div[@class='text-danger text-custom text-bold']")]
        public IWebElement txtHeader;

        [FindsBy(How = How.Id, Using = "alertCheck")]
        public IWebElement cbBrokerAlertChk;

        [FindsBy(How = How.Id, Using = "milestoneCheck")]
        public IWebElement cbMilestoneNotChk;

        [FindsBy(How = How.XPath, Using = "//span[@class='navbar-toggler-icon']")]
        public IWebElement btnNavigation;

        [FindsBy(How = How.XPath, Using = "//a[@class='nav-link last']")]
        public IWebElement btnSignOut;

        public void SelectProfileMenu(string profileMenu)
        {
            UIHelperAndroid.WaitForPageLoad(15);
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.ClickOnLink(btnNavigationProfile);

            switch (profileMenu)
            {
                case "Contact Information":
                    UIHelperAndroid.ClickOnLink(btnContactInfoMenu);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);
                    UIHelperAndroid.WaitUntilElementHasText(txtHeader, "Contact Information", 20);
                    Assert.True(txtHeader.Text.Equals("Contact Information"), "Unable to load Contact Information page");
                    break;

                case "Delegated Authority":
                    UIHelperAndroid.ClickOnLink(btnDelegateAuthMenu);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);
                    UIHelperAndroid.WaitUntilElementHasText(txtHeader, "Delegated Authority", 20);
                    Assert.True(txtHeader.Text.Equals("Delegated Authority"), "Unable to load Delegated Authority page");
                    break;

                case "Notification Preferences":
                    UIHelperAndroid.ClickOnLink(btnNotificationPrefMenu);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);
                    UIHelperAndroid.WaitForElementVisibleEC(By.Id("alertCheck"), 20);
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("alertCheck")), "Unable to load Notification Preferences page");
                    break;

                default:
                    break;
            }
        }

        public void SignOut()
        {
            UIHelperAndroid.ClickOnLink(btnNavigation);
            UIHelperAndroid.ClickOnLink(btnSignOut);
            UIHelperAndroid.WaitForPageLoad(30);
        }

        public void VerifySignoutSuccess()
        {
            //Verify Login button is dispayed
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//button[contains(text(),'Log in')]")), "Failed to sign out");
        }

        public void VerifyLeftNavigationMyProfileBroker()
        {
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.ClickOnLink(btnNavigationProfile);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Contact Information')]")), "Contact Information left navigation is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Delegated Authority')]")), "Delegated Authority left navigation is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Notification Preferences')]")), "Notification Preferences left navigation is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Security Questions')]")), "Security Questions left navigation is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Change Password')]")), "Change Password left navigation is not available");
        }

        public void VerifyLeftNavigationMyProfileBrokerAdmin()
        {
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.ClickOnLink(btnNavigationProfile);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Contact Information')]")), "Contact Information left navigation is not available");
            Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Delegated Authority')]")), "Delegated Authority left navigation is not available");
            Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Notification Preferences')]")), "Notification Preferences left navigation is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Security Questions')]")), "Security Questions left navigation is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Change Password')]")), "Change Password left navigation is not available");
        }
    }
}
