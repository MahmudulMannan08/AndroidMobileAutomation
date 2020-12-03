using BrokerPortalMobile.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile.Steps
{
    [Binding]
    public sealed class BPLoginLogout_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static BPLoginPage bpLoginPage;
        public static BPHomePage bpHomePage;

        public BPLoginLogout_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I go to Broker Portal on Android Emulator Browser")]
        public void GivenIGoToBrokerPortalOnAndroidEmulatorBrowser()
        {
            InitializeMobileDriver(ConfigurationManager.AppSettings["platformName"]);
            UIHelperAndroid.GoTo<BPLoginPage>(BrokerPortal);
        }

        [Then(@"I login to Broker Portal on Android Emulator Browser")]
        public void ThenILoginToBrokerPortalOnAndroidEmulatorBrowser()
        {
            bpLoginPage = UIHelperAndroid.PageInit<BPLoginPage>(androidDriver);
            bpLoginPage.LoginToBrokerPortal(BrokerUsername, BrokerPassword);
        }

        [Then(@"I login to Broker Portal with delegated broker on Android Emulator Browser")]
        public void ThenILoginToBrokerPortalWithDelegatedBrokerOnAndroidEmulatorBrowser()
        {
            bpLoginPage = UIHelperAndroid.PageInit<BPLoginPage>(androidDriver);
            bpLoginPage.LoginToBrokerPortal(BrokerToDelegateUsername, BrokerToDelegatePassword);
        }

        [Then(@"I login to Broker Portal with broker admin on Android Emulator Browser")]
        public void ThenILoginToBrokerPortalWithBrokerAdminOnAndroidEmulatorBrowser()
        {
            bpLoginPage = UIHelperAndroid.PageInit<BPLoginPage>(androidDriver);
            bpLoginPage.LoginToBrokerPortal(BrokerAdminUsername, BrokerAdminPassword);
        }

        [Then(@"I select Solicitor closed deals tab")]
        public void ThenISelectSolicitorClosedDealsTab()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SelectDealsTab("Solicitor closed deals");
        }

        [Then(@"I select FCT closed deals tab")]
        public void ThenISelectFCTClosedDealsTab()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SelectDealsTab("FCT closed deals");
        }

        [Then(@"I select Action Required bucket on broker portal")]
        public void ThenISelectActionRequiredBucketOnBrokerPortal()
        {
            bpHomePage.SelectBucketTab("Action required");
        }

        [Then(@"I select In Process bucket on broker portal")]
        public void ThenISelectInProcessBucketOnBrokerPortal()
        {
            bpHomePage.SelectBucketTab("In process");
        }

        [Then(@"I select Funded bucket on broker portal")]
        public void ThenISelectFundedBucketOnBrokerPortal()
        {
            bpHomePage.SelectBucketTab("Funded");
        }

        [Then(@"I logout from Broker Portal on Android Emulator Browser")]
        public void ThenILogoutFromBrokerPortalOnAndroidEmulatorBrowser()
        {
            bpHomePage = UIHelperAndroid.PageInit<BPHomePage>(androidDriver);
            bpHomePage.SignoutFromBrokerPortal();
            bpLoginPage.VerifySignoutSuccess();
        }

        [Then(@"I login to Broker Portal with non-broker user on Android Emulator Browser")]
        public void ThenILoginToBrokerPortalWithNon_BrokerUserOnAndroidEmulatorBrowser()
        {
            bpLoginPage = UIHelperAndroid.PageInit<BPLoginPage>(androidDriver);
            bpLoginPage.LoginToBrokerPortal("adeveloper2", "Itmagnet-03");
        }

        [Then(@"I login to Broker Portal with inactive broker user on Android Emulator Browser")]
        public void ThenILoginToBrokerPortalWithInactiveBrokerUserOnAndroidEmulatorBrowser()
        {
            bpLoginPage = UIHelperAndroid.PageInit<BPLoginPage>(androidDriver);
            bpLoginPage.LoginToBrokerPortal(InactiveBrokerUsername, InactiveBrokerPassword);
        }

        [Then(@"I login to Broker Portal with declined broker user on Android Emulator Browser")]
        public void ThenILoginToBrokerPortalWithDeclinedBrokerUserOnAndroidEmulatorBrowser()
        {
            bpLoginPage = UIHelperAndroid.PageInit<BPLoginPage>(androidDriver);
            bpLoginPage.LoginToBrokerPortal(DeclinedBrokerUsername, DeclinedBrokerPassword);
        }

        [Then(@"I login to Broker Portal with locked broker user on Android Emulator Browser")]
        public void ThenILoginToBrokerPortalWithLockedBrokerUserOnAndroidEmulatorBrowser()
        {
            bpLoginPage = UIHelperAndroid.PageInit<BPLoginPage>(androidDriver);
            bpLoginPage.LoginToBrokerPortal(LockedBrokerUsername, LockedBrokerPassword);
        }

        [Then(@"I verify user unauthorized to log in on broker portal")]
        public void ThenIVerifyUserUnauthorizedToLogInOnBrokerPortal()
        {
            bpLoginPage.VerifyFailedLogin("Please click on Enroll Now to register for Broker Tracker.");
        }

        [Then(@"I verify locked user log in on broker portal")]
        public void ThenIVerifyLockedUserLogInOnBrokerPortal()
        {
            //bpLoginPage.VerifyFailedLogin("Your request cannot be completed. For help, please email us at ladsupport@fct.ca or call us at 905.287.3133 or toll free at 877.804.3133.");
            bpLoginPage.VerifyFailedLogin("Your request cannot be completed. For help, please email us at ladsupport@fct.ca or call us at 905.287.3113 or toll free at 877.804.3113.");
        }
    }
}
