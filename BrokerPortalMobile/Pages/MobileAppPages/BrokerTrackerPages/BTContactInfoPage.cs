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
    public class BTContactInfoPage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement txtUnitNo;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement txtStreetNo;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement btnUpdate;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement txtBusinessPhone;
    }
}
