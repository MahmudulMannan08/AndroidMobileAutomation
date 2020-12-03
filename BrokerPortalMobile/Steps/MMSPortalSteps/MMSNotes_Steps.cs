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
    public sealed class MMSNotes_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MMSViewDealPage mmsViewDealPage;
        public static MMSNotesPage mmsNotesPage;

        public MMSNotes_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I add MMS predefined note with broker alert")]
        public void ThenIAddMMSPredefinedNoteWithBrokerAlert()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Notes");

            mmsNotesPage = UIHelper.PageInit<MMSNotesPage>(driver);
            mmsNotesPage.AddNoteWithWithoutBrokerAlert(MMSNote, "ON", 1);
        }

        [Then(@"I add second MMS predefined note with broker alert")]
        public void ThenIAddSecondMMSPredefinedNoteWithBrokerAlert()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Notes");

            mmsNotesPage = UIHelper.PageInit<MMSNotesPage>(driver);
            mmsNotesPage.AddNoteWithWithoutBrokerAlert(MMSNote2, "ON", 1);
        }

        [Then(@"I add MMS custom note with broker alert")]
        public void ThenIAddMMSCustomNoteWithBrokerAlert()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Notes");

            mmsNotesPage = UIHelper.PageInit<MMSNotesPage>(driver);
            mmsNotesPage.AddCustomNoteWithWithoutBrokerAlert(MMSCustomNote, "ON", 1);
        }

        [Then(@"I add MMS predefined note without broker alert")]
        public void ThenIAddMMSPredefinedNoteWithoutBrokerAlert()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Notes");

            mmsNotesPage = UIHelper.PageInit<MMSNotesPage>(driver);
            mmsNotesPage.AddNoteWithWithoutBrokerAlert(MMSNote, "OFF", 1);
        }

        [Then(@"I check broker alert checkbox on MMS note grid")]
        public void ThenICheckBrokerAlertCheckboxOnMMSNoteGrid()
        {
            mmsNotesPage.ChkUnchkTableBrokerAlert("ON");
            Thread.Sleep(2000);   //Added static wait because of environment specific issue on RQA1
        }

        [Then(@"I verify note acknowledgement by broker on MMS Portal")]
        public void ThenIVerifyNoteAcknowledgementByBrokerOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Notes");

            mmsNotesPage = UIHelper.PageInit<MMSNotesPage>(driver);
            mmsNotesPage.VerifyMMSNotesGridForAcknowledgement(MMSNote, "FCT", "ON");
        }

        [Then(@"I verify note reply by broker on MMS Portal")]
        public void ThenIVerifyNoteReplyByBrokerOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Notes");

            mmsNotesPage = UIHelper.PageInit<MMSNotesPage>(driver);
            mmsNotesPage.VerifyMMSNotesGridForAcknowledgement(MMSNote, "BROKER", "OFF");
        }

        [Then(@"I acknowledge broker reply on MMS Portal")]
        public void ThenIAcknowledgeBrokerReplyOnMMSPortal()
        {
            mmsNotesPage.AcknowledgeBrokerReply();
        }

        [Then(@"I verify new note by broker on MMS Portal")]
        public void ThenIVerifyNewNoteByBrokerOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Notes");

            mmsNotesPage = UIHelper.PageInit<MMSNotesPage>(driver);
            mmsNotesPage.VerifyMMSNotesGridForNoteByBroker(BrokerNewNote, "BROKER");
        }

        [Then(@"I verify custom note acknowledgement by broker on MMS Portal")]
        public void ThenIVerifyCustomNoteAcknowledgementByBrokerOnMMSPortal()
        {
            mmsViewDealPage = UIHelper.PageInit<MMSViewDealPage>(driver);
            mmsViewDealPage.MMSSwitchToMenu("Notes");

            mmsNotesPage = UIHelper.PageInit<MMSNotesPage>(driver);
            mmsNotesPage.VerifyMMSNotesGridForAcknowledgement(MMSCustomNote, "FCT", "ON");
        }
    }
}
