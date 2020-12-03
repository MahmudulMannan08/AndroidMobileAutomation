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
    public class BPDelegateAuthPage : TestBase
    {
        //[FindsBy(How = How.XPath, Using = "//input[@class='form-control form-control-md ng-untouched ng-pristine ng-invalid']")]
        [FindsBy(How = How.XPath, Using = "//div[@id='main']//div//div//app-delegated-authority//div//form//div//div//input")]
        public IWebElement txtLoginID;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement btnSubmit;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add')]")]
        public IWebElement btnAdd;

        [FindsBy(How = How.XPath, Using = "//table[@class='table']")]
        public IWebElement tblDelegate;

        [FindsBy(How = How.XPath, Using = "//div[@class='text-danger text-custom text-bold']")]
        public IWebElement lblDelegatedAuth;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Login ID:')]")]
        public IWebElement lblLoginId;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'navbar-toggler-icon')]")]
        public IWebElement btnNavigation;

        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Login ID')]")]
        public IWebElement lblTblHeader;

        [FindsBy(How = How.XPath, Using = "//html//body//app-root//app-layouts-auth//fw-framework-body//div//div//div//fw-left-menu//div//em")]
        public IWebElement btnNavigationProfile;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Broker office administrators and other Brokers can')]")]
        public IWebElement lblDelegateText;

        public void SearchDelegateGridAndVerify(IWebElement Table, string verify, int verifyColumn, string activity = "ENABLE")
        {
            var rowCount = Table.FindElements(By.TagName("tr")).Count();
            IList<IWebElement> allRows = Table.FindElements(By.TagName("tr"));

            if (rowCount > 1)
            {
                for (int i = 1; i < rowCount;)
                {
                    IList<IWebElement> Columns = allRows[i].FindElements(By.TagName("td"));
                    if (Columns[verifyColumn].Text.Contains(verify))
                    {
                        //UIHelperAndroid.SwipeToElementAndroid(Columns[0], Columns[5], "HORIZONTAL");
                        IList<IWebElement> allLinks = Columns[5].FindElements(By.TagName("a"));
                        if (activity.ToUpper() == "ENABLE")
                        {
                            if (!UIHelperAndroid.IsAttributePreset(allLinks[2], "class"))
                            {
                                Assert.True(allLinks[2].Displayed && allLinks[2].Enabled, "Enable link is not clickable");
                                UIHelperAndroid.ClickOnLink(allLinks[2]);
                                UIHelperAndroid.WaitForSpinnerInvisible(20);
                                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//div[@class='text-success']")), "Could not enable/disable/delete delegate");
                            }
                        }
                        if (activity.ToUpper() == "DISABLE")
                        {
                            if (!UIHelperAndroid.IsAttributePreset(allLinks[1], "class"))
                            {
                                Assert.True(allLinks[1].Displayed && allLinks[1].Enabled, "Disable link is not clickable");
                                UIHelperAndroid.ClickOnLink(allLinks[1]);
                                UIHelperAndroid.WaitForSpinnerInvisible(20);
                                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//div[@class='text-success']")), "Could not enable/disable/delete delegate");
                            }                         
                        }
                        if (activity.ToUpper() == "DELETE")
                        {
                            if (!UIHelperAndroid.IsAttributePreset(allLinks[0], "class"))
                            {
                                Assert.True(allLinks[0].Displayed && allLinks[0].Enabled, "Delete link is not clickable");
                                UIHelperAndroid.ClickOnLink(allLinks[0]);
                                UIHelperAndroid.SwitchToAlertWindow(10, true);
                                UIHelperAndroid.WaitForSpinnerInvisible(20);
                                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//div[@class='text-success']")), "Could not enable/disable/delete delegate");
                            }                            
                        }
                        
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else
            {
                Assert.True(rowCount > 1, "Table contains no data");
            }
        }

        public void AddDelegate(string brokerUsername)
        {
            int delegateRowCountInitial = 0;
            if (UIHelperAndroid.IsElementDisplayed(By.XPath("//table[@class='table']")))
            {
                delegateRowCountInitial = UIHelperAndroid.GetTableRowCount(tblDelegate);
            }
            UIHelperAndroid.EnterText(txtLoginID, brokerUsername);
            //Thread.Sleep(1000);
            UIHelperAndroid.SwipeToElementAndroid(lblLoginId, btnSubmit, "DOWN");
            //Thread.Sleep(1000);
            UIHelperAndroid.ClickOnLink(btnSubmit);
            UIHelperAndroid.WaitForSpinnerInvisible(30);
            if (!UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Delegated authority already assigned.')]")))
            {
                UIHelperAndroid.WaitForElementVisibleEC(By.XPath("//button[contains(text(),'Add')]"), 20);
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//button[contains(text(),'Add')]")), "Broker to be delegated username not found");

                UIHelperAndroid.ClickOnLink(btnAdd);
                UIHelperAndroid.WaitForSpinnerInvisible(20);
                UIHelperAndroid.WaitUntillExpectedTableEntry(tblDelegate, delegateRowCountInitial + 1, 1, 20);
            }
        }

        public void EnableDisableDeleteDelegate(string brokerToDeletageUsername, string activity = "ENABLE")
        {
            UIHelperAndroid.EnterText(txtLoginID, "");
            UIHelperAndroid.SwipeToElementAndroid(lblLoginId, btnSubmit, "DOWN");
            SearchDelegateGridAndVerify(tblDelegate, brokerToDeletageUsername, 0, activity);
        }
    }
}
