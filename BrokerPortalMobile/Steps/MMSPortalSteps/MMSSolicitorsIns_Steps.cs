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
    public sealed class MMSSolicitorsIns_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSViewDealPage mmsViewDealPage;
        public static MMSSolicitorsInsPage mmsSolicitorsInsPage;

        public static string brConditionsSatDate = null;

        public MMSSolicitorsIns_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I check Broker Conditions Satisfied milestone on MMS Portal")]
        public void ThenICheckBrokerConditionsSatisfiedMilestoneOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Solicitors Instructions");

            mmsSolicitorsInsPage = UIHelper.PageInit<MMSSolicitorsInsPage>(driver);
            mmsSolicitorsInsPage.ChkUnchBrokerConditions("ON");
        }

        [Then(@"I uncheck Broker Conditions Satisfied milestone on MMS Portal")]
        public void ThenIUncheckBrokerConditionsSatisfiedMilestoneOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Solicitors Instructions");

            mmsSolicitorsInsPage = UIHelper.PageInit<MMSSolicitorsInsPage>(driver);
            mmsSolicitorsInsPage.ChkUnchBrokerConditions("OFF");
        }

        [Then(@"I verify Broker Conditions Satisfied completed date is populated on MMS Portal")]
        public void ThenIVerifyBrokerConditionsSatisfiedCompletedDateIsPopulatedOnMMSPortal()
        {
            brConditionsSatDate = mmsSolicitorsInsPage.VerifyBrokerConditionsDate(true);
        }

        [Then(@"I verify Broker Conditions Satisfied completed date is removed on MMS Portal")]
        public void ThenIVerifyBrokerConditionsSatisfiedCompletedDateIsRemovedOnMMSPortal()
        {
            brConditionsSatDate = mmsSolicitorsInsPage.VerifyBrokerConditionsDate(false);
        }
    }
}
