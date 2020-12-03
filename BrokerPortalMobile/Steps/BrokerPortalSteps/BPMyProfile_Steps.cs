using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using BrokerPortalMobile.Pages;
using BrokerPortalMobile.Steps.MMSPortalSteps;
using BrokerPortalMobile.Steps.MotionSteps;
using BrokerPortalMobile.Pages.BrokerPortalPages;

namespace BrokerPortalMobile.Steps.BrokerPortalSteps
{
    [Binding]
    public sealed class BPMyProfile_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static BPHomePage bpHomePage;
        public static BPProfilePage bpProfilePage;
        public static BPDelegateAuthPage bpDelegateAuthPage;
        public static BPContactInfoPage bpContactInfoPage;

        public static string unitNo = GenerateNumber(5);
        public static string streetNo = GenerateNumber(3);

        public BPMyProfile_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I sign out from My Profile page on broker portal")]
        public void ThenISignOutFromMyProfilePageOnBrokerPortal()
        {
            bpProfilePage.SignOut();
            bpProfilePage.VerifySignoutSuccess();
        }

        [Then(@"I select Contact Information menu on broker portal")]
        public void ThenISelectContactInformationMenuOnBrokerPortal()
        {
            bpProfilePage = UIHelperAndroid.PageInit<BPProfilePage>(androidDriver);
            bpProfilePage.SelectProfileMenu("Contact Information");
        }

        [Then(@"I select Delegated Authority menu on broker portal")]
        public void ThenISelectDelegatedAuthorityMenuOnBrokerPortal()
        {
            bpProfilePage = UIHelperAndroid.PageInit<BPProfilePage>(androidDriver);
            bpProfilePage.SelectProfileMenu("Delegated Authority");
        }

        [Then(@"I add a broker delegate on broker portal")]
        public void ThenIAddABrokerDelegateOnBrokerPortal()
        {
            bpDelegateAuthPage = UIHelperAndroid.PageInit<BPDelegateAuthPage>(androidDriver);
            bpDelegateAuthPage.AddDelegate(BrokerToDelegateUsername);
        }

        [Then(@"I enable broker delegate on broker portal")]
        public void ThenIEnableBrokerDelegateOnBrokerPortal()
        {
            bpDelegateAuthPage = UIHelperAndroid.PageInit<BPDelegateAuthPage>(androidDriver);
            bpDelegateAuthPage.EnableDisableDeleteDelegate(BrokerToDelegateUsername, "ENABLE");
        }

        [Then(@"I delete broker delegate on broker portal")]
        public void ThenIDeleteBrokerDelegateOnBrokerPortal()
        {
            bpDelegateAuthPage = UIHelperAndroid.PageInit<BPDelegateAuthPage>(androidDriver);
            bpDelegateAuthPage.EnableDisableDeleteDelegate(BrokerToDelegateUsername, "DELETE");
        }

        [Then(@"I verify left navigation menu on My Profile for broker on broker portal")]
        public void ThenIVerifyLeftNavigationMenuOnMyProfileForBrokerOnBrokerPortal()
        {
            bpProfilePage = UIHelperAndroid.PageInit<BPProfilePage>(androidDriver);
            bpProfilePage.VerifyLeftNavigationMyProfileBroker();
        }

        [Then(@"I verify left navigation menu on My Profile for broker admin on broker portal")]
        public void ThenIVerifyLeftNavigationMenuOnMyProfileForBrokerAdminOnBrokerPortal()
        {
            bpProfilePage = UIHelperAndroid.PageInit<BPProfilePage>(androidDriver);
            bpProfilePage.VerifyLeftNavigationMyProfileBrokerAdmin();
        }

        [Then(@"I update Contact Information on My Profile on broker portal")]
        public void ThenIUpdateContactInformationOnMyProfileOnBrokerPortal()
        {
            bpContactInfoPage = UIHelperAndroid.PageInit<BPContactInfoPage>(androidDriver);
            bpContactInfoPage.UpdateContactInfo(unitNo, streetNo);
        }

        [Then(@"I verify Contact Information updated on My Profile on broker portal")]
        public void ThenIVerifyContactInformationUpdatedOnMyProfileOnBrokerPortal()
        {
            bpContactInfoPage.VerifyContactInfoUpdate(unitNo, streetNo);
        }
    }
}
