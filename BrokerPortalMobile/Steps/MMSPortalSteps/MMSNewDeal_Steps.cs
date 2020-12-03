using BrokerPortalMobile.Pages.MMSPortalPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile.Steps.MMSPortalSteps
{
    [Binding]
    public sealed class MMSNewDeal_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSHomePage mmsHomePage;
        public static MMSNewDealPage mmsNewDealPage;
        public static string mmsFctUrn = null;
        public static string mmsFctUrnDelegate = null;
        public static string mortgagorLastName = "Mortgagor-" + GenerateString(4);
        public static string lenderRefNo = "MMS-" + GenerateNumber(7);

        public MMSNewDeal_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I create new deal on MMS Portal")]
        public void ThenICreateNewDealOnMMSPortal()
        {
            mmsHomePage = UIHelper.PageInit<MMSHomePage>(driver);
            mmsHomePage.MMSSwitchToTab("New Deal");

            mmsNewDealPage = UIHelper.PageInit<MMSNewDealPage>(driver);
            mmsNewDealPage.CreateNewMMSDeal(MMSLenderName, mortgagorLastName, lenderRefNo, ClosingDate, projectDirectory + @"\BrokerPortalMobile\BrokerPortalMobile\TestData\Test.pdf");
        }

        [Then(@"I get MMS FCT Urn")]
        public void ThenIGetMMSFCTUrn()
        {
            mmsFctUrn = mmsNewDealPage.GetMMSFCTUrn();
            if (mmsFctUrn == null)
            {
                Assert.True(mmsFctUrn.Length > 0, "Failed to create MMS deal");
            }
        }

        [Then(@"I get MMS FCT Urn for broker delegate")]
        public void ThenIGetMMSFCTUrnForBrokerDelegate()
        {
            mmsFctUrnDelegate = mmsNewDealPage.GetMMSFCTUrn();
            if (mmsFctUrnDelegate == null)
            {
                Assert.True(false, "Failed to create MMS deal for broker delegate");
            }
        }
    }
}
