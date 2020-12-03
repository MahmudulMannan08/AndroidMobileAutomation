using BrokerPortalMobile.Pages.MobileAppPages.BrokerTrackerPages;
using BrokerPortalMobile.Steps.MMSPortalSteps;
using BrokerPortalMobile.Steps.MotionSteps;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile.Steps.MobileAppSteps.BrokerTrackerSteps
{
    [Binding]
    public sealed class BTHomePage_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static BTHomePage btHomePage;

        public BTHomePage_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I select Solicitor closed deals tab on Broker Tracker")]
        public void ThenISelectSolicitorClosedDealsTabOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SelectDealsTab("Solicitor closed deals");
        }

        [Then(@"I select FCT closed deals tab on Broker Tracker")]
        public void ThenISelectFCTClosedDealsTabOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SelectDealsTab("FCT closed deals");
        }

        [Then(@"Motion - I select FCT closed deals tab on Broker Tracker")]
        public void ThenMotion_ISelectFCTClosedDealsTabOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SelectDealsTabMotion("FCT closed deals");
        }

        [Then(@"I get Action Required bucket count on Broker Tracker")]
        public void ThenIGetActionRequiredBucketCountOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.GetBucketCount("Action required");
        }

        [Then(@"Motion - I get Action Required bucket count on Broker Tracker")]
        public void ThenMotion_IGetActionRequiredBucketCountOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.GetBucketCountMotion("Action required");
        }

        [Then(@"I get In Process bucket count on Broker Tracker")]
        public void ThenIGetInProcessBucketCountOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.GetBucketCount("In process");
        }

        [Then(@"Motion - I get In Process bucket count on Broker Tracker")]
        public void ThenMotion_IGetInProcessBucketCountOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.GetBucketCountMotion("In process");
        }

        [Then(@"Motion - I get Funded bucket count on Broker Tracker")]
        public void ThenMotion_IGetFundedBucketCountOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.GetBucketCountMotion("Funded");
        }

        [Then(@"I search MMS deal on Broker Tracker")]
        public void ThenISearchMMSDealOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SearchDeal("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search Motion deal on Broker Tracker")]
        public void ThenISearchMotionDealOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SearchDealMotion("FCT Reference No.", MotionHome_Steps.fctUrnMotion);
        }

        [Then(@"I search MMS deal for delegated broker on Broker Tracker")]
        public void ThenISearchMMSDealForDelegatedBrokerOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SearchDeal("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search Motion deal without broker alert on Broker Tracker")]
        public void ThenISearchMotionDealWithoutBrokerAlertOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SearchDealWithoutAlertMotion("FCT Reference No.", MotionHome_Steps.fctUrnMotion);
        }

        [Then(@"I search cancelled Motion deal on Broker Tracker")]
        public void ThenISearchCancelledMotionDealOnBrokerTracker()
        {
            btHomePage.SearchNotFoundDealMotion("FCT Reference No.", MotionHome_Steps.fctUrnMotion);
        }

        [Then(@"I search MMS deal without broker alert on Broker Tracker")]
        public void ThenISearchMMSDealWithoutBrokerAlertOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SearchDealWithoutAlert("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search cancelled MMS deal on Broker Tracker")]
        public void ThenISearchCancelledMMSDealOnBrokerTracker()
        {
            btHomePage.SearchNotFoundDeal("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search MMS deal for disabled delegate on Broker Tracker")]
        public void ThenISearchMMSDealForDisabledDelegateOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SearchNotFoundDeal("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I cancel search on Broker Tracker")]
        public void ThenICancelSearchOnBrokerTracker()
        {
            btHomePage.CancelSearch();
        }

        [Then(@"Motion - I cancel search on Broker Tracker")]
        public void ThenMotion_ICancelSearchOnBrokerTracker()
        {
            btHomePage.CancelSearchMotion();
        }

        [Then(@"I verify alert icon on deal list page on Broker Tracker")]
        public void ThenIVerifyAlertIconOnDealListPageOnBrokerTracker()
        {
            btHomePage.VerifyAlertIcon(true);
        }

        [Then(@"Motion - I verify alert icon on deal list page on Broker Tracker")]
        public void ThenMotion_IVerifyAlertIconOnDealListPageOnBrokerTracker()
        {
            btHomePage.VerifyAlertIconMotion(true);
        }

        [Then(@"Motion - I verify alert icon on deal list page unavailable on Broker Tracker")]
        public void ThenMotion_IVerifyAlertIconOnDealListPageUnavailableOnBrokerTracker()
        {
            btHomePage.VerifyAlertIconMotion(false);
        }

        [Then(@"I verify alert icon on deal list page unavailable on Broker Tracker")]
        public void ThenIVerifyAlertIconOnDealListPageUnavailableOnBrokerTracker()
        {
            btHomePage.VerifyAlertIcon(false);
        }

        [Then(@"I go to MMS deal details page on Broker Tracker")]
        public void ThenIGoToMMSDealDetailsPageOnBrokerTracker()
        {
            btHomePage.AccessDealDetails(MMSMortgagor_Steps.mortgagorFullName);
        }

        [Then(@"I go to Motion deal details page on Broker Tracker")]
        public void ThenIGoToMotionDealDetailsPageOnBrokerTracker()
        {
            btHomePage.AccessDealDetailsMotion(MotionMortgagor_Steps.mortgagorFullName);
        }

        [Then(@"I refresh android app")]
        public void ThenIRefreshAndroidApp()
        {
            UIHelperAndroidApp.RefreshAndroidApp();
        }

        [Then(@"I verify Action Required bucket count on Broker Tracker")]
        public void ThenIVerifyActionRequiredBucketCountOnBrokerTracker()
        {
            btHomePage.VerifyBucketCount("Action required");
        }

        [Then(@"I verify In Process bucket count on Broker Tracker")]
        public void ThenIVerifyInProcessBucketCountOnBrokerTracker()
        {
            btHomePage.VerifyBucketCount("In process");
        }

        [Then(@"Motion - I verify Action Required bucket count on Broker Tracker")]
        public void ThenMotion_IVerifyActionRequiredBucketCountOnBrokerTracker()
        {
            btHomePage.VerifyBucketCountMotion("Action required");
        }

        [Then(@"I verify Action Required bucket count decreased on Broker Tracker")]
        public void ThenIVerifyActionRequiredBucketCountDecreasedOnBrokerTracker()
        {
            btHomePage.VerifyBucketCountDecreased("Action required");
        }

        [Then(@"Motion - I verify Action Required bucket count decreased on Broker Tracker")]
        public void ThenMotion_IVerifyActionRequiredBucketCountDecreasedOnBrokerTracker()
        {
            btHomePage.VerifyBucketCountDecreasedMotion("Action required");
        }

        [Then(@"Motion - I verify In Process bucket count decreased on Broker Tracker")]
        public void ThenMotion_IVerifyInProcessBucketCountDecreasedOnBrokerTracker()
        {
            btHomePage.VerifyBucketCountDecreasedMotion("In process");
        }

        [Then(@"Motion - I verify Funded bucket count decreased on Broker Tracker")]
        public void ThenMotion_IVerifyFundedBucketCountDecreasedOnBrokerTracker()
        {
            btHomePage.VerifyBucketCountDecreasedMotion("Funded");
        }

        [Then(@"I verify In Process bucket count decreased on Broker Tracker")]
        public void ThenIVerifyInProcessBucketCountDecreasedOnBrokerTracker()
        {
            btHomePage.VerifyBucketCountDecreased("In process");
        }

        [Then(@"I verify Action Required bucket count increased on Broker Tracker")]
        public void ThenIVerifyActionRequiredBucketCountIncreasedOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBucketCountIncreased("Action required", 1);
        }

        [Then(@"Motion - I verify Action Required bucket count increased on Broker Tracker")]
        public void ThenMotion_IVerifyActionRequiredBucketCountIncreasedOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBucketCountIncreasedMotion("Action required", 1);
        }

        [Then(@"I verify In Process bucket count increased on Broker Tracker")]
        public void ThenIVerifyInProcessBucketCountIncreasedOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBucketCountIncreased("In process", 1);
        }

        [Then(@"Motion - I verify In Process bucket count increased on Broker Tracker")]
        public void ThenMotion_IVerifyInProcessBucketCountIncreasedOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBucketCountIncreasedMotion("In process", 1);
        }

        [Then(@"Motion - I verify Funded bucket count increased on Broker Tracker")]
        public void ThenMotion_IVerifyFundedBucketCountIncreasedOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBucketCountIncreasedMotion("Funded", 1);
        }

        [Then(@"I verify Action Required bucket count for multiple alerts on Broker Tracker")]
        public void ThenIVerifyActionRequiredBucketCountForMultipleAlertsOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBucketCountIncreased("Action required", 2);
        }

        [Then(@"Motion - I verify Action Required bucket count for multiple alerts on Broker Tracker")]
        public void ThenMotion_IVerifyActionRequiredBucketCountForMultipleAlertsOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBucketCountIncreasedMotion("Action required", 2);
        }

        [Then(@"I select Action Required bucket on Broker Tracker")]
        public void ThenISelectActionRequiredBucketOnBrokerTracker()
        {
            btHomePage.SelectBucketTab("Action required");
        }

        [Then(@"I select In Process bucket on Broker Tracker")]
        public void ThenISelectInProcessBucketOnBrokerTracker()
        {
            btHomePage.SelectBucketTab("In process");
        }

        [Then(@"I verify broker filter available on Broker Tracker")]
        public void ThenIVerifyBrokerFilterAvailableOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBrokerFilterAvailability(true);
        }

        [Then(@"I verify broker filter unavailable on Broker Tracker")]
        public void ThenIVerifyBrokerFilterUnavailableOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyBrokerFilterAvailability(false);
        }

        [Then(@"I verify broker filter on Broker Tracker")]
        public void ThenIVerifyBrokerFilterOnBrokerTracker()
        {
            btHomePage.VerifyBrokerFilter(BrokerName, BrokerDelegateName);
        }

        [Then(@"I select All Brokers on broker filter on Broker Tracker App")]
        public void ThenISelectAllBrokersOnBrokerFilterOnBrokerTrackerApp()
        {
            btHomePage.SelectBrokerFilter("All Brokers");
        }

        [Then(@"I select Non-Delegate broker on broker filter on Broker Tracker App")]
        public void ThenISelectNon_DelegateBrokerOnBrokerFilterOnBrokerTrackerApp()
        {
            btHomePage.SelectBrokerFilter(BrokerName);
        }

        [Then(@"I select Delegate broker on broker filter on Broker Tracker App")]
        public void ThenISelectDelegateBrokerOnBrokerFilterOnBrokerTrackerApp()
        {
            btHomePage.SelectBrokerFilter(BrokerDelegateName);
        }

        [Then(@"I verify the deal list view for All Brokers on Broker Tracker")]
        public void ThenIVerifyTheDealListViewForAllBrokersOnBrokerTracker()
        {
            btHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrn, true);
            btHomePage.CancelSearch();
            btHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrnDelegate, true);
        }

        [Then(@"I verify the deal list view for Non-Delegate broker on Broker Tracker")]
        public void ThenIVerifyTheDealListViewForNon_DelegateBrokerOnBrokerTracker()
        {
            btHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrn, true);
            btHomePage.CancelSearch();
            btHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrnDelegate, false);
        }

        [Then(@"I verify the deal list view for Delegate broker on Broker Tracker")]
        public void ThenIVerifyTheDealListViewForDelegateBrokerOnBrokerTracker()
        {
            btHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrn, false);
            btHomePage.CancelSearch();
            btHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrnDelegate, true);
        }

        [Then(@"I verify My Profile menu on Broker Tracker")]
        public void ThenIVerifyMyProfileMenuOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyMyProfileMenu();
            UIHelperAndroidApp.GoBackAndroid();
        }

        [Then(@"I go to My Profile on Broker Tracker")]
        public void ThenIGoToMyProfileOnBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.GotoMyProfile();
        }

        [Then(@"I verify successful login to Broker Tracker")]
        public void ThenIVerifySuccessfulLoginToBrokerTracker()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.VerifyLogin(true);
        }
    }
}
