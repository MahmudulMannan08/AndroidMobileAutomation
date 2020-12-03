using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using BrokerPortalMobile.Pages;
using BrokerPortalMobile.Pages.BrokerPortalPages;
using BrokerPortalMobile.Steps.MMSPortalSteps;
using BrokerPortalMobile.Steps.MotionSteps;

namespace BrokerPortalMobile.Steps.BrokerPortalSteps
{
    [Binding]
    public sealed class BPDealDetails_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static BPDealDetailsPage bpDealDetailsPage;
        public static string motionMilestoneDate = CurrentDate("MMM d, yyyy");
        public static string mmsMilestoneDate = CurrentDate("MMM d, yyyy");

        public BPDealDetails_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I verify Action Required section for broker alert available")]
        public void ThenIVerifyActionRequiredSectionForBrokerAlertAvailable()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyAlertDealDetails(true);
            bpDealDetailsPage.VerifyActionDetailSec(MMSNote, true);
        }

        [Then(@"I verify Action Required section for second broker alert available")]
        public void ThenIVerifyActionRequiredSectionForSecondBrokerAlertAvailable()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyAlertDealDetails(true);
            bpDealDetailsPage.VerifyActionDetailSec(MMSNote2, true);
        }

        [Then(@"I verify Action Required section for Motion broker alert available")]
        public void ThenIVerifyActionRequiredSectionForMotionBrokerAlertAvailable()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyAlertDealDetails(true);
            bpDealDetailsPage.VerifyActionDetailSec(MotionNote, true);
        }

        [Then(@"I verify Action Required section for second Motion broker alert available")]
        public void ThenIVerifyActionRequiredSectionForSecondMotionBrokerAlertAvailable()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyAlertDealDetails(true);
            bpDealDetailsPage.VerifyActionDetailSec(MotionNote2, true);
        }

        [Then(@"I verify Action Required section for custom note broker alert available")]
        public void ThenIVerifyActionRequiredSectionForCustomNoteBrokerAlertAvailable()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyAlertDealDetails(true);
            bpDealDetailsPage.VerifyActionDetailSec(MMSCustomNote, true);
        }

        [Then(@"I verify Action Required section for broker alert unavailable")]
        public void ThenIVerifyActionRequiredSectionForBrokerAlertUnavailable()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyAlertDealDetails(false);
            bpDealDetailsPage.VerifyActionDetailSec(MMSNote, false);
        }

        [Then(@"I verify Action Required section for Motion broker alert unavailable")]
        public void ThenIVerifyActionRequiredSectionForMotionBrokerAlertUnavailable()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyAlertDealDetails(false);
            bpDealDetailsPage.VerifyActionDetailSec(MotionNote, false);
        }

        [Then(@"I verify blank note grid on broker portal")]
        public void ThenIVerifyBlankNoteGridOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyBlankNoteGrid();
        }

        //[Then(@"I cancel new note to MMS on broker portal")]
        //public void ThenICancelNewNoteToMMSOnBrokerPortal()
        //{
        //    bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
        //    bpDealDetailsPage.NewNote(false, BrokerUsername);
        //}

        [Then(@"I cancel new note on broker portal")]
        public void ThenICancelNewNoteOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.NewNote(false, BrokerUsername);
        }

        [Then(@"I send new note to Lender on broker portal")]
        public void ThenISendNewNoteToLenderOnBrokerPortal()
        {
            bpDealDetailsPage.NewNote(true, BrokerUsername, BrokerNewNote);
        }

        [Then(@"I send new note to Lender on broker portal without scroll")]
        public void ThenISendNewNoteToLenderOnBrokerPortalWithoutScroll()
        {
            bpDealDetailsPage.NewNoteWithoutScroll(true, BrokerUsername, BrokerNewNote);
        }

        [Then(@"I send new note again to MMS on broker portal")]
        public void ThenISendNewNoteAgainToMMSOnBrokerPortal()
        {
            bpDealDetailsPage.NewNote(true, BrokerUsername, BrokerNewNote2);
        }

        [Then(@"I acknowledge NO to broker alert")]
        public void ThenIAcknowledgeNOToBrokerAlert()
        {
            bpDealDetailsPage.AcknowledgeAlert(false);
        }

        [Then(@"I acknowledge YES to broker alert")]
        public void ThenIAcknowledgeYESToBrokerAlert()
        {
            bpDealDetailsPage.AcknowledgeAlert(true, MMSNote);
        }

        [Then(@"I acknowledge YES to Motion broker alert")]
        public void ThenIAcknowledgeYESToMotionBrokerAlert()
        {
            bpDealDetailsPage.AcknowledgeAlert(true, MotionNote);
        }

        [Then(@"I acknowledge YES to custom note broker alert")]
        public void ThenIAcknowledgeYESToCustomNoteBrokerAlert()
        {
            bpDealDetailsPage.AcknowledgeAlert(true, MMSCustomNote);
        }

        [Then(@"I cancel reply to broker alert")]
        public void ThenICancelReplyToBrokerAlert()
        {
            bpDealDetailsPage.ReplyAlert(false, BrokerUsername);
        }

        [Then(@"I submit reply to broker alert")]
        public void ThenISubmitReplyToBrokerAlert()
        {
            bpDealDetailsPage.ReplyAlert(true, BrokerUsername, BrokerAlertReply, MMSNote);
        }

        [Then(@"I submit reply to second MMS broker alert")]
        public void ThenISubmitReplyToSecondMMSBrokerAlert()
        {
            bpDealDetailsPage.ReplyAlertWithoutScroll(true, BrokerUsername, BrokerAlertReply, MMSNote2);
        }

        [Then(@"I submit reply to Motion broker alert")]
        public void ThenISubmitReplyToMotionBrokerAlert()
        {
            bpDealDetailsPage.ReplyAlert(true, BrokerUsername, BrokerAlertReply, MotionNote);
        }

        [Then(@"I submit reply to second Motion broker alert")]
        public void ThenISubmitReplyToSecondMotionBrokerAlert()
        {
            bpDealDetailsPage.ReplyAlertWithoutScroll(true, BrokerUsername, BrokerAlertReply, MotionNote2);
        }

        [Then(@"I verify MMS deal details on broker portal")]
        public void ThenIVerifyMMSDealDetailsOnBrokerPortal()
        {
            var propertyAddress = PropertyAddress1 + " " + PropertyCity + " " + ReturnProvinceCode(PropertyProvince) + " " + PropertyPostalCode;
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyDealDetails(MMSNewDeal_Steps.mmsFctUrn, MMSLenderName, propertyAddress, MMSNewDeal_Steps.lenderRefNo, ConvertStringDateFormat(ClosingDate, "MM/dd/yyyy", "MMM dd, yyyy"));
        }

        [Then(@"I verify Motion deal details on broker portal")]
        public void ThenIVerifyMotionDealDetailsOnBrokerPortal()
        {
            var propertyAddress = MotionPropertyAddress + ", " + MotionPropertyCity + ", " + ReturnProvinceMotion(MotionProgram) + ", " + MotionPropertyPostalCode;
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyDealDetails(MotionHome_Steps.fctUrnMotion, ReturnLenderMotion(MotionProgram), propertyAddress);
        }

        [Then(@"I verify MMS person mortgagor information on broker portal")]
        public void ThenIVerifyMMSPersonMortgagorInformationOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMortgagorDealDetails(MMSMortgagor_Steps.mortgagorFirstName + " " + MMSNewDeal_Steps.mortgagorLastName);
        }

        [Then(@"I verify Motion person mortgagor information on broker portal")]
        public void ThenIVerifyMotionPersonMortgagorInformationOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMortgagorDealDetails(MotionDealDetails_Steps.mortgagorFirstName + " " + MotionDealDetails_Steps.mortgagorLastName);
        }

        [Then(@"I verify MMS business mortgagor information on broker portal")]
        public void ThenIVerifyMMSBusinessMortgagorInformationOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMortgagorDealDetails(MMSMortgagor_Steps.mortgagorBusiness);
        }

        [Then(@"I verify Motion business mortgagor information on broker portal")]
        public void ThenIVerifyMotionBusinessMortgagorInformationOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMortgagorDealDetails(MotionMortgagor_Steps.companyName);
        }

        [Then(@"I verify multiple MMS mortgagor information on broker portal")]
        public void ThenIVerifyMultipleMMSMortgagorInformationOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMortgagorDealDetails(MMSMortgagor_Steps.mortgagorBusiness);
            bpDealDetailsPage.VerifyMortgagorDealDetails(MMSMortgagor_Steps.mortgagorFirstName + " " + MMSNewDeal_Steps.mortgagorLastName);
        }

        [Then(@"I verify multiple Motion mortgagor information on broker portal")]
        public void ThenIVerifyMultipleMotionMortgagorInformationOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMortgagorDealDetails(MotionMortgagor_Steps.companyName);
            bpDealDetailsPage.VerifyMortgagorDealDetails(MotionDealDetails_Steps.mortgagorFirstName + " " + MotionDealDetails_Steps.mortgagorLastName);
        }

        [Then(@"I verify deal milestones for MMS on broker portal")]
        public void ThenIVerifyDealMilestonesForMMSOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMMSMilestones();
        }

        [Then(@"I verify deal milestones for Motion on broker portal")]
        public void ThenIVerifyDealMilestonesForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestones();
        }

        [Then(@"I verify Deal received milestone status completed for MMS on broker portal")]
        public void ThenIVerifyDealReceivedMilestoneStatusCompletedForMMSOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMMSMilestoneStatus("DEAL RECEIVED", true, mmsMilestoneDate);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("SOLICITOR INSTRUCTED", false);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("BROKER CONDITIONS MET", false);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Deal received milestone status completed for Motion on broker portal")]
        public void ThenIVerifyDealReceivedMilestoneStatusCompletedForMotionOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Statements ordered milestone status completed for Motion on broker portal")]
        public void ThenIVerifyStatementsOrderedMilestoneStatusCompletedForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Statements ordered milestone status turns incomplete for Motion on broker portal")]
        public void ThenIVerifyStatementsOrderedMilestoneStatusTurnsIncompleteForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Statements received milestone status completed for Motion on broker portal")]
        public void ThenIVerifyStatementsReceivedMilestoneStatusCompletedForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Statements received milestone status turns incomplete for Motion on broker portal")]
        public void ThenIVerifyStatementsReceivedMilestoneStatusTurnsIncompleteForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Signing appointment booked milestone status completed for Motion on broker portal")]
        public void ThenIVerifySigningAppointmentBookedMilestoneStatusCompletedForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Signing appointment booked milestone status turns incomplete for Motion on broker portal")]
        public void ThenIVerifySigningAppointmentBookedMilestoneStatusTurnsIncompleteForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Funded milestone status completed for Motion on broker portal")]
        public void ThenIVerifyFundedMilestoneStatusCompletedForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", true, motionMilestoneDate);
        }

        [Then(@"I verify Funded milestone status turns incomplete for Motion on broker portal")]
        public void ThenIVerifyFundedMilestoneStatusTurnsIncompleteForMotionOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelper.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", true, motionMilestoneDate);
            bpDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Solicitor instructed milestone status completed for MMS on broker portal")]
        public void ThenIVerifySolicitorInstructedMilestoneStatusCompletedForMMSOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMMSMilestoneStatus("DEAL RECEIVED", true, mmsMilestoneDate);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("SOLICITOR INSTRUCTED", true, mmsMilestoneDate);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("BROKER CONDITIONS MET", false);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Broker conditions met milestone status completed for MMS on broker portal")]
        public void ThenIVerifyBrokerConditionsMetMilestoneStatusCompletedForMMSOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMMSMilestoneStatus("DEAL RECEIVED", true, mmsMilestoneDate);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("SOLICITOR INSTRUCTED", true, mmsMilestoneDate);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("BROKER CONDITIONS MET", true, mmsMilestoneDate);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Broker conditions met milestone status is unset for MMS on broker portal")]
        public void ThenIVerifyBrokerConditionsMetMilestoneStatusIsUnsetForMMSOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyMMSMilestoneStatus("DEAL RECEIVED", true, mmsMilestoneDate);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("SOLICITOR INSTRUCTED", true, mmsMilestoneDate);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("BROKER CONDITIONS MET", false);
            bpDealDetailsPage.VerifyMMSMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify acknowledged MMS note grid on broker portal")]
        public void ThenIVerifyAcknowledgedMMSNoteGridOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyBPNoteGrid(1, "FCT", MMSNote, CurrentDate("MMM d, yyyy"), BrokerName, "ACKNOWLEDGE");
        }

        [Then(@"I verify acknowledged Motion note grid on broker portal")]
        public void ThenIVerifyAcknowledgedMotionNoteGridOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyBPNoteGrid(1, "FCT", MotionNote, CurrentDate("MMM d, yyyy"), BrokerName, "ACKNOWLEDGE");
        }

        [Then(@"I verify replied MMS note grid on broker portal")]
        public void ThenIVerifyRepliedMMSNoteGridOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyBPNoteGrid(1, BrokerUsername, BrokerAlertReply, CurrentDate("MMM d, yyyy"));
            bpDealDetailsPage.VerifyBPNoteGrid(2, "FCT", MMSNote2, CurrentDate("MMM d, yyyy"));
        }

        [Then(@"I verify replied Motion note grid on broker portal")]
        public void ThenIVerifyRepliedMotionNoteGridOnBrokerPortal()
        {
            bpDealDetailsPage = UIHelperAndroid.PageInit<BPDealDetailsPage>(androidDriver);
            bpDealDetailsPage.VerifyBPNoteGrid(1, BrokerUsername, BrokerAlertReply, CurrentDate("MMM d, yyyy"));
            bpDealDetailsPage.VerifyBPNoteGrid(2, "FCT", MotionNote2, CurrentDate("MMM d, yyyy"));
        }

        [Then(@"I verify new note grid on broker portal")]
        public void ThenIVerifyNewNoteGridOnBrokerPortal()
        {
            bpDealDetailsPage.VerifyBPNoteGrid(1, BrokerUsername, BrokerNewNote, CurrentDate("MMM d, yyyy"));
        }
    }
}
