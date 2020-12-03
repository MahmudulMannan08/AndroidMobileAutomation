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
    public sealed class MMSDocuments_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSViewDealPage mmsViewDealPage;
        public static MMSDocumentsPage mmsDocumentsPage;

        public MMSDocuments_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I upload solicitor instruction package on MMS Portal")]
        public void ThenIUploadSolicitorInstructionPackageOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Documents");

            mmsDocumentsPage = UIHelper.PageInit<MMSDocumentsPage>(driver);
            mmsDocumentsPage.SendDocumentMMS("Solicitor Instructions Pkg", projectDirectory + @"\BrokerPortalMobile\BrokerPortalMobile\TestData\Test.pdf");
        }
    }
}
