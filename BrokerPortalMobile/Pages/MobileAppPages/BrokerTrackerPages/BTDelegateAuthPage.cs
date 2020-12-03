using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
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
    public class BTDelegateAuthPage : TestBase
    {
        [FindsBy(How = How.ClassName, Using = "android.widget.EditText")]
        public IWebElement txtLoginID;

        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text, 'Submit')]")]
        public IWebElement btnSubmit;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Delete')]")]
        public IWebElement btnDelete;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Disable')]")]
        public IWebElement btnDisable;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Enable')]")]
        public IWebElement btnEnable;

        [FindsBy(How = How.Id, Using = "android:id/button1")]
        public IWebElement btnOK;

        [FindsBy(How = How.Id, Using = "android:id/button2")]
        public IWebElement btnCancel;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'The delegate was deleted successfully.')]")]
        public IWebElement lblDelegateDelMsg;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Record saved successfully.')]")]
        public IWebElement lblDelegateAddMsg;

        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text, 'Add')]")]
        public IWebElement btnAdd;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement tblDelegate;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement lblDelegatedAuth;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement lblLoginId;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement btnNavigation;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement lblTblHeader;

        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text,'Toggle navigation')]")]
        public IWebElement btnNavigationProfile;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement lblDelegateText;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Action')]")]
        public IWebElement lblAction;

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Network')]")]
        public IWebElement lblNetwork;

        //public void AddDelegate(string brokerUsername)
        //{
        //    UIHelperAndroid.EnterText(txtLoginID, brokerUsername);
        //    UIHelperAndroid.ClickOnLink(btnSubmit);
        //    UIHelperAndroid.WaitForSpinnerInvisible(30);
        //    if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'Delegated authority already assigned.')]")))
        //    {
        //        UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.Button[contains(@text, 'Add')]"), 15);
        //        UIHelperAndroidApp.SwipeAndroidApp(315, 1375, "DOWN");
        //        UIHelperAndroidApp.SwipeAndroidApp(315, 1375, "DOWN");
        //        UIHelperAndroidApp.SwipeAndroidApp(315, 1375, "DOWN");
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.Button[contains(@text, 'Add')]")), "Broker to be delegated username not found");

        //        //UIHelperAndroid.ClickOnLink(androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'Add')]")));
        //        UIHelperAndroidApp.TapElementByLocation(132, 1624);
        //        UIHelperAndroid.WaitForSpinnerInvisible(20);
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'Record saved successfully.')]")), "Delegate added message not shown");
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.Button[contains(@text, 'Add')]")), "Faied to add broker delegate");
        //    }
        //}

        public void AddDelegate(string brokerUsername)
        {
            UIHelperAndroidApp.EnterText(txtLoginID, brokerUsername);
            UIHelperAndroidApp.ClickOnLink(btnSubmit);
            UIHelperAndroid.WaitForSpinnerInvisible(30);
            if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'Delegated authority already assigned.')]")))
            {
                UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.Button[contains(@text, 'Add')]"), 15);
                UIHelperAndroidApp.AcknAlertIfAvailable();
                UIHelperAndroidApp.SwipeAndroidApp(315, 1375, "DOWN");
                UIHelperAndroidApp.SwipeAndroidApp(315, 1375, "DOWN");
                UIHelperAndroidApp.SwipeAndroidApp(315, 1375, "DOWN");
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.Button[contains(@text, 'Add')]")), "Broker to be delegated username not found");

                UIHelperAndroidApp.AcknAlertIfAvailable();
                UIHelperAndroidApp.TapElementByLocation(132, 1624);
                UIHelperAndroid.WaitForSpinnerInvisible(20);
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'Record saved successfully.')]")), "Delegate added message not shown");
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.Button[contains(@text, 'Add')]")), "Faied to add broker delegate");
            }
        }

        public void EnableDisableDeleteDelegate(string activity)
        {
            switch (activity)
            {
                case "ENABLE":
                    UIHelperAndroidApp.ClickOnLink(btnSubmit);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);

                    UIHelperAndroidApp.SwipeAndroidApp(230, 1622, "RIGHT");
                    Thread.Sleep(2000);
                    UIHelperAndroidApp.SwipeAndroidApp(578, 1497, "RIGHT");
                    Thread.Sleep(2000);
                    UIHelperAndroidApp.SwipeAndroidApp(763, 1493, "RIGHT");
                    Thread.Sleep(2000);

                    UIHelperAndroidApp.TapElementByLocation(890, 1577);
                    UIHelperAndroid.WaitForSpinnerInvisible(15);

                    if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'Delegated authority already assigned.')]")))
                    {
                        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'The delegate was enabled successfully.')]")), "Delegate enabled message not shown");
                    }
                    break;

                case "DISABLE":
                    UIHelperAndroidApp.ClickOnLink(btnSubmit);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);

                    UIHelperAndroidApp.SwipeAndroidApp(230, 1622, "RIGHT");
                    Thread.Sleep(2000);
                    UIHelperAndroidApp.SwipeAndroidApp(578, 1497, "RIGHT");
                    Thread.Sleep(2000);
                    UIHelperAndroidApp.SwipeAndroidApp(763, 1493, "RIGHT");
                    Thread.Sleep(2000);

                    UIHelperAndroidApp.TapElementByLocation(752, 1577);
                    UIHelperAndroid.WaitForSpinnerInvisible(15);

                    if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'Delegated authority already assigned.')]")))
                    {
                        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'The delegate was disabled successfully.')]")), "Delegate disabled message not shown");
                    }
                    break;

                case "DELETE":
                    UIHelperAndroidApp.ClickOnLink(btnSubmit);
                    UIHelperAndroid.WaitForSpinnerInvisible(10);

                    UIHelperAndroidApp.SwipeAndroidApp(230, 1622, "RIGHT");
                    Thread.Sleep(2000);
                    UIHelperAndroidApp.SwipeAndroidApp(578, 1497, "RIGHT");
                    Thread.Sleep(2000);
                    UIHelperAndroidApp.SwipeAndroidApp(763, 1493, "RIGHT");
                    Thread.Sleep(2000);

                    UIHelperAndroidApp.TapElementByLocation(613, 1577);
                    UIHelperAndroid.ClickOnLink(btnOK);
                    UIHelperAndroid.WaitForSpinnerInvisible(30);

                    if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'Delegated authority already assigned.')]")))
                    {
                        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text,'The delegate was deleted successfully.')]")), "Delegate delete message not shown");
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
