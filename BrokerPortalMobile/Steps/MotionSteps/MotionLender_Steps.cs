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
    public sealed class MotionLender_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MotionHomePage motionHomePage;
        public static MotionLenderPage motionLenderPage;

        public MotionLender_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I assign Motion deal to broker")]
        public void ThenIAssignMotionDealToBroker()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Lender", MotionHome_Steps.fctUrnMotion);

            motionLenderPage = UIHelper.PageInit<MotionLenderPage>(driver);
            motionLenderPage.LenderSwitchToTab("Broker", MotionHome_Steps.fctUrnMotion);
            //motionLenderPage.SearchCRM(BrokerCRMFirstName, BrokerCRMLastName);
            motionLenderPage.SearchCRM(BrokerCRMFirstName, BrokerCRMLastName, MotionHome_Steps.fctUrnMotion);
            motionLenderPage.AddBroker(BrokerCRMEmail, MotionHome_Steps.fctUrnMotion);
            motionLenderPage.SaveMotionDeal();
        }

        [Then(@"I set appointment date on Motion Portal")]
        public void ThenISetAppointmentDateOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Lender", MotionHome_Steps.fctUrnMotion);

            motionLenderPage = UIHelper.PageInit<MotionLenderPage>(driver);
            motionLenderPage.SetUnsetApptDate(true);
        }

        [Then(@"I unset appointment date on Motion Portal")]
        public void ThenIUnsetAppointmentDateOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Lender", MotionHome_Steps.fctUrnMotion);

            motionLenderPage = UIHelper.PageInit<MotionLenderPage>(driver);
            motionLenderPage.SetUnsetApptDate(false);
        }
    }
}
