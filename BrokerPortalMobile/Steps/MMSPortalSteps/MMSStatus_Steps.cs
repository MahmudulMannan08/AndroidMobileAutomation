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
    public sealed class MMSStatus_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSViewDealPage mmsViewDealPage;
        public static MMSStatusPage mmsStatusPage;

        public static string rfiReceivedDate = null;
        public static string solicitorsInsSentDate = null;

        public MMSStatus_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I verify RFI received date is populated on MMS Portal")]
        public void ThenIVerifyRFIReceivedDateIsPopulatedOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Status");

            mmsStatusPage = UIHelper.PageInit<MMSStatusPage>(driver);
            rfiReceivedDate = mmsStatusPage.VerifyRFIReceivedDate();
        }

        [Then(@"I verify Solicitors instruction sent date is populated on MMS Portal")]
        public void ThenIVerifySolicitorsInstructionSentDateIsPopulatedOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Status");

            mmsStatusPage = UIHelper.PageInit<MMSStatusPage>(driver);
            solicitorsInsSentDate = mmsStatusPage.VerifySolicitorsInsSentDate();
        }

        [Then(@"I hold MMS deal on MMS Portal")]
        public void ThenIHoldMMSDealOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Status");

            mmsStatusPage = UIHelper.PageInit<MMSStatusPage>(driver);
            mmsStatusPage.HoldUnholdDeal(true);
        }

        [Then(@"I unhold MMS deal on MMS Portal")]
        public void ThenIUnholdMMSDealOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Status");

            mmsStatusPage = UIHelper.PageInit<MMSStatusPage>(driver);
            mmsStatusPage.HoldUnholdDeal(false);
        }

        [Then(@"I issue COI for MMS deal on MMS Portal")]
        public void ThenIIssueCOIForMMSDealOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Status");

            mmsStatusPage = UIHelper.PageInit<MMSStatusPage>(driver);
            mmsStatusPage.IssueCOI();
        }

        [Then(@"I cancel MMS deal on MMS Portal")]
        public void ThenICancelMMSDealOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Status");

            mmsStatusPage = UIHelper.PageInit<MMSStatusPage>(driver);
            mmsStatusPage.CancelUncancelDeal(true);
        }
    }
}
