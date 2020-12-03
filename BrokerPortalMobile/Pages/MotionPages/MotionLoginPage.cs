using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MotionPages
{
    public class MotionLoginPage : TestBase, IPage
    {
        [FindsBy(How = How.Id, Using = "cboUsers")]
        public IWebElement ddlUser;

        public string Url
        {
            get
            {
                return "";
            }
        }

        public bool VerifyPageReady()
        {
            int trial = 0;
            bool status = false;
            while (trial < 5)
            {
                try
                {
                    UIHelper.SwitchToFrame(30, By.Id("fraToolbar"));
                    if (ddlUser.Text.Length > 0)
                    {
                        status = true;
                        break;
                    }
                }
                catch (Exception)
                {
                }

                trial++;
                Thread.Sleep(3000);
                driver.Navigate().Refresh();
                UIHelper.WaitForPageLoad(10);
            }

            return status;
        }

        public void closeMotionPortal()
        {
            driver.Close();
            UIHelper.SwitchToBaseWindow();
            //driver.SwitchTo().DefaultContent();
            
            Thread.Sleep(1000);
            driver.Close();
            driver.Quit();
        }

        public void closeMotionDeal()
        {
            driver.Close();
            UIHelper.SwitchToBaseWindow();
            //driver.SwitchTo().DefaultContent();
        }
    }
}
