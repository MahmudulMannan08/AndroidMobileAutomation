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
    public sealed class MotionDealDetails_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MotionHomePage motionHomePage;
        public static MotionDealDetailsPage motionDealDetailsPage;

        public static string mortgagorFirstName = "Mortf" + GenerateNumber(4);
        public static string mortgagorLastName = "Mortl" + GenerateNumber(4);

        public MotionDealDetails_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I select program and lender for new order on Motion Portal")]
        public void ThenISelectProgramAndLenderForNewOrderOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.ClickNewOrder();

            motionDealDetailsPage = UIHelper.PageInit<MotionDealDetailsPage>(driver);
            motionDealDetailsPage.SelectLenderProgram(MotionProgram);
        }

        [Then(@"I submit new order on Motion Portal")]
        public void ThenISubmitNewOrderOnMotionPortal()
        {
            //motionDealDetailsPage.CreateNewOrder(CurrentOrPastDate("ddd. MMM. d, yyyy"));
            motionDealDetailsPage.CreateNewOrder(mortgagorFirstName, mortgagorLastName, MotionPropertyAddress, MotionPropertyCity, CurrentOrFutureDate("ddd. MMM. d, yyyy"));
        }
    }
}
