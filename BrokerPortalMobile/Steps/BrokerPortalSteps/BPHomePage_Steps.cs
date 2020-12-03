using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using BrokerPortalMobile.Pages;
using BrokerPortalMobile.Steps.MMSPortalSteps;
using BrokerPortalMobile.Steps.MotionSteps;

namespace BrokerPortalMobile.Steps.BrokerPortalSteps
{
    [Binding]
    public sealed class BPHomePage_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static BPHomePage bpHomePage;
        //public static MMSPortalSteps

        public BPHomePage_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I search MMS deal on broker portal")]
        public void ThenISearchMMSDealOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDeal("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search MMS deal for delegated broker on broker portal")]
        public void ThenISearchMMSDealForDelegatedBrokerOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDealDelegate("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search Motion deal on broker portal")]
        public void ThenISearchMotionDealOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDeal("FCT Reference No.", MotionHome_Steps.fctUrnMotion);
        }

        [Then(@"I search cancelled MMS deal on broker portal")]
        public void ThenISearchCancelledMMSDealOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchNotFoundDeal("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search MMS deal for disabled delegate on broker portal")]
        public void ThenISearchMMSDealForDisabledDelegateOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchNotFoundDeal("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search cancelled Motion deal on broker portal")]
        public void ThenISearchCancelledMotionDealOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchNotFoundDeal("FCT Reference No.", MotionHome_Steps.fctUrnMotion);
        }

        [Then(@"I search MMS deal without broker alert on broker portal")]
        public void ThenISearchMMSDealWithoutBrokerAlertOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDealWithoutAlert("FCT Reference No.", MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I search Motion deal without broker alert on broker portal")]
        public void ThenISearchMotionDealWithoutBrokerAlertOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDealWithoutAlert("FCT Reference No.", MotionHome_Steps.fctUrnMotion);
        }

        [Then(@"I get Action Required bucket count")]
        public void ThenIGetActionRequiredBucketCount()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.GetBucketCount("Action required");
        }

        [Then(@"I verify Action Required bucket count")]
        public void ThenIVerifyActionRequiredBucketCount()
        {
            bpHomePage.VerifyBucketCount("Action required");
        }

        [Then(@"I verify Action Required bucket count for multiple alerts")]
        public void ThenIVerifyActionRequiredBucketCountForMultipleAlerts()
        {
            bpHomePage.VerifyBucketCountMultiAlert("Action required");
        }

        [Then(@"I verify Action Required bucket count decreased")]
        public void ThenIVerifyActionRequiredBucketCountDecreased()
        {
            bpHomePage.VerifyBucketCountDecreased("Action required");
        }

        [Then(@"I verify alert icon on deal list page")]
        public void ThenIVerifyAlertIconOnDealListPage()
        {
            bpHomePage.VerifyAlertIcon(true);
        }

        [Then(@"I verify alert icon on deal list page unavailable")]
        public void ThenIVerifyAlertIconOnDealListPageUnavailable()
        {
            bpHomePage.VerifyAlertIcon(false);
        }

        [Then(@"I go to MMS deal details page on broker portal")]
        public void ThenIGoToMMSDealDetailsPageOnBrokerPortal()
        {
            bpHomePage.AccessDealDetails(MMSNewDeal_Steps.mmsFctUrn);
        }

        [Then(@"I go to Motion deal details page on broker portal")]
        public void ThenIGoToMotionDealDetailsPageOnBrokerPortal()
        {
            bpHomePage.AccessDealDetails(MotionHome_Steps.fctUrnMotion);
        }

        [Then(@"I go to Broker Portal homepage")]
        public void ThenIGoToBrokerPortalHomepage()
        {
            bpHomePage.GotoHomepage();
        }

        [Then(@"I navigate back on android")]
        public void ThenINavigateBackOnAndroid()
        {
            UIHelperAndroidApp.GoBackAndroid();
        }

        [Then(@"Motion - I navigate back on android")]
        public void ThenMotion_INavigateBackOnAndroid()
        {
            UIHelperAndroidApp.GoBackAndroid();
        }

        [Then(@"I verify My Profile menu on broker portal")]
        public void ThenIVerifyMyProfileMenuOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.VerifyMyProfileMenu();
        }

        [Then(@"I go to My Profile on broker portal")]
        public void ThenIGoToMyProfileOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.GotoMyProfile();
        }

        [Then(@"I verify broker filter available on broker portal")]
        public void ThenIVerifyBrokerFilterAvailableOnBrokerPortal()
        {
            bpHomePage.VerifyBrokerFilterAvailability(true);
        }

        [Then(@"I verify broker filter unavailable on broker portal")]
        public void ThenIVerifyBrokerFilterUnavailableOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.VerifyBrokerFilterAvailability(false);
        }

        [Then(@"I verify broker filter on broker portal")]
        public void ThenIVerifyBrokerFilterOnBrokerPortal()
        {
            bpHomePage.VerifyBrokerFilter(BrokerName, BrokerDelegateName);
        }

        [Then(@"I select All Brokers on broker filter")]
        public void ThenISelectAllBrokersOnBrokerFilter()
        {
            bpHomePage.SelectBrokerFilter("All Brokers");
        }

        [Then(@"I select Non-Delegate broker on broker filter")]
        public void ThenISelectNon_DelegateBrokerOnBrokerFilter()
        {
            bpHomePage.SelectBrokerFilter(BrokerName);
        }

        [Then(@"I select Delegate broker on broker filter")]
        public void ThenISelectDelegateBrokerOnBrokerFilter()
        {
            bpHomePage.SelectBrokerFilter(BrokerDelegateName);
        }

        [Then(@"I verify the deal list view for All Brokers on broker portal")]
        public void ThenIVerifyTheDealListViewForAllBrokersOnBrokerPortal()
        {
            bpHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrn, true);
            bpHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrnDelegate, true);
        }

        [Then(@"I verify the deal list view for Non-Delegate broker on broker portal")]
        public void ThenIVerifyTheDealListViewForNon_DelegateBrokerOnBrokerPortal()
        {
            bpHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrn, true);
            bpHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrnDelegate, false);
        }

        [Then(@"I verify the deal list view for Delegate broker on broker portal")]
        public void ThenIVerifyTheDealListViewForDelegateBrokerOnBrokerPortal()
        {
            bpHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrn, false);
            bpHomePage.VerifyDealAvailableDelegate(MMSNewDeal_Steps.mmsFctUrnDelegate, true);
        }

        [Then(@"I verify successful login to broker portal")]
        public void ThenIVerifySuccessfulLoginToBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.VerifyLogin(true);
        }

        [Then(@"I verify Search By dropdown on broker portal")]
        public void ThenIVerifySearchByDropdownOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.VerifySearchByDropdown();
        }

        [Then(@"I verify invalid search on broker portal")]
        public void ThenIVerifyInvalidSearchOnBrokerPortal()
        {
            bpHomePage.VerifyInvalidSearch("a", "Invalid format. Please enter a minimum of two characters to search for a deal.");
        }

        [Then(@"I verify mismatch search on broker portal")]
        public void ThenIVerifyMismatchSearchOnBrokerPortal()
        {
            bpHomePage.VerifyInvalidSearch("zxzxzx", "No results were found matching your search criteria.");
        }

        [Then(@"I search deal by person mortgagor last name on broker portal")]
        public void ThenISearchDealByPersonMortgagorLastNameOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDeal("Mortgagor Last Name", MMSNewDeal_Steps.mortgagorLastName);
            bpHomePage.VerifyAlertIcon(true);
        }

        [Then(@"I search deal by business mortgagor name on broker portal")]
        public void ThenISearchDealByBusinessMortgagorNameOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDeal("Mortgagor Last Name", MMSMortgagor_Steps.mortgagorBusiness);
            bpHomePage.VerifyAlertIcon(true);
        }

        [Then(@"I search deal by city on broker portal")]
        public void ThenISearchDealByCityOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDealMultiple("City", PropertyCity.ToLower());
        }

        [Then(@"I verify contains search on broker portal")]
        public void ThenIVerifyContainsSearchOnBrokerPortal()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SearchDealMultiple("City", "%oron%");
        }
    }
}
