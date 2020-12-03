using BrokerPortalMobile.Pages.MMSPortalPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile.Steps.MMSPortalSteps
{
    [Binding]
    public sealed class MMSMortgagor_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSViewDealPage mmsViewDealPage;
        public static MMSMortgagorPage mmsMortgagorPage;
        public static string mortgagorFirstName = "Mortgagor-" + GenerateString(4);
        public static string mortgagorStreetNumber = GenerateNumber(4);
        public static string mortgagorBusiness = "MortBusiness-" + GenerateString(4);
        public static string mortgagorFullName = MMSNewDeal_Steps.mortgagorLastName;

        public MMSMortgagor_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I update person mortgagor information on MMS Portal")]
        public void ThenIUpdatePersonMortgagorInformationOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Mortgagor");

            mmsMortgagorPage = UIHelper.PageInit<MMSMortgagorPage>(driver);
            mmsMortgagorPage.UpdateMMSMortgagor("Person", mortgagorStreetNumber, MortgagorAddress1, MortgagorCity, MortgagorProvince, MortgagorPostalCode, MMSNewDeal_Steps.mortgagorLastName, mortgagorFirstName);
            mortgagorFullName = mortgagorFirstName + " " + MMSNewDeal_Steps.mortgagorLastName;
        }

        [Then(@"I update business mortgagor information on MMS Portal")]
        public void ThenIUpdateBusinessMortgagorInformationOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Mortgagor");

            mmsMortgagorPage = UIHelper.PageInit<MMSMortgagorPage>(driver);
            mmsMortgagorPage.UpdateMMSMortgagor("Business", mortgagorStreetNumber, MortgagorAddress1, MortgagorCity, MortgagorProvince, MortgagorPostalCode, "", "", mortgagorBusiness);
            mortgagorFullName = mortgagorBusiness;
        }

        [Then(@"I add person mortgagor information on MMS Portal")]
        public void ThenIAddPersonMortgagorInformationOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Mortgagor");

            mmsMortgagorPage = UIHelper.PageInit<MMSMortgagorPage>(driver);
            mmsMortgagorPage.AddMMSMortgagor("Person", mortgagorStreetNumber, MortgagorAddress1, MortgagorCity, MortgagorProvince, MortgagorPostalCode, MMSNewDeal_Steps.mortgagorLastName, mortgagorFirstName);
            mortgagorFullName = mortgagorBusiness;
        }
    }
}
