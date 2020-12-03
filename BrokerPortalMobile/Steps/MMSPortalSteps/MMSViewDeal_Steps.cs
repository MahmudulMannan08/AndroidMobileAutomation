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
    public sealed class MMSViewDeal_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSHomePage mmsHomePage;
        public static MMSViewDealPage mmsViewDealPage;

        public MMSViewDeal_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I search and view MMS deal")]
        public void ThenISearchAndViewMMSDeal()
        {
            mmsHomePage = UIHelper.PageInit<MMSHomePage>(driver);
            mmsHomePage.MMSSwitchToTab("Edit/View Deals");

            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.SearchMMSDeal(MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search and view MMS deal for broker delegate")]
        public void ThenISearchAndViewMMSDealForBrokerDelegate()
        {
            mmsHomePage = UIHelper.PageInit<MMSHomePage>(driver);
            mmsHomePage.MMSSwitchToTab("Edit/View Deals");

            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.SearchMMSDeal(MMSNewDeal_Steps.mmsFctUrnDelegate);
        }

        [Then(@"I close MMS FCT portal")]
        public void ThenICloseMMSFCTPortal()
        {
            mmsViewDealPage.TerminateViewDeal();
            mmsViewDealPage.CloseMMSFCTPortal();
        }
    }
}
