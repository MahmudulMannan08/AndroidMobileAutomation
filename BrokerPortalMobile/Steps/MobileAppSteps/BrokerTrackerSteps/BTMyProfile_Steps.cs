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
    public sealed class BTMyProfile_Steps : TestBase
    {
        private readonly ScenarioContext _scenarioContext;
        public static BTProfilePage btProfilePage;
        public static BTDelegateAuthPage btDelegateAuthPage;

        public BTMyProfile_Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Then(@"I select Delegated Authority menu on Broker Tracker")]
        public void ThenISelectDelegatedAuthorityMenuOnBrokerTracker()
        {
            btProfilePage = UIHelperAndroid.PageInit<BTProfilePage>(androidDriver);
            btProfilePage.SelectProfileMenu("Delegated Authority");
        }

        [Then(@"I select Contact Information menu on Broker Tracker")]
        public void ThenISelectContactInformationMenuOnBrokerTracker()
        {
            btProfilePage = UIHelperAndroid.PageInit<BTProfilePage>(androidDriver);
            btProfilePage.SelectProfileMenu("Contact Information");
        }

        [Then(@"I add a broker delegate on Broker Tracker")]
        public void ThenIAddABrokerDelegateOnBrokerTracker()
        {
            btDelegateAuthPage = UIHelperAndroid.PageInit<BTDelegateAuthPage>(androidDriver);
            btDelegateAuthPage.AddDelegate(BrokerToDelegateUsername);
        }

        [Then(@"I enable broker delegate on Broker Tracker")]
        public void ThenIEnableBrokerDelegateOnBrokerTracker()
        {
            btDelegateAuthPage.EnableDisableDeleteDelegate("ENABLE");
        }

        [Then(@"I delete broker delegate on Broker Tracker")]
        public void ThenIDeleteBrokerDelegateOnBrokerTracker()
        {
            btDelegateAuthPage.EnableDisableDeleteDelegate("DELETE");
        }

        [Then(@"I update Contact Information on My Profile on Broker Tracker")]
        public void ThenIUpdateContactInformationOnMyProfileOnBrokerTracker()
        {
            
        }
    }
}
