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
    public sealed class MMSProperty_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSViewDealPage mmsViewDealPage;
        public static MMSPropertyPage mmsPropertyPage;

        public static string PropertyStreetNumber = GenerateNumber(4);

        public MMSProperty_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I add property address on MMS Portal")]
        public void ThenIAddPropertyAddressOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Property");

            mmsPropertyPage = UIHelper.PageInit<MMSPropertyPage>(driver);
            mmsPropertyPage.AddMMSProperty(PropertyStreetNumber, PropertyAddress1, PropertyCity, PropertyProvince, PropertyPostalCode);
        }
    }
}
