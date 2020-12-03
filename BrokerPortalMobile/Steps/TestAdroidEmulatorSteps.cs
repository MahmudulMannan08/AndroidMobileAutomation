using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile.Steps
{
    [Binding]
    public sealed class TestAdroidEmulatorSteps : TestBase
    {
        private readonly ScenarioContext context;

        public TestAdroidEmulatorSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I go to broker portal on android emulator")]
        public void GivenIGoToBrokerPortalOnAndroidEmulator()
        {
            InitializeMobileDriver(ConfigurationManager.AppSettings["platformName"]);
            androidDriver.Navigate().GoToUrl("https://identitymanagersg.prefirstcdn.com/BrokerIMProfile/login");
            UIHelperAndroid.WaitForPageLoad(60);
        }

    }
}
