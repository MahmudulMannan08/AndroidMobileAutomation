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
    public class BTHomePage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//android.widget.ImageButton[@content-desc='OK']")]
        public IWebElement btnNavigation;

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement ddProfile;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Logout')]")]
        public IWebElement btnSignout;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'My Profile')]")]
        public IWebElement btnMyProfile;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement btnContactUs;

        [FindsBy(How = How.XPath, Using = "//android.widget.RadioButton[contains(@text, 'FCT closed deals')]")]
        public IWebElement tabFCTClosedDeals;

        [FindsBy(How = How.XPath, Using = "//android.widget.RadioButton[contains(@text, 'Solicitor closed deals')]")]
        public IWebElement tabSolicitorClosedDeals;

        [FindsBy(How = How.XPath, Using = "(//android.widget.TextView[@content-desc='Help'])[2]")]
        public IWebElement btnSearchSolicitor;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Mortgagor Last Name')]")]
        public IWebElement btnMortgagorSearch;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'FCT Ref No.')]")]
        public IWebElement btnFCTRefNoSearch;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'City')]")]
        public IWebElement btnCitySearch;

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[contains(@text, 'Search')]")]
        public IWebElement txtSearch;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[3]")]
        public IWebElement btnSearch;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]")]
        public IWebElement btnCancelSearch;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.TextView")]
        public IWebElement lblActionRequiredCounter;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[3]/android.view.ViewGroup[1]/android.widget.TextView")]
        public IWebElement lblInProcessCounter;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[5]/android.view.ViewGroup[1]/android.widget.TextView")]
        public IWebElement lblFundedCounter;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")]
        public IWebElement lblAlertIcon;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Deal Details')]")]
        public IWebElement lblDealDetails;

        //[FindsBy(How = How.XPath, Using = "//span[contains(@class,'home-text')]")]
        //public IWebElement btnHome;

        //[FindsBy(How = How.XPath, Using = "//button[contains(text(),'New Note')]")]
        //public IWebElement btnNewNote;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[1]")]
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Action Required')]")]
        public IWebElement btnActionRequired;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[3]")]
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'In Process')]")]
        public IWebElement btnInProcess;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[5]")]
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text, 'Funded')]")]
        public IWebElement btnFunded;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]")]
        //public IWebElement divDealDetailsWithoutAlert;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.ImageView")]
        public IWebElement ddlBrokerFilter;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView")]
        public IWebElement ddlBrFilterSelection;

        //public void SelectDealsTab(string tabSelection)
        //{
        //    switch (tabSelection)
        //    {
        //        case "FCT closed deals":
        //            UIHelperAndroid.ClickOnLink(tabFCTClosedDeals);
        //            UIHelperAndroidApp.WaitForSpinnerInvisible(25);
        //            Assert.True(tabFCTClosedDeals.GetAttribute("checked").Equals("true"));
        //            break;

        //        case "Solicitor closed deals":
        //            UIHelperAndroid.ClickOnLink(tabSolicitorClosedDeals);
        //            UIHelperAndroidApp.WaitForSpinnerInvisible(25);
        //            Assert.True(tabSolicitorClosedDeals.GetAttribute("checked").Equals("true"));
        //            break;

        //        default:
        //            UIHelperAndroid.ClickOnLink(tabFCTClosedDeals);
        //            UIHelperAndroidApp.WaitForSpinnerInvisible(25);
        //            Assert.True(tabFCTClosedDeals.GetAttribute("checked").Equals("true"));
        //            break;
        //    }
        //}

        public void SelectDealsTab(string tabSelection)
        {
            switch (tabSelection)
            {
                case "FCT closed deals":
                    try
                    {
                        UIHelperAndroidApp.ClickOnLink(tabFCTClosedDeals);
                    }
                    catch (NoSuchElementException)
                    {
                        UIHelperAndroidApp.GoBackAndroid();
                        UIHelperAndroidApp.ClickOnLink(tabFCTClosedDeals);
                    }
                    UIHelperAndroidApp.WaitForSpinnerInvisible(25);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(tabFCTClosedDeals.GetAttribute("checked").Equals("true"));
                    break;

                case "Solicitor closed deals":
                    try
                    {
                        UIHelperAndroidApp.ClickOnLink(tabSolicitorClosedDeals);
                    }
                    catch (NoSuchElementException)
                    {
                        UIHelperAndroidApp.GoBackAndroid();
                        UIHelperAndroidApp.ClickOnLink(tabSolicitorClosedDeals);
                    }
                    UIHelperAndroidApp.WaitForSpinnerInvisible(25);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(tabSolicitorClosedDeals.GetAttribute("checked").Equals("true"));
                    break;

                default:
                    try
                    {
                        UIHelperAndroidApp.ClickOnLink(tabFCTClosedDeals);
                    }
                    catch (NoSuchElementException)
                    {
                        UIHelperAndroidApp.GoBackAndroid();
                        UIHelperAndroidApp.ClickOnLink(tabFCTClosedDeals);
                    }
                    UIHelperAndroidApp.WaitForSpinnerInvisible(25);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(tabFCTClosedDeals.GetAttribute("checked").Equals("true"));
                    break;
            }
        }

        public void SelectDealsTabMotion(string tabSelection)
        {
            switch (tabSelection)
            {
                case "FCT closed deals":
                    try
                    {
                        UIHelperAndroidApp.ClickOnLink(tabFCTClosedDeals);
                    }
                    catch (NoSuchElementException)
                    {
                        UIHelperAndroidApp.GoBackAndroid();
                        UIHelperAndroidApp.ClickOnLink(tabFCTClosedDeals);
                    }
                    UIHelperAndroidApp.WaitForSpinnerInvisible(25);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(tabFCTClosedDeals.GetAttribute("checked").Equals("true"));
                    break;

                case "Solicitor closed deals":
                    try
                    {
                        UIHelperAndroidApp.ClickOnLink(tabSolicitorClosedDeals);
                    }
                    catch (NoSuchElementException)
                    {
                        UIHelperAndroidApp.GoBackAndroid();
                        UIHelperAndroidApp.ClickOnLink(tabSolicitorClosedDeals);
                    }
                    UIHelperAndroidApp.WaitForSpinnerInvisible(25);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(tabSolicitorClosedDeals.GetAttribute("checked").Equals("true"));
                    break;

                default:
                    try
                    {
                        UIHelperAndroidApp.ClickOnLink(tabFCTClosedDeals);
                    }
                    catch (NoSuchElementException)
                    {
                        UIHelperAndroidApp.GoBackAndroid();
                        UIHelperAndroidApp.ClickOnLink(tabFCTClosedDeals);
                    }
                    UIHelperAndroidApp.WaitForSpinnerInvisible(25);
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(tabFCTClosedDeals.GetAttribute("checked").Equals("true"));
                    break;
            }
        }

        //public void SelectBucketTab(string tabSelection)
        //{
        //    switch (tabSelection)
        //    {
        //        case "Action required":
        //            UIHelperAndroid.ClickOnLink(btnActionRequired);
        //            UIHelperAndroidApp.WaitForSpinnerInvisible(20);
        //            break;

        //        case "In process":
        //            UIHelperAndroid.ClickOnLink(btnInProcess);
        //            UIHelperAndroidApp.WaitForSpinnerInvisible(20);
        //            break;

        //        case "Funded":
        //            UIHelperAndroid.ClickOnLink(btnFunded);
        //            UIHelperAndroidApp.WaitForSpinnerInvisible(20);
        //            break;

        //        default:
        //            UIHelperAndroid.ClickOnLink(btnActionRequired);
        //            UIHelperAndroidApp.WaitForSpinnerInvisible(20);
        //            break;
        //    }
        //}

        //public void GetBucketCount(string bucket)
        //{
        //    switch (bucket)
        //    {
        //        case "Action required":
        //            initialBucketCount = Int32.Parse(lblActionRequiredCounter.Text);
        //            break;

        //        case "In process":
        //            initialBucketCount = Int32.Parse(lblInProcessCounter.Text);
        //            break;

        //        case "Funded":
        //            initialBucketCount = Int32.Parse(lblFundedCounter.Text);
        //            break;

        //        default:
        //            initialBucketCount = Int32.Parse(lblActionRequiredCounter.Text);
        //            break;
        //    }
        //}

        public void SelectBucketTab(string tabSelection)
        {
            switch (tabSelection)
            {
                case "Action required":
                    UIHelperAndroidApp.ClickOnLink(btnActionRequired);
                    UIHelperAndroidApp.WaitForSpinnerInvisible(20);
                    break;

                case "In process":
                    UIHelperAndroidApp.ClickOnLink(btnInProcess);
                    UIHelperAndroidApp.WaitForSpinnerInvisible(20);
                    break;

                case "Funded":
                    UIHelperAndroidApp.ClickOnLink(btnFunded);
                    UIHelperAndroidApp.WaitForSpinnerInvisible(20);
                    break;

                default:
                    UIHelperAndroidApp.ClickOnLink(btnActionRequired);
                    UIHelperAndroidApp.WaitForSpinnerInvisible(20);
                    break;
            }
        }

        public void GetBucketCount(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    initialBucketCount = Int32.Parse(lblActionRequiredCounter.Text);
                    break;

                case "In process":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    initialBucketCount = Int32.Parse(lblInProcessCounter.Text);
                    break;

                case "Funded":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    initialBucketCount = Int32.Parse(lblFundedCounter.Text);
                    break;

                default:
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    initialBucketCount = Int32.Parse(lblActionRequiredCounter.Text);
                    break;
            }
        }

        public void GetBucketCountMotion(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    initialBucketCount = Int32.Parse(lblActionRequiredCounter.Text);
                    break;

                case "In process":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    initialBucketCount = Int32.Parse(lblInProcessCounter.Text);
                    break;

                case "Funded":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    initialBucketCount = Int32.Parse(lblFundedCounter.Text);
                    break;

                default:
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    initialBucketCount = Int32.Parse(lblActionRequiredCounter.Text);
                    break;
            }
        }

        //public void SearchDeal(string searchOption, string searchText)
        //{
        //    UIHelperAndroid.ClickOnLink(btnSearchSolicitor);
        //    switch (searchOption)
        //    {
        //        case "City":
        //            UIHelperAndroid.ClickOnLink(btnCitySearch);
        //            break;

        //        case "FCT Reference No.":
        //            UIHelperAndroid.ClickOnLink(btnFCTRefNoSearch);
        //            break;

        //        case "Mortgagor Last Name":
        //            UIHelperAndroid.ClickOnLink(btnMortgagorSearch);
        //            break;

        //        default:
        //            break;
        //    }
        //    UIHelperAndroid.EnterText(txtSearch, searchText);
        //    UIHelperAndroid.ClickOnLink(btnSearch);
        //    UIHelperAndroidApp.WaitForSpinnerInvisible(10);
        //    UIHelperAndroid.WaitForElementVisible(lblAlertIcon, 15);
        //}

        public void SearchDeal(string searchOption, string searchText)
        {
            UIHelperAndroidApp.ClickOnLink(btnSearchSolicitor);
            switch (searchOption)
            {
                case "City":
                    UIHelperAndroidApp.ClickOnLink(btnCitySearch);
                    break;

                case "FCT Reference No.":
                    UIHelperAndroidApp.ClickOnLink(btnFCTRefNoSearch);
                    break;

                case "Mortgagor Last Name":
                    UIHelperAndroidApp.ClickOnLink(btnMortgagorSearch);
                    break;

                default:
                    break;
            }
            UIHelperAndroidApp.EnterText(txtSearch, searchText);
            UIHelperAndroidApp.ClickOnLink(btnSearch);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            UIHelperAndroid.WaitForElementVisible(lblAlertIcon, 15);
        }

        public void SearchDealMotion(string searchOption, string searchText)
        {
            UIHelperAndroidApp.ClickOnLink(btnSearchSolicitor);
            switch (searchOption)
            {
                case "City":
                    UIHelperAndroidApp.ClickOnLink(btnCitySearch);
                    break;

                case "FCT Reference No.":
                    UIHelperAndroidApp.ClickOnLink(btnFCTRefNoSearch);
                    break;

                case "Mortgagor Last Name":
                    UIHelperAndroidApp.ClickOnLink(btnMortgagorSearch);
                    break;

                default:
                    break;
            }
            UIHelperAndroidApp.EnterText(txtSearch, searchText);
            UIHelperAndroidApp.ClickOnLink(btnSearch);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            UIHelperAndroid.WaitForElementVisible(lblAlertIcon, 15);
        }

        //public void SearchDealWithoutAlert(string searchOption, string searchText)
        //{
        //    UIHelperAndroid.ClickOnLink(btnSearchSolicitor);
        //    switch (searchOption)
        //    {
        //        case "City":
        //            UIHelperAndroid.ClickOnLink(btnCitySearch);
        //            break;

        //        case "FCT Reference No.":
        //            UIHelperAndroid.ClickOnLink(btnFCTRefNoSearch);
        //            break;

        //        case "Mortgagor Last Name":
        //            UIHelperAndroid.ClickOnLink(btnMortgagorSearch);
        //            break;

        //        default:
        //            break;
        //    }
        //    UIHelperAndroid.EnterText(txtSearch, searchText);
        //    UIHelperAndroid.ClickOnLink(btnSearch);
        //    UIHelperAndroidApp.WaitForSpinnerInvisible(10);
        //    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon found on deal list page");
        //}

        public void SearchDealWithoutAlert(string searchOption, string searchText)
        {
            UIHelperAndroidApp.ClickOnLink(btnSearchSolicitor);
            switch (searchOption)
            {
                case "City":
                    UIHelperAndroidApp.ClickOnLink(btnCitySearch);
                    break;

                case "FCT Reference No.":
                    UIHelperAndroidApp.ClickOnLink(btnFCTRefNoSearch);
                    break;

                case "Mortgagor Last Name":
                    UIHelperAndroidApp.ClickOnLink(btnMortgagorSearch);
                    break;

                default:
                    break;
            }
            UIHelperAndroidApp.EnterText(txtSearch, searchText);
            UIHelperAndroidApp.ClickOnLink(btnSearch);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon found on deal list page");
        }

        public void SearchDealWithoutAlertMotion(string searchOption, string searchText)
        {
            UIHelperAndroidApp.ClickOnLink(btnSearchSolicitor);
            switch (searchOption)
            {
                case "City":
                    UIHelperAndroidApp.ClickOnLink(btnCitySearch);
                    break;

                case "FCT Reference No.":
                    UIHelperAndroidApp.ClickOnLink(btnFCTRefNoSearch);
                    break;

                case "Mortgagor Last Name":
                    UIHelperAndroidApp.ClickOnLink(btnMortgagorSearch);
                    break;

                default:
                    break;
            }
            UIHelperAndroidApp.EnterText(txtSearch, searchText);
            UIHelperAndroidApp.ClickOnLink(btnSearch);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon found on deal list page");
        }

        //public void SearchNotFoundDeal(string searchOption, string searchText)
        //{
        //    UIHelperAndroid.ClickOnLink(btnSearchSolicitor);
        //    switch (searchOption)
        //    {
        //        case "City":
        //            UIHelperAndroid.ClickOnLink(btnCitySearch);
        //            break;

        //        case "FCT Reference No.":
        //            UIHelperAndroid.ClickOnLink(btnFCTRefNoSearch);
        //            break;

        //        case "Mortgagor Last Name":
        //            UIHelperAndroid.ClickOnLink(btnMortgagorSearch);
        //            break;

        //        default:
        //            break;
        //    }
        //    UIHelperAndroid.EnterText(txtSearch, searchText);
        //    UIHelperAndroid.ClickOnLink(btnSearch);
        //    UIHelperAndroidApp.WaitForSpinnerInvisible(10);
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No Results')]")), "Deal is available");
        //}

        public void SearchNotFoundDeal(string searchOption, string searchText)
        {
            UIHelperAndroidApp.ClickOnLink(btnSearchSolicitor);
            switch (searchOption)
            {
                case "City":
                    UIHelperAndroidApp.ClickOnLink(btnCitySearch);
                    break;

                case "FCT Reference No.":
                    UIHelperAndroidApp.ClickOnLink(btnFCTRefNoSearch);
                    break;

                case "Mortgagor Last Name":
                    UIHelperAndroidApp.ClickOnLink(btnMortgagorSearch);
                    break;

                default:
                    break;
            }
            UIHelperAndroidApp.EnterText(txtSearch, searchText);
            UIHelperAndroidApp.ClickOnLink(btnSearch);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No Results')]")), "Deal is available");
        }

        public void SearchNotFoundDealMotion(string searchOption, string searchText)
        {
            UIHelperAndroidApp.ClickOnLink(btnSearchSolicitor);
            switch (searchOption)
            {
                case "City":
                    UIHelperAndroidApp.ClickOnLink(btnCitySearch);
                    break;

                case "FCT Reference No.":
                    UIHelperAndroidApp.ClickOnLink(btnFCTRefNoSearch);
                    break;

                case "Mortgagor Last Name":
                    UIHelperAndroidApp.ClickOnLink(btnMortgagorSearch);
                    break;

                default:
                    break;
            }
            UIHelperAndroidApp.EnterText(txtSearch, searchText);
            UIHelperAndroidApp.ClickOnLink(btnSearch);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'No Results')]")), "Deal is available");
        }

        //public void CancelSearch()
        //{
        //    UIHelperAndroid.ClickOnLink(btnCancelSearch);
        //    UIHelperAndroidApp.WaitForSpinnerInvisible(10);
        //    UIHelperAndroid.WaitForElementVisibleEC(By.XPath("(//android.widget.TextView[@content-desc='Help'])[2]"), 15);
        //}

        public void CancelSearch()
        {
            UIHelperAndroidApp.ClickOnLink(btnCancelSearch);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("(//android.widget.TextView[@content-desc='Help'])[2]"), 15);
        }

        public void CancelSearchMotion()
        {
            UIHelperAndroidApp.ClickOnLink(btnCancelSearch);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("(//android.widget.TextView[@content-desc='Help'])[2]"), 15);
        }

        //public void VerifyAlertIcon(bool status)
        //{
        //    if (status)
        //    {
        //        if (androidDriver.FindElements(By.XPath("//android.widget.TextView[contains(@text, 'Deal Details')]")).Count > 0)
        //        {
        //            Console.WriteLine("No alert icon found on deal list page");
        //        }
        //        else
        //        {
        //            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon not found");
        //        }
        //    }
        //    else
        //    {
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon found");
        //    }
        //}

        public void VerifyAlertIcon(bool status)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            if (status)
            {
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon not found");
            }
            else
            {
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon found");
            }
        }

        public void VerifyAlertIconMotion(bool status)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            if (status)
            {
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon not found");
            }
            else
            {
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.ImageView")), "Alert icon found");
            }
        }

        //public void AccessDealDetails(string mortgagorName)
        //{
        //    IWebElement dealElement = androidDriver.FindElement(By.XPath("//android.widget.TextView[contains(@text, '" + mortgagorName + "')]"));
        //    UIHelperAndroid.ClickOnLink(dealElement);
        //    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
        //    UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.TextView[contains(@text, 'Deal Details')]"), 15);
        //}

        public void AccessDealDetails(string mortgagorName)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            IWebElement dealElement = androidDriver.FindElement(By.XPath("//android.widget.TextView[contains(@text, '" + mortgagorName + "')]"));
            UIHelperAndroidApp.ClickOnLink(dealElement);
            UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.TextView[contains(@text, 'Deal Details')]"), 15);
        }

        public void AccessDealDetailsMotion(string mortgagorName)
        {
            UIHelperAndroidApp.AcknAlertIfAvailable();
            IWebElement dealElement = androidDriver.FindElement(By.XPath("//android.widget.TextView[contains(@text, '" + mortgagorName + "')]"));
            UIHelperAndroidApp.ClickOnLink(dealElement);
            UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            UIHelperAndroidApp.AcknAlertIfAvailable();
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//android.widget.TextView[contains(@text, 'Deal Details')]"), 15);
        }

        //public void VerifyBucketCount(string bucket)
        //{
        //    switch (bucket)
        //    {
        //        case "Action required":
        //            Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount));
        //            break;

        //        case "In process":
        //            Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount));
        //            break;

        //        case "Funded":
        //            Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount));
        //            break;

        //        default:
        //            Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount));
        //            break;
        //    }
        //}

        public void VerifyBucketCount(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount));
                    break;

                case "In process":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount));
                    break;

                case "Funded":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount));
                    break;

                default:
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount));
                    break;
            }
        }

        public void VerifyBucketCountMotion(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount));
                    break;

                case "In process":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount));
                    break;

                case "Funded":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount));
                    break;

                default:
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount));
                    break;
            }
        }

        //public void VerifyBucketCountDecreased(string bucket)
        //{
        //    switch (bucket)
        //    {
        //        case "Action required":
        //            Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount - 1));
        //            break;

        //        case "In process":
        //            Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount - 1));
        //            break;

        //        case "Funded":
        //            Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount - 1));
        //            break;

        //        default:
        //            Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount - 1));
        //            break;
        //    }
        //}

        public void VerifyBucketCountDecreased(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount - 1));
                    break;

                case "In process":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount - 1));
                    break;

                case "Funded":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount - 1));
                    break;

                default:
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount - 1));
                    break;
            }
        }

        public void VerifyBucketCountDecreasedMotion(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount - 1));
                    break;

                case "In process":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount - 1));
                    break;

                case "Funded":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount - 1));
                    break;

                default:
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount - 1));
                    break;
            }
        }

        //public void VerifyBucketCountIncreased(string bucket, int alertCount)
        //{
        //    switch (bucket)
        //    {
        //        case "Action required":
        //            Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount + alertCount));
        //            initialBucketCount = initialBucketCount + alertCount;
        //            break;

        //        case "In process":
        //            Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount + alertCount));
        //            initialBucketCount = initialBucketCount + alertCount;
        //            break;

        //        case "Funded":
        //            Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount + alertCount));
        //            initialBucketCount = initialBucketCount + alertCount;
        //            break;

        //        default:
        //            Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount + alertCount));
        //            initialBucketCount = initialBucketCount + alertCount;
        //            break;
        //    }
        //}

        public void VerifyBucketCountIncreased(string bucket, int alertCount)
        {
            switch (bucket)
            {
                case "Action required":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount + alertCount));
                    initialBucketCount = initialBucketCount + alertCount;
                    break;

                case "In process":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount + alertCount));
                    initialBucketCount = initialBucketCount + alertCount;
                    break;

                case "Funded":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount + alertCount));
                    initialBucketCount = initialBucketCount + alertCount;
                    break;

                default:
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount + alertCount));
                    initialBucketCount = initialBucketCount + alertCount;
                    break;
            }
        }

        public void VerifyBucketCountIncreasedMotion(string bucket, int alertCount)
        {
            switch (bucket)
            {
                case "Action required":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount + alertCount));
                    initialBucketCount = initialBucketCount + alertCount;
                    break;

                case "In process":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblInProcessCounter.Text).Equals(initialBucketCount + alertCount));
                    initialBucketCount = initialBucketCount + alertCount;
                    break;

                case "Funded":
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblFundedCounter.Text).Equals(initialBucketCount + alertCount));
                    initialBucketCount = initialBucketCount + alertCount;
                    break;

                default:
                    UIHelperAndroidApp.AcknAlertIfAvailable();
                    Assert.True(Int32.Parse(lblActionRequiredCounter.Text).Equals(initialBucketCount + alertCount));
                    initialBucketCount = initialBucketCount + alertCount;
                    break;
            }
        }

        //public void SignoutFromBrokerTracker()
        //{
        //    UIHelperAndroid.ClickOnLink(btnNavigation);
        //    UIHelperAndroid.ClickOnLink(btnSignout);
        //}

        public void SignoutFromBrokerTracker()
        {
            UIHelperAndroidApp.ClickOnLink(btnNavigation);
            UIHelperAndroidApp.ClickOnLink(btnSignout);
        }

        public void SignoutFromBrokerTrackerMotion()
        {
            UIHelperAndroidApp.ClickOnLink(btnNavigation);
            UIHelperAndroidApp.ClickOnLink(btnSignout);
        }

        //public void VerifyBrokerFilterAvailability(bool isAvailable)
        //{
        //    if (isAvailable)
        //    {
        //        Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'All Brokers')]")), "Broker filter is not available");
        //    }
        //    else
        //    {
        //        Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'All Brokers')]")), "Broker filter is available");
        //    }
        //}

        public void VerifyBrokerFilterAvailability(bool isAvailable)
        {
            if (isAvailable)
            {
                try
                {
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'All Brokers')]")), "Broker filter is not available");
                }
                catch (NoSuchElementException)
                {
                    UIHelperAndroidApp.AcknAlertIfAvailable();

                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'All Brokers')]")), "Broker filter is not available");
                }
            }
            else
            {
                try
                {
                    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'All Brokers')]")), "Broker filter is available");
                }
                catch (NoSuchElementException)
                {
                    UIHelperAndroidApp.AcknAlertIfAvailable();

                    Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'All Brokers')]")), "Broker filter is available");
                }
            }
        }

        public void VerifyMyProfileMenu()
        {
            UIHelperAndroidApp.WaitForSpinnerInvisible(20);
            UIHelperAndroidApp.ClickOnLink(btnNavigation);

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Settings')]")), "Settings menu is not available");

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Help')]")), "Help menu is not available");

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'My Profile')]")), "My profile menu is not available");

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Logout')]")), "Logout menu is not available");

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Email')]")), "Email menu is not available");

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, 'Call')]")), "Call menu is not available");
        }

        //public void GotoMyProfile()
        //{
        //    UIHelperAndroid.ClickOnLink(btnNavigation);
        //    UIHelperAndroid.ClickOnLink(btnMyProfile);
        //    UIHelperAndroidApp.WaitForSpinnerInvisible(15);
        //    UIHelperAndroid.WaitForSpinnerInvisible(15);
        //    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text, 'My Profile')]")), "Failed to access My Profile on Broker Tracker");
        //}

        public void GotoMyProfile()
        {
            UIHelperAndroidApp.ClickOnLink(btnNavigation);
            UIHelperAndroidApp.ClickOnLink(btnMyProfile);
            UIHelperAndroidApp.WaitForSpinnerInvisible(15);
            UIHelperAndroid.WaitForSpinnerInvisible(15);

            UIHelperAndroidApp.AcknAlertIfAvailable();
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.view.View[contains(@text, 'My Profile')]")), "Failed to access My Profile on Broker Tracker");
        }

        public void VerifyBrokerFilter(string brokerName, string brokerDelegateName)
        {
            //Assert.True(ddlBrFilterSelection.Text.Equals("All Brokers"), "All Brokers is not default selection on Broker filter");
            UIHelperAndroid.ClickOnLink(ddlBrokerFilter);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + brokerName + "')]")), brokerName + " is not available in broker filter");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.TextView[contains(@text, '" + brokerDelegateName + "')]")), brokerDelegateName + " is not available in broker filter");

            UIHelperAndroid.ClickOnLink(ddlBrokerFilter);
            UIHelperAndroidApp.WaitForSpinnerInvisible(10);
        }

        public void SelectBrokerFilter(string filterOption)
        {
            //UIHelperAndroid.ScrollToTop(androidDriver);
            UIHelperAndroid.ClickOnLink(ddlBrokerFilter);
            UIHelperAndroid.ClickOnLink(androidDriver.FindElement(By.XPath("//android.widget.TextView[contains(@text, '" + filterOption + "')]")));
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            Assert.True(ddlBrFilterSelection.Text.Equals(filterOption), "Broker filter is not selected");
        }

        public void VerifyDealAvailableDelegate(string fctUrn, bool isAvailable)
        {
            if (isAvailable)
            {
                SearchDeal("FCT Reference No.", fctUrn);
                VerifyAlertIcon(true);
            }
            else
            {
                SearchDeal("FCT Reference No.", fctUrn);
                VerifyAlertIcon(false);
            }
        }

        public void VerifyLogin(bool isAuthorized)
        {
            if (isAuthorized)
            {
                UIHelperAndroidApp.AcknAlertIfAvailable();
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//android.widget.RadioButton[contains(@text, 'FCT closed deals')]")), "User is not logged in");
            }
        }
    }
}
