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
    public sealed class MotionFunding_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MotionHomePage motionHomePage;
        public static MotionFundingPage motionFundingPage;

        public MotionFunding_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I set funding completion date on Motion Portal")]
        public void ThenISetFundingCompletionDateOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Funding", MotionHome_Steps.fctUrnMotion);

            motionFundingPage = UIHelper.PageInit<MotionFundingPage>(driver);
            motionFundingPage.FundingSwitchToTab("Disbursements");

            motionFundingPage.SetUnsetFundingCompletion(true);
        }

        [Then(@"I unset funding completion date on Motion Portal")]
        public void ThenIUnsetFundingCompletionDateOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Funding", MotionHome_Steps.fctUrnMotion);

            motionFundingPage = UIHelper.PageInit<MotionFundingPage>(driver);
            motionFundingPage.FundingSwitchToTab("Disbursements");

            motionFundingPage.SetUnsetFundingCompletion(false);
        }
    }
}
