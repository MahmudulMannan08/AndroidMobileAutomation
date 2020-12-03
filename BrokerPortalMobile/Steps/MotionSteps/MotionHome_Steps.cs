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
    public sealed class MotionHome_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MotionHomePage motionHomePage;
        public static MotionSLAPage motionSLAPage;
        public static string fctUrnMotion = null;

        public MotionHome_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I select Title Officer on Motion Portal")]
        public void ThenISelectTitleOfficerOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.SelectTitleOfficer(MotionTitleOfficer);
        }

        [Then(@"I locate Motion deal and get FCTURN on Motion Portal")]
        public void ThenILocateMotionDealAndGetFCTURNOnMotionPortal()
        {
            motionHomePage.LocateMotionDeal(MotionDealDetails_Steps.mortgagorFirstName, MotionDealDetails_Steps.mortgagorLastName);
            fctUrnMotion = motionHomePage.GetFctUrnMotion();
        }

        [Then(@"I approve Motion deal on Motion Portal")]
        public void ThenIApproveMotionDealOnMotionPortal()
        {
            motionHomePage.ApproveMotionDeal();
        }

        [Then(@"I search deal on Motion Portal")]
        public void ThenISearchDealOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.SearchMotionDeal(fctUrnMotion);
        }

        [Then(@"I hold motion deal on Motion Portal")]
        public void ThenIHoldMotionDealOnMotionPortal()
        {
            motionHomePage.MotionSwitchToTab("SLA", fctUrnMotion);

            motionSLAPage = UIHelper.PageInit<MotionSLAPage>(driver);
            motionSLAPage.AddSLAMotion();

            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.HoldUnholdDeal(true);
        }

        [Then(@"I cancel motion deal on Motion Portal")]
        public void ThenICancelMotionDealOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.CancelDeal("Automated deal cancellation");
        }
    }
}
