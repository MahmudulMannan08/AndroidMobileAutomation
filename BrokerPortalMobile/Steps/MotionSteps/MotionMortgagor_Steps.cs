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
    public sealed class MotionMortgagor_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MotionHomePage motionHomePage;
        public static MotionMortgagorPage motionMortgagorPage;

        public static string companyName = "Comp" + GenerateNumber(5);
        public static string mortgagorFullName = MotionDealDetails_Steps.mortgagorFirstName + " " + MotionDealDetails_Steps.mortgagorLastName;

        public MotionMortgagor_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I update business mortgagor information on Motion Portal")]
        public void ThenIUpdateBusinessMortgagorInformationOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Mortgagor", MotionHome_Steps.fctUrnMotion);

            motionMortgagorPage = UIHelper.PageInit<MotionMortgagorPage>(driver);
            motionMortgagorPage.UpdateMotionMortgagor("Business", companyName);
            mortgagorFullName = companyName;
        }

        [Then(@"I add person mortgagor information on Motion Portal")]
        public void ThenIAddPersonMortgagorInformationOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Mortgagor", MotionHome_Steps.fctUrnMotion);

            motionMortgagorPage = UIHelper.PageInit<MotionMortgagorPage>(driver);
            motionMortgagorPage.AddMotionMortgagor("Person", "", MotionDealDetails_Steps.mortgagorFirstName, MotionDealDetails_Steps.mortgagorLastName);
            mortgagorFullName = companyName;
        }
    }
}