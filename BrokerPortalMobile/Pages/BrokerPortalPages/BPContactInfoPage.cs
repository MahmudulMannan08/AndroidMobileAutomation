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
    public class BPContactInfoPage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//div[8]//div[1]//input[1]")]
        public IWebElement txtUnitNo;

        [FindsBy(How = How.XPath, Using = "//div[9]//div[1]//input[1]")]
        public IWebElement txtStreetNo;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Update')]")]
        public IWebElement btnUpdate;

        [FindsBy(How = How.XPath, Using = "//body[1]/app-root[1]/app-layouts-auth[1]/fw-framework-body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/app-contact-information[1]/div[1]/form[1]/div[16]/div[1]/div[1]/input[1]")]
        public IWebElement txtBusinessPhone;

        public void UpdateContactInfo(string unitNo, string streetNo)
        {
            UIHelperAndroid.EnterText(txtUnitNo, unitNo);
            UIHelperAndroid.EnterText(txtStreetNo, streetNo);
            UIHelper.EnterText(txtBusinessPhone, "");
            UIHelperAndroid.ClickOnLink(btnUpdate);
            UIHelperAndroid.WaitForSpinnerInvisible(20);
            UIHelperAndroid.WaitForElementVisible(androidDriver.FindElement(By.XPath("//div[@class='text-success mb-2 mt-2']")), 10);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//div[@class='text-success mb-2 mt-2']")), "Contact Information was not updated");
        }

        public void VerifyContactInfoUpdate(string unitNo, string streetNo)
        {
            Assert.True(txtUnitNo.GetAttribute("value").Equals(unitNo), "Unit No value was not updated on Contact Information");
            Assert.True(txtStreetNo.GetAttribute("value").Equals(streetNo), "Street Number value was not updated on Contact Information");
        }
    }
}
