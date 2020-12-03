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

namespace BrokerPortalMobile.Pages
{
    public class BPHomePage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'navbar-toggler-icon')]")]
        public IWebElement btnNavigation;

        [FindsBy(How = How.Id, Using = "navbardrop")]
        public IWebElement ddProfile;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign Out')]")]
        public IWebElement btnSignout;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'My Profile')]")]
        public IWebElement btnMyProfile;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Contact us')]")]
        public IWebElement btnContactUs;

        [FindsBy(How = How.Id, Using = "tab-A")]
        public IWebElement tabFCTClosedDeals;

        [FindsBy(How = How.Id, Using = "tab-B")]
        public IWebElement tabSolicitorClosedDeals;

        [FindsBy(How = How.TagName, Using = "select")]
        public IList<IWebElement> ddlSearchSolicitor;

        [FindsBy(How = How.Id, Using = "searchBox")]
        public IWebElement txtSearch;

        //[FindsBy(How = How.XPath, Using = "//button[@class='btn btn-success btn-custom form-control button-margin']")]
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Search')]")]
        public IWebElement btnSearch;

        [FindsBy(How = How.XPath, Using = "//span[@class='info-box-number info-box-numberfontsize']")]
        public IList<IWebElement> lblActionRequiredCounter;

        //[FindsBy(How = How.XPath, Using = "//table[contains(@class,'table-custom table-striped')]")]
        [FindsBy(How = How.TagName, Using = "table")]
        public IWebElement tblDeals;

        [FindsBy(How = How.XPath, Using = "//em[contains(@class,'fa fa-exclamation-circle')]")]
        public IWebElement lblAlertIcon;

        [FindsBy(How = How.XPath, Using = "//label[@class='subheader2-label']")]
        public IWebElement lblDealDetails;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'home-text')]")]
        public IWebElement btnHome;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'New Note')]")]
        public IWebElement btnNewNote;

        [FindsBy(How = How.XPath, Using = "//body/app-root/app-layouts-auth/fw-framework-body/div/div/div/div/div/app-home/div/div/div/app-non-solicitor/div/div[1]/fw-infobox[1]/div[1]")]
        public IWebElement btnActionRequired;

        [FindsBy(How = How.XPath, Using = "//body/app-root/app-layouts-auth/fw-framework-body/div/div/div/div/div/app-home/div/div/div/app-non-solicitor/div/div[2]/fw-infobox[1]/div[1]")]
        public IWebElement btnInProcess;

        [FindsBy(How = How.XPath, Using = "//body/app-root/app-layouts-auth/fw-framework-body/div/div/div/div/div/app-home/div/div/div/app-non-solicitor/div/div[3]/fw-infobox[1]/div[1]")]
        public IWebElement btnFunded;

        [FindsBy(How = How.XPath, Using = "//div[@id='fctApp']//div//div//fw-header//header//div//nav//div//select")]
        public IWebElement ddlBrokerFilter;

        [FindsBy(How = How.XPath, Using = "//div[@class='text-danger']")]
        public IWebElement invalidSearchMsg;

        public void SignoutFromBrokerPortal()
        {
            UIHelperAndroid.WaitForSpinnerInvisible(30);
            UIHelperAndroid.WaitForElementVisible(btnNavigation, 40);
            btnNavigation.Click();
            UIHelperAndroid.ClickOnLink(ddProfile);
            UIHelperAndroid.ClickOnLink(btnSignout);
            UIHelperAndroid.WaitForPageLoad(30);
        }

        public void SelectDealsTab(string tabSelection)
        {
            UIHelperAndroid.WaitForSpinnerInvisible(10);
            UIHelperAndroid.WaitForSpinnerInvisible(10);

            switch (tabSelection)
            {
                case "FCT closed deals":
                    UIHelperAndroid.ClickOnLink(tabFCTClosedDeals);
                    UIHelperAndroid.WaitForSpinnerInvisible(25);
                    Assert.True(tabFCTClosedDeals.GetAttribute("class").Contains("active"));
                    break;

                case "Solicitor closed deals":
                    UIHelperAndroid.ClickOnLink(tabSolicitorClosedDeals);
                    UIHelperAndroid.WaitForSpinnerInvisible(25);
                    Assert.True(tabSolicitorClosedDeals.GetAttribute("class").Contains("active"));
                    break;

                default:
                    UIHelperAndroid.ClickOnLink(tabFCTClosedDeals);
                    UIHelperAndroid.WaitForSpinnerInvisible(25);
                    Assert.True(tabFCTClosedDeals.GetAttribute("class").Contains("active"));
                    break;
            }
        }

        public void SelectBucketTab(string tabSelection)
        {
            UIHelperAndroid.ScrollToTop(androidDriver);
            switch (tabSelection)
            {
                case "Action required":
                    UIHelperAndroid.ClickOnLink(btnActionRequired);
                    UIHelperAndroid.WaitForSpinnerInvisible(25);
                    Assert.True(btnActionRequired.GetAttribute("class").Contains("selected"));
                    break;

                case "In process":
                    UIHelperAndroid.ClickOnLink(btnInProcess);
                    UIHelperAndroid.WaitForSpinnerInvisible(25);
                    Assert.True(btnInProcess.GetAttribute("class").Contains("selected"));
                    break;

                case "Funded":
                    UIHelperAndroid.ClickOnLink(btnFunded);
                    UIHelperAndroid.WaitForSpinnerInvisible(25);
                    Assert.True(btnFunded.GetAttribute("class").Contains("selected"));
                    break;

                default:
                    UIHelperAndroid.ClickOnLink(btnActionRequired);
                    UIHelperAndroid.WaitForSpinnerInvisible(25);
                    Assert.True(btnActionRequired.GetAttribute("class").Contains("selected"));
                    break;
            }

            UIHelperAndroid.ScrollToElement(androidDriver, tabSolicitorClosedDeals);
            Thread.Sleep(2000);
        }

        public void SearchDeal(string option, string searchText)
        {
            UIHelperAndroid.WaitForElementVisible(txtSearch, 25);
            UIHelperAndroid.SelectComboElement(ddlSearchSolicitor[0], option);
            UIHelperAndroid.EnterText(txtSearch, searchText);
            Thread.Sleep(2000);
            UIHelperAndroid.ScrollToElement(androidDriver, tabSolicitorClosedDeals);
            Thread.Sleep(2000);
            UIHelperAndroid.ClickOnLink(btnSearch);
            UIHelperAndroid.WaitForSpinnerInvisible(10);
            UIHelper.WaitUntillExpectedTableEntry(tblDeals, 1, 1, 20);
        }

        public void SearchDealMultiple(string option, string searchText)
        {
            UIHelperAndroid.ScrollToTop(androidDriver);
            UIHelperAndroid.WaitForElementVisible(txtSearch, 25);
            UIHelperAndroid.SelectComboElement(ddlSearchSolicitor[0], option);
            UIHelperAndroid.EnterText(txtSearch, searchText);
            Thread.Sleep(2000);
            UIHelperAndroid.ScrollToElement(androidDriver, tabSolicitorClosedDeals);
            Thread.Sleep(2000);
            UIHelperAndroid.ClickOnLink(btnSearch);
            UIHelperAndroid.WaitForSpinnerInvisible(10);
            Assert.False(UIHelperAndroid.VerifyBlankGrid(tblDeals, 1), "Grid does not contain deal");
        }

        public void SearchDealDelegate(string option, string searchText)
        {
            UIHelperAndroid.WaitForElementVisible(txtSearch, 25);
            UIHelperAndroid.SelectComboElement(ddlSearchSolicitor[1], option);
            UIHelperAndroid.EnterText(txtSearch, searchText);
            Thread.Sleep(2000);
            UIHelperAndroid.ScrollToElement(androidDriver, tabSolicitorClosedDeals);
            Thread.Sleep(2000);
            UIHelperAndroid.ClickOnLink(btnSearch);
            UIHelperAndroid.WaitForSpinnerInvisible(10);
            UIHelper.WaitUntillExpectedTableEntry(tblDeals, 1, 1, 20);
        }

        public void SearchNotFoundDeal(string option, string searchText)
        {
            UIHelperAndroid.WaitForElementVisible(txtSearch, 25);
            UIHelperAndroid.SelectComboElement(ddlSearchSolicitor[0], option);
            UIHelperAndroid.EnterText(txtSearch, searchText);
            Thread.Sleep(2000);
            UIHelperAndroid.ScrollToElement(androidDriver, tabSolicitorClosedDeals);
            Thread.Sleep(2000);
            UIHelperAndroid.ClickOnLink(btnSearch);
            UIHelperAndroid.WaitForSpinnerInvisible(10);
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//div[@class='text-danger']"), 10);
            Assert.True(UIHelperAndroid.VerifyBlankGrid(tblDeals, 1), "Grid contains deal");
        }

        public void SearchNotFoundDealDelegate(string option, string searchText)
        {
            UIHelperAndroid.WaitForElementVisible(txtSearch, 25);
            UIHelperAndroid.SelectComboElement(ddlSearchSolicitor[1], option);
            UIHelperAndroid.EnterText(txtSearch, searchText);
            Thread.Sleep(2000);
            UIHelperAndroid.ScrollToElement(androidDriver, tabSolicitorClosedDeals);
            Thread.Sleep(2000);
            UIHelperAndroid.ClickOnLink(btnSearch);
            UIHelperAndroid.WaitForSpinnerInvisible(10);
            UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//div[@class='text-danger']"), 10);
            UIHelperAndroid.VerifyBlankGrid(tblDeals, 1);
        }

        public void SearchDealWithoutAlert(string option, string searchText)
        {
            UIHelperAndroid.WaitForElementVisible(txtSearch, 25);
            UIHelperAndroid.SelectComboElement(ddlSearchSolicitor[0], option);
            UIHelperAndroid.EnterText(txtSearch, searchText);
            Thread.Sleep(2000);
            UIHelperAndroid.ScrollToElement(androidDriver, tabSolicitorClosedDeals);
            Thread.Sleep(2000);
            UIHelperAndroid.ClickOnLink(btnSearch);
            UIHelperAndroid.WaitForSpinnerInvisible(10);
            UIHelperAndroid.WaitForPageLoad(10);
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.WaitUntilElementHasText(lblDealDetails, "Deal Details", 15);
            //Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//div[contains(@class,'text-danger')]")), "Expected deal not found error message not available");
            //Assert.True(androidDriver.FindElement(By.XPath("//div[contains(@class,'text-danger')]")).Text.Equals(NoResultFoundMessage), "Error message does not match");
        }

        public void VerifyAlertIcon(bool status)
        {
            if (status)
            {
                if (UIHelperAndroid.IsElementDisplayed(By.ClassName("subheader2-label")))
                {
                    Console.WriteLine("No alert icon found on deal list page");
                }
                else
                {
                    Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//em[contains(@class,'fa fa-exclamation-circle')]")), "Alert icon not found");
                }
            }
            else
            {
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//em[contains(@class,'fa fa-exclamation-circle')]")), "Alert icon found");
            }
        }

        public void AccessDealDetails(string fctUrn)
        {
            UIHelperAndroid.ScrollToElement(androidDriver, btnSearch);
            UIHelperAndroid.SearchGridAndVerify(tblDeals, fctUrn, 1, 1);
            UIHelperAndroid.WaitForPageLoad(10);
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.WaitUntilElementHasText(lblDealDetails, "Deal Details", 15);
        }

        public void GotoHomepage()
        {
            UIHelperAndroid.ScrollToTop(androidDriver);
            UIHelperAndroid.ClickOnLink(btnHome);
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//button[@class='btn btn-success btn-custom form-control button-margin']")), "Not redirected to Home page");
        }

        public void GetBucketCount(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    initialBucketCount = Int32.Parse(lblActionRequiredCounter[0].Text);
                    break;

                case "In process":
                    initialBucketCount = Int32.Parse(lblActionRequiredCounter[1].Text);
                    break;

                case "Funded":
                    initialBucketCount = Int32.Parse(lblActionRequiredCounter[2].Text);
                    break;

                default:
                    initialBucketCount = Int32.Parse(lblActionRequiredCounter[0].Text);
                    break;
            }
        }

        public void VerifyBucketCount(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[0].Text).Equals(initialBucketCount));
                    break;

                case "In process":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[1].Text).Equals(initialBucketCount));
                    break;

                case "Funded":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[2].Text).Equals(initialBucketCount));
                    break;

                default:
                    Assert.True(Int32.Parse(lblActionRequiredCounter[0].Text).Equals(initialBucketCount));
                    break;
            }
        }

        public void VerifyBucketCountMultiAlert(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[0].Text).Equals(2));
                    break;

                case "In process":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[1].Text).Equals(2));
                    break;

                case "Funded":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[2].Text).Equals(2));
                    break;

                default:
                    Assert.True(Int32.Parse(lblActionRequiredCounter[0].Text).Equals(2));
                    break;
            }
        }

        public void VerifyBucketCountDecreased(string bucket)
        {
            switch (bucket)
            {
                case "Action required":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[0].Text).Equals(initialBucketCount - 1));
                    break;

                case "In process":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[1].Text).Equals(initialBucketCount - 1));
                    break;

                case "Funded":
                    Assert.True(Int32.Parse(lblActionRequiredCounter[2].Text).Equals(initialBucketCount - 1));
                    break;

                default:
                    Assert.True(Int32.Parse(lblActionRequiredCounter[0].Text).Equals(initialBucketCount - 1));
                    break;
            }
        }

        public void VerifyMyProfileMenu()
        {
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.ClickOnLink(btnNavigation);
            UIHelperAndroid.ClickOnLink(ddProfile);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'My Profile')]")), "My profile menu is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Contact us')]")), "Contact Us menu is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Sign Out')]")), "Sign out menu is not available");
            UIHelperAndroid.ClickOnLink(btnNavigation);
        }

        public void GotoMyProfile()
        {
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.ClickOnLink(btnNavigation);
            UIHelperAndroid.ClickOnLink(ddProfile);
            UIHelperAndroid.ClickOnLink(btnMyProfile);
            UIHelperAndroid.WaitForPageLoad(20);
        }

        public void VerifyBrokerFilterAvailability(bool isAvailable)
        {
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            if (isAvailable)
            {
                Assert.True(ddlSearchSolicitor[0].Text.Contains("All Brokers"), "Broker filter is not available");
            }
            else
            {
                Assert.False(ddlSearchSolicitor[0].Text.Contains("All Brokers"), "Broker filter is available");
            }
        }

        public bool IsBrokerAvailable(string option)
        {
            UIHelperAndroid.ScrollToTop(androidDriver);
            UIHelperAndroid.ClickOnLink(ddlBrokerFilter);
            var optionCount = ddlBrokerFilter.FindElements(By.TagName("option")).Count();
            IList<IWebElement> allOptions = ddlBrokerFilter.FindElements(By.TagName("option"));
            bool found = false;

            for (int i = 0; i < optionCount;)
            {
                if (allOptions[i].Text == option)
                {
                    found = true;
                    break;
                }
                else
                {
                    i++;

                    if (i == optionCount)
                    {
                        Console.WriteLine(option, " not available in the drop down");
                    }
                }
            }

            return found;
        }

        public void VerifyBrokerFilter(string brokerName, string brokerDelegateName)
        {
            SelectElement selectValue = new SelectElement(ddlBrokerFilter);
            string selectedOption = selectValue.SelectedOption.Text;
            Assert.True(selectedOption.Equals("All Brokers"), "All Brokers is not default selection on broker filter");
            Assert.True(IsBrokerAvailable(brokerName), brokerName + " is not available in broker filter");
            Assert.True(IsBrokerAvailable(brokerDelegateName), brokerDelegateName + " is not available in broker filter");
        }

        public void SelectBrokerFilter(string filterOption)
        {
            UIHelperAndroid.ScrollToTop(androidDriver);
            UIHelperAndroid.SelectComboElement(ddlBrokerFilter, filterOption);
            UIHelperAndroid.WaitForSpinnerInvisible(20);
        }

        public void VerifyDealAvailableDelegate(string fctUrn, bool isAvailable)
        {
            if (isAvailable)
            {
                SearchDealDelegate("FCT Reference No.", fctUrn);
                VerifyAlertIcon(true);
            }
            else
            {
                SearchNotFoundDealDelegate("FCT Reference No.", fctUrn);
                VerifyAlertIcon(false);
            }
        }

        public void VerifyLogin(bool isAuthorized)
        {
            if (isAuthorized)
            {
                UIHelperAndroid.WaitForSpinnerInvisible(10);
                UIHelperAndroid.WaitForSpinnerInvisible(10);
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.Id("tab-A")), "User is not logged in");
            }
        }

        public bool IsSearchOptionAvailable(string option)
        {
            //UIHelperAndroid.ClickOnLink(ddlSearchSolicitor[0]);
            var optionCount = ddlSearchSolicitor[0].FindElements(By.TagName("option")).Count();
            IList<IWebElement> allOptions = ddlSearchSolicitor[0].FindElements(By.TagName("option"));
            bool found = false;

            for (int i = 0; i < optionCount;)
            {
                if (allOptions[i].Text == option)
                {
                    found = true;
                    break;
                }
                else
                {
                    i++;

                    if (i == optionCount)
                    {
                        Console.WriteLine(option, " not available in the drop down");
                    }
                }
            }

            return found;
        }

        public void VerifySearchByDropdown()
        {
            UIHelperAndroid.WaitForElementVisibleEC(By.Id("searchBox"), 25);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//div[@id='solicitorClosedDeals']//app-non-solicitor//form//div//div//div//select")), "Search By dropdown is not available");
            Assert.True(IsSearchOptionAvailable("City"));
            Assert.True(IsSearchOptionAvailable("FCT Reference No."));
            Assert.True(IsSearchOptionAvailable("Mortgagor Last Name"));
        }

        public void VerifyInvalidSearch(string invalidSearch, string invalidMsg)
        {
            UIHelperAndroid.EnterText(txtSearch, invalidSearch);
            Thread.Sleep(2000);
            UIHelperAndroid.ScrollToElement(androidDriver, tabSolicitorClosedDeals);
            Thread.Sleep(2000);
            UIHelperAndroid.ClickOnLink(btnSearch);
            UIHelperAndroid.WaitForSpinnerInvisible(10);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//div[@class='text-danger']")), "Invalid search message is not displayed");
            Assert.True(invalidSearchMsg.Text.Equals(invalidMsg));
            Assert.True(UIHelperAndroid.VerifyBlankGrid(tblDeals, 1), "Grid contains deal");
        }
    }
}
