using BrokerPortalMobile.Pages.MotionPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile.Steps.MotionSteps
{
    [Binding]
    public sealed class MotionProperty_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MotionHomePage motionHomePage;
        public static MotionPropertyPage motionPropertyPage;
        public static MotionLenderPage motionLenderPage;

        //public static string milestoneDates = CurrentDay() + ". " + CurrentDate("MMM. d, yyyy");

        public MotionProperty_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I set payout ordered date on Motion Portal")]
        public void ThenISetPayoutOrderedDateOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Property", MotionHome_Steps.fctUrnMotion);

            motionPropertyPage = UIHelper.PageInit<MotionPropertyPage>(driver);
            motionPropertyPage.PropertySwitchToTab("Encumbrances", MotionHome_Steps.fctUrnMotion);
            motionPropertyPage.PropertySwitchToSubTab("Payout Facility", MotionHome_Steps.fctUrnMotion);

            motionPropertyPage.SetUnsetPayoutOrdered(true);
        }

        [Then(@"I unset payout ordered date on Motion Portal")]
        public void ThenIUnsetPayoutOrderedDateOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Property", MotionHome_Steps.fctUrnMotion);

            motionPropertyPage = UIHelper.PageInit<MotionPropertyPage>(driver);
            motionPropertyPage.PropertySwitchToTab("Encumbrances", MotionHome_Steps.fctUrnMotion);
            motionPropertyPage.PropertySwitchToSubTab("Payout Facility", MotionHome_Steps.fctUrnMotion);

            motionPropertyPage.SetUnsetPayoutOrdered(false);
        }

        [Then(@"I set payout received date on Motion Portal")]
        public void ThenISetPayoutReceivedDateOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Property", MotionHome_Steps.fctUrnMotion);

            motionPropertyPage = UIHelper.PageInit<MotionPropertyPage>(driver);
            motionPropertyPage.PropertySwitchToTab("Encumbrances", MotionHome_Steps.fctUrnMotion);
            motionPropertyPage.PropertySwitchToSubTab("Payout Facility", MotionHome_Steps.fctUrnMotion);

            motionPropertyPage.SetUnsetPayoutReceived(true);
        }

        [Then(@"I unset payout received date on Motion Portal")]
        public void ThenIUnsetPayoutReceivedDateOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Property", MotionHome_Steps.fctUrnMotion);

            motionPropertyPage = UIHelper.PageInit<MotionPropertyPage>(driver);
            motionPropertyPage.PropertySwitchToTab("Encumbrances", MotionHome_Steps.fctUrnMotion);
            motionPropertyPage.PropertySwitchToSubTab("Payout Facility", MotionHome_Steps.fctUrnMotion);

            motionPropertyPage.SetUnsetPayoutReceived(false);
        }
    }
}
