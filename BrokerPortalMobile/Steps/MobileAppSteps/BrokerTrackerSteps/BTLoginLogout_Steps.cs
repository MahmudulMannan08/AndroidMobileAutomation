using BrokerPortalMobile.Pages.MobileAppPages.BrokerTrackerPages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile.Steps.MobileAppSteps.BrokerTrackerSteps
{
    [Binding]
    public sealed class BTLoginLogout_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static BTLoginPage btLoginPage;
        public static BTHomePage btHomePage;

        public BTLoginLogout_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I launch Broker Tracker App on Android Emulator")]
        public void GivenILaunchBrokerTrackerAppOnAndroidEmulator()
        {
            InitializeMobileAppDriver(ConfigurationManager.AppSettings["platformName"]);
        }

        [Then(@"I login to Broker Tracker App on Android Emulator")]
        public void ThenILoginToBrokerTrackerAppOnAndroidEmulator()
        {
            btLoginPage = UIHelperAndroid.PageInit<BTLoginPage>(androidDriver);
            btLoginPage.LoginToBrokerTracker(BrokerUsername, BrokerPassword);
        }

        [Then(@"I login to Broker Tracker App with delegated broker on Android Emulator")]
        public void ThenILoginToBrokerTrackerAppWithDelegatedBrokerOnAndroidEmulator()
        {
            btLoginPage = UIHelperAndroid.PageInit<BTLoginPage>(androidDriver);
            btLoginPage.LoginToBrokerTracker(BrokerToDelegateUsername, BrokerToDelegatePassword);
        }

        [Then(@"I login to Broker Tracker with non-broker user on Android Emulator")]
        public void ThenILoginToBrokerTrackerWithNon_BrokerUserOnAndroidEmulator()
        {
            btLoginPage = UIHelperAndroid.PageInit<BTLoginPage>(androidDriver);
            btLoginPage.UnauthorizedLoginToBT("adeveloper2", "Itmagnet-03");
        }

        [Then(@"I login to Broker Tracker with inactive broker user on Android Emulator")]
        public void ThenILoginToBrokerTrackerWithInactiveBrokerUserOnAndroidEmulator()
        {
            btLoginPage = UIHelperAndroid.PageInit<BTLoginPage>(androidDriver);
            btLoginPage.UnauthorizedLoginToBT(InactiveBrokerUsername, InactiveBrokerPassword);
        }

        [Then(@"I login to Broker Tracker with declined broker user on Android Emulator")]
        public void ThenILoginToBrokerTrackerWithDeclinedBrokerUserOnAndroidEmulator()
        {
            btLoginPage = UIHelperAndroid.PageInit<BTLoginPage>(androidDriver);
            btLoginPage.UnauthorizedLoginToBT(DeclinedBrokerUsername, DeclinedBrokerPassword);
        }

        [Then(@"I login to Broker Tracker with locked broker user on Android Emulator")]
        public void ThenILoginToBrokerTrackerWithLockedBrokerUserOnAndroidEmulator()
        {
            btLoginPage = UIHelperAndroid.PageInit<BTLoginPage>(androidDriver);
            btLoginPage.UnauthorizedLoginToBT(LockedBrokerUsername, LockedBrokerPassword);
        }

        [Then(@"Motion - I login to Broker Tracker App on Android Emulator")]
        public void ThenMotion_ILoginToBrokerTrackerAppOnAndroidEmulator()
        {
            btLoginPage = UIHelperAndroid.PageInit<BTLoginPage>(androidDriver);
            btLoginPage.LoginToBrokerTrackerMotion(BrokerUsername, BrokerPassword);
        }

        [Then(@"I login to Broker Tracker App with broker admin on Android Emulator")]
        public void ThenILoginToBrokerTrackerAppWithBrokerAdminOnAndroidEmulator()
        {
            btLoginPage = UIHelperAndroid.PageInit<BTLoginPage>(androidDriver);
            btLoginPage.LoginToBrokerTracker(BrokerAdminUsername, BrokerAdminPassword);
        }

        [Then(@"I logout from Broker Tracker on Android Emulator Browser")]
        public void ThenILogoutFromBrokerTrackerOnAndroidEmulatorBrowser()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SignoutFromBrokerTracker();
            btLoginPage.VerifySignoutSuccess();
        }

        [Then(@"Motion - I logout from Broker Tracker on Android Emulator Browser")]
        public void ThenMotion_ILogoutFromBrokerTrackerOnAndroidEmulatorBrowser()
        {
            btHomePage = UIHelperAndroid.PageInit<BTHomePage>(androidDriver);
            btHomePage.SignoutFromBrokerTrackerMotion();
            btLoginPage.VerifySignoutSuccess();
        }

        [Then(@"I verify user unauthorized to log in on Broker Tracker")]
        public void ThenIVerifyUserUnauthorizedToLogInOnBrokerTracker()
        {
            btLoginPage.VerifyFailedLogin("Please click on Enroll Now to register for Broker Tracker.");
        }

        [Then(@"I verify locked user log in on Broker Tracker")]
        public void ThenIVerifyLockedUserLogInOnBrokerTracker()
        {
            btLoginPage.VerifyFailedLogin("Your request cannot be completed. For help, please email us at ladsupport@fct.ca or call us at 905.287.3113 or toll free at 877.804.3113.");
        }
    }
}
