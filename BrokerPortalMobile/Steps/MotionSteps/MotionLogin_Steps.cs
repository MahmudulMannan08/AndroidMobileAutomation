using BrokerPortalMobile.Pages.MotionPages;
using NUnit.Framework;
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
    public sealed class MotionLogin_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MotionLoginPage motionLoginPage;

        public MotionLogin_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I go to Motion portal")]
        public void GivenIGoToMotionPortal()
        {
            InitializeDriver("INTERNETEXPLORER");
            UIHelper.GoTo<MotionLoginPage>(MotionPortal);
            UIHelper.WaitForPageLoad(30);
            Thread.Sleep(5000);

            motionLoginPage = UIHelper.PageInit<MotionLoginPage>(driver);
            Assert.True(motionLoginPage.VerifyPageReady(), "Motion page did not load correctly");
        }

        [Then(@"I close Motion Portal")]
        public void ThenICloseMotionPortal()
        {
            motionLoginPage = UIHelper.PageInit<MotionLoginPage>(driver);
            motionLoginPage.closeMotionPortal();
        }

        [Then(@"I close Motion deal on Motion Portal")]
        public void ThenICloseMotionDealOnMotionPortal()
        {
            motionLoginPage.closeMotionDeal();
        }
    }
}
