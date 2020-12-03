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
    public sealed class MMSLender_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSViewDealPage mmsViewDealPage;
        public static MMSLenderPage mmsLenderPage;

        public MMSLender_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I assign MMS deal to broker")]
        public void ThenIAssignMMSDealToBroker()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Lender");

            mmsLenderPage = UIHelper.PageInit<MMSLenderPage>(driver);
            mmsLenderPage.SearchCRM(BrokerCRMFirstName, BrokerCRMLastName);
            mmsLenderPage.AddBroker(BrokerCRMFirstName, BrokerCRMEmail);
        }

        [Then(@"I assign MMS deal to broker delegate")]
        public void ThenIAssignMMSDealToBrokerDelegate()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Lender");

            mmsLenderPage = UIHelper.PageInit<MMSLenderPage>(driver);
            mmsLenderPage.SearchCRM(BrokerDelegateCRMFirstName, BrokerDelegateCRMLastName);
            mmsLenderPage.AddBroker(BrokerDelegateCRMFirstName, BrokerCRMEmail);
        }
    }
}
