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
    public class BTDealDetailsPage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Deal Details')]")]
        public IWebElement lblDealDetails;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")]
        public IWebElement divDealStatusWithoutAlert;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]")]
        public IWebElement divDealDetailsWithoutAlert;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")]
        public IWebElement divActionRequired;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]")]
        public IWebElement divNotesNoAlert;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[1]")]
        public IWebElement divNotesWithAlert;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView")]
        public IWebElement divNotesWithoutAlert;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView")]
        public IWebElement lblNoteDetailWithAlert;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Acknowledge')]")]
        public IWebElement btnAcknowledge;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Reply')]")]
        public IWebElement btnReply;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout")]
        public IWebElement modalAcknowledgeReply;

        [FindsBy(How = How.Id, Using = "android:id/button1")]
        public IWebElement btnAcknowledgeConfirm;

        [FindsBy(How = How.Id, Using = "android:id/button2")]
        public IWebElement btnAcknowledgeCancel;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")]
        public IWebElement lblNoNoteAdded;

        //[FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'New note')]")]
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[2]/android.view.ViewGroup[2]/android.widget.TextView")]
        public IWebElement btnNewNote;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Cancel')]")]
        public IWebElement btnNoteCancel;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Closing Date')]")]
        public IWebElement lblCosingDate;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'FCT Ref No.')]")]
        public IWebElement lblFctRefNo;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Lender Name')]")]
        public IWebElement lblLenderName;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Mortgagor(s)')]")]
        public IWebElement lblMortgagors;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Address(es)')]")]
        public IWebElement lblAddresses;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Lender Ref No.')]")]
        public IWebElement lblLenderRefNo;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup")]
        public IWebElement lblDealMilestone;

        //[FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Solicitor instructed')]")]
        //public IWebElement lblSolInstrMilestone;

        //[FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Broker conditions met')]")]
        //public IWebElement lblBrokerCondMilestone;

        //[FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Funded')]")]
        //public IWebElement lblFundedMilestone;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.ScrollView/android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup")]
        public IWebElement statDealReceivedMilestone;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.ScrollView/android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup")]
        public IWebElement statSolInstrMilestone;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.ScrollView/android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup")]
        public IWebElement statStatementOrdMilestone;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.ScrollView/android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup")]
        public IWebElement statBrokerCondMilestone;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.ScrollView/android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup")]
        public IWebElement statStatementRcvMilestone;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.ScrollView/android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup")]
        public IWebElement statFundedMilestone;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.ScrollView/android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup")]
        public IWebElement statSigningApptMilestone;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.ScrollView/android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup")]
        public IWebElement statFundedMotionMilestone;

        //[FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Show 1 More')]")]
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[4]/android.view.ViewGroup/android.widget.TextView")]
        public IWebElement btnExpandNote;

        [FindsBy(How = How.ClassName, Using = "android.widget.EditText")]
        public IWebElement txtNewNote;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'POST')]")]
        public IWebElement btnPostNote;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Cancel')]")]
        public IWebElement btnCancelNote;

        //public void VerifyAlertDealDetails(bool status)
        //{
        //    if (status)
        //    {
        //        Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Alert icon not found on Action Required section in Deal Details.");
        //    }
        //    else
        //    {
        //        Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count() > 1, "Alert icon found on Action Required section in Deal Details.");
        //    }
        //}

        public void VerifyAlertDealDetails(bool status)
        {
            try
            {
                if (status)
                {
                    Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Alert icon not found on Action Required section in Deal Details.");
                }
                else
                {
                    Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count() > 1, "Alert icon found on Action Required section in Deal Details.");
                }
            }
            catch (NoSuchElementException)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 0)
                {
                    androidDriver.FindElement(By.Id("android:id/button2")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);

                    VerifyAlertDealDetails(status);
                }
            }
        }

        //public void VerifyActionDetailSec(string noteOption, bool status)
        //{
        //    if (status)
        //    {
        //        Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Action Required section not visible on deal details page");
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Acknowledge')]")), "Acknowledge link is not available");
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Reply')]")), "Reply link is not available");
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + noteOption + "')]")));
        //    }
        //    else
        //    {
        //        Assert.False(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Action Required section visible on deal details page on Broker Tracker");
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Acknowledge')]")), "Acknowledge link is not available");
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Reply')]")), "Reply link is not available");
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + noteOption + "')]")));
        //    }
        //}

        public void VerifyActionDetailSec(string noteOption, bool status)
        {
            try
            {
                if (status)
                {
                    Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Action Required section not visible on deal details page");
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Acknowledge')]")), "Acknowledge link is not available");
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Reply')]")), "Reply link is not available");
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + noteOption + "')]")));
                }
                else
                {
                    Assert.False(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Action Required section visible on deal details page on Broker Tracker");
                    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Acknowledge')]")), "Acknowledge link is not available");
                    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Reply')]")), "Reply link is not available");
                    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + noteOption + "')]")));
                }
            }
            catch (NoSuchElementException)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 0)
                {
                    androidDriver.FindElement(By.Id("android:id/button2")).Click();

                    VerifyActionDetailSec(noteOption, status);
                }
            }
        }

        public void VerifyAlertDealDetailsMotion(bool status)
        {
            try
            {
                if (status)
                {
                    Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Alert icon not found on Action Required section in Deal Details.");
                }
                else
                {
                    Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count() > 1, "Alert icon found on Action Required section in Deal Details.");
                }
            }
            catch (NoSuchElementException)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 0)
                {
                    androidDriver.FindElement(By.Id("android:id/button1")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);

                    VerifyAlertDealDetailsMotion(status);
                }
            }
        }

        public void VerifyActionDetailSecMotion(string noteOption, bool status)
        {
            try
            {
                if (status)
                {
                    Assert.True(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Action Required section not visible on deal details page");
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Acknowledge')]")), "Acknowledge link is not available");
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Reply')]")), "Reply link is not available");
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + noteOption + "')]")));
                }
                else
                {
                    Assert.False(androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]")).FindElements(By.ClassName("android.widget.ImageView")).Count().Equals(1), "Action Required section visible on deal details page on Broker Tracker");
                    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Acknowledge')]")), "Acknowledge link is not available");
                    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Reply')]")), "Reply link is not available");
                    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + noteOption + "')]")));
                }
            }
            catch (NoSuchElementException)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 0)
                {
                    androidDriver.FindElement(By.Id("android:id/button1")).Click();

                    VerifyActionDetailSecMotion(noteOption, status);
                }
            }
        }

        //public void AcknowledgeAlert(bool status, string note = null)
        //{
        //    UIHelperAndroid.ClickOnLink(btnAcknowledge);
        //    UIHelperAndroid.WaitForElementVisibleEC(By.XPath("/hierarchy/android.widget.FrameLayout"), 15);

        //    if (status)
        //    {
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge No button is not displayed");
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge Yes button is not displayed");
        //        UIHelperAndroid.ClickOnLink(btnAcknowledgeConfirm);
        //        UIHelperAndroidApp.WaitForSpinnerInvisible(15);
        //        VerifyAlertDealDetails(false);
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Acknowledged note is not added to grid");
        //        Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Acknowledged note is not added to grid");
        //    }
        //    else
        //    {
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge No button is not displayed");
        //        Assert.True(btnAcknowledgeCancel.Text.Equals("NO"));
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge Yes button is not displayed");
        //        Assert.True(btnAcknowledgeConfirm.Text.Equals("YES"));
        //        UIHelperAndroid.ClickOnLink(btnAcknowledgeCancel);
        //        UIHelperAndroid.WaitForElementInvisible(15, By.XPath("/hierarchy/android.widget.FrameLayout"));
        //        VerifyAlertDealDetails(true);
        //    }
        //}

        public void AcknowledgeAlert(bool status, string note = null)
        {
            UIHelperAndroidApp.ClickOnLink(btnAcknowledge);
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("/hierarchy/android.widget.FrameLayout"), 15);

            if (status)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge No button is not displayed");

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge Yes button is not displayed");

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.ClickOnLink(btnAcknowledgeConfirm);

                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                VerifyAlertDealDetailsMotion(false);

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Acknowledged note is not added to grid");

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Acknowledged note is not added to grid");
            }
            else
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge No button is not displayed");

                Assert.True(btnAcknowledgeCancel.Text.Equals("NO"));

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge Yes button is not displayed");

                Assert.True(btnAcknowledgeConfirm.Text.Equals("YES"));

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.ClickOnLink(btnAcknowledgeCancel);
                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("/hierarchy/android.widget.FrameLayout"));
                VerifyAlertDealDetails(true);
            }
        }

        public void AcknowledgeAlertMotion(bool status, string note = null)
        {
            UIHelperAndroidApp.ClickOnLink(btnAcknowledge);
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("/hierarchy/android.widget.FrameLayout"), 15);

            if (status)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge No button is not displayed");

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge Yes button is not displayed");

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.ClickOnLink(btnAcknowledgeConfirm);

                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                VerifyAlertDealDetailsMotion(false);

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Acknowledged note is not added to grid");

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Acknowledged note is not added to grid");
            }
            else
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge No button is not displayed");
                
                Assert.True(btnAcknowledgeCancel.Text.Equals("NO"));

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge Yes button is not displayed");
                
                Assert.True(btnAcknowledgeConfirm.Text.Equals("YES"));

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.ClickOnLink(btnAcknowledgeCancel);
                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("/hierarchy/android.widget.FrameLayout"));
                VerifyAlertDealDetailsMotion(true);
            }
        }

        //public void ReplyAlert(bool status, string brokerUsername = null, string reply = null, string lenderNote = null)
        //{
        //    UIHelperAndroid.ClickOnLink(btnReply);
        //    UIHelperAndroid.WaitForElementVisibleEC(By.XPath("/hierarchy/android.widget.FrameLayout"), 15);
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge CANCEL button is not displayed");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge SUBMIT button is not displayed");
        //    Assert.True(btnAcknowledgeCancel.Text.Equals("CANCEL"));
        //    Assert.True(btnAcknowledgeConfirm.Text.Equals("SUBMIT"));
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("com.fct.mobile.brokersvs:id/alertTitle")), "Alert reply label is not displayed");

        //    IWebElement txtReply = androidDriver.FindElement(By.ClassName("android.widget.EditText"));

        //    if (status)
        //    {
        //        UIHelperAndroid.EnterText(txtReply, reply);
        //        UIHelperAndroid.ClickOnLink(btnAcknowledgeConfirm);
        //        UIHelperAndroidApp.WaitForSpinnerInvisible(20);
        //        Thread.Sleep(2000);
        //        VerifyAlertDealDetails(false);
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Replied note is not added to grid");
        //        Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + reply + "')]")).Count > 0, "Broker reply is not added to grid");

        //        UIHelperAndroid.ClickOnLink(btnExpandNote);
        //        Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + lenderNote + "')]")).Count > 0, "Replied note is not added to grid");

        //        IWebElement replyDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
        //        Assert.True(replyDetail.Text.Contains(brokerUsername + " - " + CurrentDate("MMM dd, yyyy")));
        //    }
        //    else
        //    {
        //        UIHelperAndroid.ClickOnLink(btnAcknowledgeCancel);
        //        UIHelperAndroid.WaitForElementInvisible(15, By.XPath("/hierarchy/android.widget.FrameLayout"));
        //        VerifyAlertDealDetails(true);
        //    }
        //}

        public void ReplyAlert(bool status, string brokerUsername = null, string reply = null, string lenderNote = null)
        {
            UIHelperAndroidApp.ClickOnLink(btnReply);
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("/hierarchy/android.widget.FrameLayout"), 15);

            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
            {
                androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            }
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge CANCEL button is not displayed");

            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
            {
                androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            }
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge SUBMIT button is not displayed");

            Assert.True(btnAcknowledgeCancel.Text.Equals("CANCEL"));
            Assert.True(btnAcknowledgeConfirm.Text.Equals("SUBMIT"));

            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
            {
                androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            }
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("com.fct.mobile.brokersvs:id/alertTitle")), "Alert reply label is not displayed");

            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
            {
                androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            }
            IWebElement txtReply = androidDriver.FindElement(By.ClassName("android.widget.EditText"));

            if (status)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.EnterText(txtReply, reply);

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.ClickOnLink(btnAcknowledgeConfirm);
                UIHelperAndroidApp.WaitForSpinnerInvisible(20);
                Thread.Sleep(2000);

                VerifyAlertDealDetails(false);

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Replied note is not added to grid");

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + reply + "')]")).Count > 0, "Broker reply is not added to grid");

                UIHelperAndroidApp.ClickOnLink(btnExpandNote);

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + lenderNote + "')]")).Count > 0, "Replied note is not added to grid");

                UIHelperAndroidApp.AcknAlertIfAvailable();
                IWebElement replyDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(replyDetail.Text.Contains(brokerUsername + " - " + CurrentDate("MMM dd, yyyy")));
            }
            else
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.ClickOnLink(btnAcknowledgeCancel);

                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("/hierarchy/android.widget.FrameLayout"));
                VerifyAlertDealDetails(true);
            }
        }

        public void ReplyAlertMotion(bool status, string brokerUsername = null, string reply = null, string lenderNote = null)
        {
            UIHelperAndroidApp.ClickOnLink(btnReply);
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("/hierarchy/android.widget.FrameLayout"), 15);

            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
            {
                androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            }
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button2")), "Alert acknowledge CANCEL button is not displayed");

            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
            {
                androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            }
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("android:id/button1")), "Alert acknowledge SUBMIT button is not displayed");
            
            Assert.True(btnAcknowledgeCancel.Text.Equals("CANCEL"));
            Assert.True(btnAcknowledgeConfirm.Text.Equals("SUBMIT"));

            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
            {
                androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            }
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("com.fct.mobile.brokersvs:id/alertTitle")), "Alert reply label is not displayed");

            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
            {
                androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            }
            IWebElement txtReply = androidDriver.FindElement(By.ClassName("android.widget.EditText"));

            if (status)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.EnterText(txtReply, reply);

                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.ClickOnLink(btnAcknowledgeConfirm);
                UIHelperAndroidApp.WaitForSpinnerInvisible(20);
                Thread.Sleep(2000);
                
                VerifyAlertDealDetailsMotion(false);

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Replied note is not added to grid");

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + reply + "')]")).Count > 0, "Broker reply is not added to grid");

                UIHelperAndroidApp.ClickOnLink(btnExpandNote);

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + lenderNote + "')]")).Count > 0, "Replied note is not added to grid");

                UIHelperAndroidApp.AcknAlertIfAvailable();
                IWebElement replyDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(replyDetail.Text.Contains(brokerUsername + " - " + CurrentDate("MMM dd, yyyy")));
            }
            else
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 1)
                {
                    androidDriver.FindElement(By.XPath("//android.widget.Button[contains(@text, 'OK')]")).Click();
                    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
                }
                UIHelperAndroid.ClickOnLink(btnAcknowledgeCancel);

                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("/hierarchy/android.widget.FrameLayout"));
                VerifyAlertDealDetailsMotion(true);
            }
        }

        //public void NewNote(bool status, bool isAlertPresent, string note = null)
        //{
        //    UIHelperAndroid.ClickOnLink(btnNewNote);           
        //    UIHelperAndroid.WaitForElementVisibleEC(By.ClassName("android.widget.EditText"), 10);

        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Notes')]")));

        //    if (status)
        //    {
        //        UIHelperAndroid.EnterText(txtNewNote, note);
        //        UIHelperAndroid.ClickOnLink(btnPostNote);
        //        UIHelperAndroid.WaitForElementInvisible(15, By.ClassName("android.widget.EditText"));
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Acknowledged note is not added to grid");

        //        if (isAlertPresent)
        //        {
        //            Assert.True(divNotesWithAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Broker reply is not added to grid");
        //            IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
        //            Assert.True(noteDetail.Text.Contains(CurrentDate("MMM dd, yyyy")));
        //        }
        //        else
        //        {
        //            Assert.True(divNotesWithoutAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Broker reply is not added to grid");
        //            IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
        //            Assert.True(noteDetail.Text.Contains(CurrentDate("MMM dd, yyyy")));
        //        }
        //    }
        //    else
        //    {
        //        UIHelperAndroid.ClickOnLink(btnCancelNote);
        //        UIHelperAndroid.WaitForElementInvisible(15, By.ClassName("android.widget.EditText"));
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "New note Cancel did not work");
        //    }
        //}

        public void NewNote(bool status, bool isAlertPresent, string note = null)
        {
            UIHelperAndroidApp.ClickOnLink(btnNewNote);
            UIHelperAndroid.WaitForElementVisibleEC(By.ClassName("android.widget.EditText"), 10);

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Notes')]")));

            if (status)
            {
                UIHelperAndroidApp.EnterText(txtNewNote, note);
                UIHelperAndroidApp.ClickOnLink(btnPostNote);
                UIHelperAndroid.WaitForElementInvisible(15, By.ClassName("android.widget.EditText"));

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Acknowledged note is not added to grid");

                if (isAlertPresent)
                {
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(divNotesWithAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Broker reply is not added to grid");

                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(noteDetail.Text.Contains(CurrentDate("MMM dd, yyyy")));
                }
                else
                {
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(divNotesWithoutAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Broker reply is not added to grid");

                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(noteDetail.Text.Contains(CurrentDate("MMM dd, yyyy")));
                }
            }
            else
            {
                UIHelperAndroidApp.ClickOnLink(btnCancelNote);
                UIHelperAndroid.WaitForElementInvisible(15, By.ClassName("android.widget.EditText"));

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "New note Cancel did not work");
            }
        }

        public void NewNoteMotion(bool status, bool isAlertPresent, string note = null)
        {
            UIHelperAndroidApp.ClickOnLink(btnNewNote);
            UIHelperAndroid.WaitForElementVisibleEC(By.ClassName("android.widget.EditText"), 10);

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Notes')]")));

            if (status)
            {
                UIHelperAndroidApp.EnterText(txtNewNote, note);
                UIHelperAndroidApp.ClickOnLink(btnPostNote);
                UIHelperAndroid.WaitForElementInvisible(15, By.ClassName("android.widget.EditText"));

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Acknowledged note is not added to grid");

                if (isAlertPresent)
                {
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(divNotesWithAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Broker reply is not added to grid");

                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(noteDetail.Text.Contains(CurrentDate("MMM dd, yyyy")));
                }
                else
                {
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(divNotesWithoutAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Broker reply is not added to grid");

                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(noteDetail.Text.Contains(CurrentDate("MMM dd, yyyy")));
                }
            }
            else
            {
                UIHelperAndroidApp.ClickOnLink(btnCancelNote);
                UIHelperAndroid.WaitForElementInvisible(15, By.ClassName("android.widget.EditText"));

                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "New note Cancel did not work");
            }
        }

        //public void VerifyBlankNoteGrid()
        //{
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Note grid is not empty");
        //}

        public void VerifyBlankNoteGrid()
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Note grid is not empty");
        }

        public void VerifyBlankNoteGridMotion()
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No notes added yet. Tap new to add a note.')]")), "Note grid is not empty");
        }

        //public void VerifyBTNoteGrid(int rowNumber, string note, string userName)
        //{
        //    Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Note is not found on grid");

        //    if (rowNumber == 1)
        //    {
        //        IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
        //        Assert.True(noteDetail.Text.Contains(userName + " - " + CurrentDate("MMM dd, yyyy")));
        //    }
        //    else
        //    {
        //        IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup[" + rowNumber.ToString() + "]/android.view.ViewGroup/android.view.ViewGroup[3]/android.widget.TextView"));
        //        Assert.True(noteDetail.Text.Contains(userName + " - " + CurrentDate("MMM dd, yyyy")));
        //    }
        //}

        public void VerifyBTNoteGrid(int rowNumber, string note, string userName)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Note is not found on grid");

            if (rowNumber == 1)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(noteDetail.Text.Contains(userName + " - " + CurrentDate("MMM dd, yyyy")));
            }
            else
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup[" + rowNumber.ToString() + "]/android.view.ViewGroup/android.view.ViewGroup[3]/android.widget.TextView"));
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(noteDetail.Text.Contains(userName + " - " + CurrentDate("MMM dd, yyyy")));
            }
        }

        public void VerifyBTNoteGridMotion(int rowNumber, string note, string userName)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(divNotesNoAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, '" + note + "')]")).Count > 0, "Note is not found on grid");

            if (rowNumber == 1)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView"));
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(noteDetail.Text.Contains(userName + " - " + CurrentDate("MMM dd, yyyy")));
            }
            else
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                IWebElement noteDetail = androidDriver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup[" + rowNumber.ToString() + "]/android.view.ViewGroup/android.view.ViewGroup[3]/android.widget.TextView"));
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(noteDetail.Text.Contains(userName + " - " + CurrentDate("MMM dd, yyyy")));
            }
        }

        //public void VerifyDealDetails(string fctUrn, string Lender, string propertyAddress, string lenderRefNo = null, string closingDate = null)
        //{
        //    Assert.True(divDealDetailsWithoutAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, 'Deal Details')]")).Count > 0, "Deal Details section is not available");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Closing Date')]")), "Closing Date label not found");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Mortgagor(s)')]")), "FCT Reference No. label not found");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Address(es)')]")), "Lender Name label not found");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Lender Name')]")), "Mortgagor(s) label not found");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Lender Ref No.')]")), "Address(es) label not found");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'FCT Ref No.')]")), "Lender Reference No. label not found");

        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + closingDate + "')]")), "Closing Date value does not match");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + fctUrn + "')]")), "FCT Reference No. value does not match");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + Lender + "')]")), "Lender Name value does not match");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + propertyAddress + "')]")), "Address(es) value does not match");
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + lenderRefNo + "')]")), "Lender Reference No. value does not match");
        //}

        public void VerifyDealDetails(string fctUrn, string Lender, string propertyAddress, string lenderRefNo = null, string closingDate = null)
        {
            try
            {
                Assert.True(divDealDetailsWithoutAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, 'Deal Details')]")).Count > 0, "Deal Details section is not available");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Closing Date')]")), "Closing Date label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Mortgagor(s)')]")), "FCT Reference No. label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Address(es)')]")), "Lender Name label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Lender Name')]")), "Mortgagor(s) label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Lender Ref No.')]")), "Address(es) label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'FCT Ref No.')]")), "Lender Reference No. label not found");

                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + closingDate + "')]")), "Closing Date value does not match");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + fctUrn + "')]")), "FCT Reference No. value does not match");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + Lender + "')]")), "Lender Name value does not match");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + propertyAddress + "')]")), "Address(es) value does not match");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + lenderRefNo + "')]")), "Lender Reference No. value does not match");
            }
            catch (NoSuchElementException)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();

                VerifyDealDetails(fctUrn, Lender, propertyAddress, lenderRefNo, closingDate);
            }
        }

        public void VerifyDealDetailsMotion(string fctUrn, string Lender, string propertyAddress, string lenderRefNo = null, string closingDate = null)
        {
            try
            {
                Assert.True(divDealDetailsWithoutAlert.FindElements(By.XPath("//android.widget.TextView[contains(@text, 'Deal Details')]")).Count > 0, "Deal Details section is not available");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Closing Date')]")), "Closing Date label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Mortgagor(s)')]")), "FCT Reference No. label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Address(es)')]")), "Lender Name label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Lender Name')]")), "Mortgagor(s) label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Lender Ref No.')]")), "Address(es) label not found");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'FCT Ref No.')]")), "Lender Reference No. label not found");

                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + closingDate + "')]")), "Closing Date value does not match");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + fctUrn + "')]")), "FCT Reference No. value does not match");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + Lender + "')]")), "Lender Name value does not match");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + propertyAddress + "')]")), "Address(es) value does not match");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + lenderRefNo + "')]")), "Lender Reference No. value does not match");
            }
            catch (NoSuchElementException)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();

                VerifyDealDetailsMotion(fctUrn, Lender, propertyAddress, lenderRefNo, closingDate);
            }
        }

        //public void VerifyMortgagorDealDetails(string mortgagor)
        //{
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + mortgagor + "')]")), "Mortgagor(s) value does not match");
        //}

        public void VerifyMortgagorDealDetails(string mortgagor)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + mortgagor + "')]")), "Mortgagor(s) value does not match");
        }

        public void VerifyMortgagorDealDetailsMotion(string mortgagor)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + mortgagor + "')]")), "Mortgagor(s) value does not match");
        }

        //public void VerifyMMSMilestones()
        //{
        //    Assert.True(divDealStatusWithoutAlert.FindElements(By.ClassName("android.widget.HorizontalScrollView")).Count > 0, "Deal milestones are not available");

        //    UIHelperAndroid.ClickOnLink(statDealReceivedMilestone);
        //    Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Deal received"), "Deal received milestone label is not available");
        //    UIHelperAndroid.ClickOnLink(statSolInstrMilestone);
        //    Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Solicitor instructed"), "Solicitor instructed milestone label is not available");
        //    UIHelperAndroid.ClickOnLink(statBrokerCondMilestone);
        //    Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Broker conditions met"), "Broker conditions met milestone label is not available");
        //    UIHelperAndroid.ClickOnLink(statFundedMilestone);
        //    Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Funded"), "Funded milestone label is not available");
        //}

        public void VerifyMMSMilestones()
        {
            try
            {
                Assert.True(divDealStatusWithoutAlert.FindElements(By.ClassName("android.widget.HorizontalScrollView")).Count > 0, "Deal milestones are not available");

                UIHelperAndroidApp.ClickOnLink(statDealReceivedMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Deal received"), "Deal received milestone label is not available");
                UIHelperAndroidApp.ClickOnLink(statSolInstrMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Solicitor instructed"), "Solicitor instructed milestone label is not available");
                UIHelperAndroidApp.ClickOnLink(statBrokerCondMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Broker conditions met"), "Broker conditions met milestone label is not available");
                UIHelperAndroidApp.ClickOnLink(statFundedMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Funded"), "Funded milestone label is not available");
            }
            catch (NoSuchElementException)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                VerifyMMSMilestones();
            }
        }

        public void VerifyMotionMilestones()
        {
            try
            {
                Assert.True(divDealStatusWithoutAlert.FindElements(By.ClassName("android.widget.HorizontalScrollView")).Count > 0, "Deal milestones are not available");

                UIHelperAndroidApp.ClickOnLink(statDealReceivedMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Deal received"), "Deal received milestone label is not available");
                UIHelperAndroidApp.ClickOnLink(statStatementOrdMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Statements ordered"), "Statements ordered milestone label is not available");
                UIHelperAndroidApp.ClickOnLink(statStatementRcvMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Statements received"), "Statements received milestone label is not available");
                UIHelperAndroidApp.ClickOnLink(statSigningApptMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Signing appointment booked"), "Signing appointment booked milestone label is not available");
                UIHelperAndroidApp.ClickOnLink(statFundedMotionMilestone);
                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Contains("Funded"), "Funded milestone label is not available");
            }
            catch (NoSuchElementException)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                VerifyMotionMilestones();
            }
        }

        //public void VerifyMMSMilestoneStatus(string milestone, bool status, string milestoneDate = null)
        //{
        //    switch (milestone.ToUpper())
        //    {
        //        case "DEAL RECEIVED":
        //            UIHelperAndroid.ClickOnLink(statDealReceivedMilestone);
        //            if (status)
        //            {
        //                Assert.True(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is not complete");
        //                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Deal received" + milestoneDate), "Deal received milestone completion date missing/does not match");
        //            }
        //            else
        //            {
        //                Assert.False(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is complete");
        //                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Deal received"), "Deal received milestone is complete");
        //            }
        //            break;

        //        case "SOLICITOR INSTRUCTED":
        //            UIHelperAndroid.ClickOnLink(statSolInstrMilestone);
        //            if (status)
        //            {
        //                Assert.True(statSolInstrMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Solicitor instructed milestone is not complete");
        //                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Solicitor instructed" + milestoneDate), "Solicitor instructed milestone completion date missing/does not match");
        //            }
        //            else
        //            {
        //                Assert.False(statSolInstrMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Solicitor instructed milestone is complete");
        //                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Solicitor instructed"), "Solicitor instructed milestone is complete");
        //            }
        //            break;

        //        case "BROKER CONDITIONS MET":
        //            UIHelperAndroid.ClickOnLink(statBrokerCondMilestone);
        //            if (status)
        //            {
        //                Assert.True(statBrokerCondMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Broker conditions met milestone is not complete");
        //                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Broker conditions met" + milestoneDate), "Broker conditions met milestone completion date missing/does not match");
        //            }
        //            else
        //            {
        //                Assert.False(statBrokerCondMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Broker conditions met milestone is complete");
        //                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Broker conditions met"), "Broker conditions met milestone is complete");
        //            }
        //            break;

        //        case "FUNDED":
        //            UIHelperAndroid.ClickOnLink(statFundedMilestone);
        //            if (status)
        //            {
        //                Assert.True(statFundedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is not complete");
        //                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Funded" + milestoneDate), "Funded milestone completion date missing/does not match");
        //            }
        //            else
        //            {
        //                Assert.False(statFundedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is complete");
        //                Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Funded"), "Funded milestone is complete");
        //            }
        //            break;

        //        default:
        //            break;
        //    }
        //}

        public void VerifyMMSMilestoneStatus(string milestone, bool status, string milestoneDate = null)
        {
            switch (milestone.ToUpper())
            {
                case "DEAL RECEIVED":
                    UIHelperAndroidApp.ClickOnLink(statDealReceivedMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Deal received" + milestoneDate), "Deal received milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Deal received" + milestoneDate), "Deal received milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Deal received"), "Deal received milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Deal received"), "Deal received milestone is complete");
                        }
                    }
                    break;

                case "SOLICITOR INSTRUCTED":
                    UIHelperAndroidApp.ClickOnLink(statSolInstrMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statSolInstrMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Solicitor instructed milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Solicitor instructed" + milestoneDate), "Solicitor instructed milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statSolInstrMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Solicitor instructed milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Solicitor instructed" + milestoneDate), "Solicitor instructed milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statSolInstrMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Solicitor instructed milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Solicitor instructed"), "Solicitor instructed milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statSolInstrMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Solicitor instructed milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Solicitor instructed"), "Solicitor instructed milestone is complete");
                        }
                    }
                    break;

                case "BROKER CONDITIONS MET":
                    UIHelperAndroidApp.ClickOnLink(statBrokerCondMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statBrokerCondMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Broker conditions met milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Broker conditions met" + milestoneDate), "Broker conditions met milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statBrokerCondMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Broker conditions met milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Broker conditions met" + milestoneDate), "Broker conditions met milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statBrokerCondMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Broker conditions met milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Broker conditions met"), "Broker conditions met milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statBrokerCondMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Broker conditions met milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Broker conditions met"), "Broker conditions met milestone is complete");
                        }
                    }
                    break;

                case "FUNDED":
                    UIHelperAndroidApp.ClickOnLink(statFundedMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statFundedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Funded" + milestoneDate), "Funded milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statFundedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Funded" + milestoneDate), "Funded milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statFundedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Funded"), "Funded milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statFundedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Funded"), "Funded milestone is complete");
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        public void VerifyMotionMilestoneStatus(string milestone, bool status, string milestoneDate = null)
        {
            switch (milestone.ToUpper())
            {
                case "DEAL RECEIVED":
                    UIHelperAndroidApp.ClickOnLink(statDealReceivedMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Deal received" + milestoneDate), "Deal received milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Deal received" + milestoneDate), "Deal received milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Deal received"), "Deal received milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statDealReceivedMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Deal received milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Deal received"), "Deal received milestone is complete");
                        }
                    }
                    break;

                case "STATEMENTS ORDERED":
                    UIHelperAndroidApp.ClickOnLink(statStatementOrdMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statStatementOrdMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Statements ordered milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Contains("Statements ordered" + milestoneDate), "Statements ordered milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statStatementOrdMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Statements ordered milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Contains("Statements ordered" + milestoneDate), "Statements ordered milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statStatementOrdMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Statements ordered milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("0 of 1 - Statements ordered"), "Statements ordered milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statStatementOrdMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Statements ordered milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("0 of 1 - Statements ordered"), "Statements ordered milestone is complete");
                        }
                    }
                    break;

                case "STATEMENTS RECEIVED":
                    UIHelperAndroidApp.ClickOnLink(statStatementRcvMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statStatementRcvMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Statements received milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Contains("Statements received" + milestoneDate), "Statements received milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statStatementRcvMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Statements received milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Contains("Statements received" + milestoneDate), "Statements received milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statStatementRcvMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Statements received milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("0 of 1 - Statements received"), "Statements received milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statStatementRcvMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Statements received milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("0 of 1 - Statements received"), "Statements received milestone is complete");
                        }
                    }
                    break;

                case "SIGNING APPOINTMENT BOOKED":
                    UIHelperAndroidApp.ClickOnLink(statSigningApptMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statSigningApptMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Signing appointment booked milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Signing appointment booked" + milestoneDate), "Signing appointment booked milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statSigningApptMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Signing appointment booked milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Signing appointment booked" + milestoneDate), "Signing appointment booked milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statSigningApptMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Signing appointment booked milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Signing appointment booked"), "Signing appointment booked milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statSigningApptMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Signing appointment booked milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Signing appointment booked"), "Signing appointment booked milestone is complete");
                        }
                    }
                    break;

                case "FUNDED":
                    UIHelperAndroidApp.ClickOnLink(statFundedMotionMilestone);
                    if (status)
                    {
                        try
                        {
                            Assert.True(statFundedMotionMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Funded" + milestoneDate), "Funded milestone completion date missing/does not match");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.True(statFundedMotionMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is not complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Equals("Funded" + milestoneDate), "Funded milestone completion date missing/does not match");
                        }
                    }
                    else
                    {
                        try
                        {
                            Assert.False(statFundedMotionMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Funded"), "Funded milestone is complete");
                        }
                        catch (NoSuchElementException)
                        {
                            UIHelperAndroidApp.AcknAlertIfAvailable();

                            Assert.False(statFundedMotionMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Equals("✓"), "Funded milestone is complete");
                            Assert.True(lblDealMilestone.FindElement(By.ClassName("android.widget.TextView")).Text.Replace("\r", "").Replace("\n", "").Trim().Equals("Funded"), "Funded milestone is complete");
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
