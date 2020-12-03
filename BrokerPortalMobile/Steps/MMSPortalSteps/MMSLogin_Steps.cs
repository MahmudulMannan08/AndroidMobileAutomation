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
    public sealed class MMSLogin_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSLoginPage mmsLoginPage;

        public MMSLogin_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I go to MMS FCT Portal")]
        public void GivenIGoToMMSFCTPortal()
        {
            InitializeDriver();
            UIHelper.GoTo<MMSLoginPage>(MMSPortal);
        }

        [Then(@"I login to MMS Portal")]
        public void ThenILoginToMMSPortal()
        {
            mmsLoginPage = UIHelper.PageInit<MMSLoginPage>(driver);
            mmsLoginPage.SigninToMMSPortal(MMSUsername, MMSPassword);
        }
    }
}
