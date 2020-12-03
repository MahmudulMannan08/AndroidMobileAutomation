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
    public sealed class BTDealDetails_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static BTDealDetailsPage btDealDetailsPage;
        public static string motionMilestoneDate = CurrentDate("MMM dd, yyyy");
        public static string mmsMilestoneDate = CurrentDate("MMM dd, yyyy");

        public BTDealDetails_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I verify Action Required section for broker alert available on Broker Tracker")]
        public void ThenIVerifyActionRequiredSectionForBrokerAlertAvailableOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyAlertDealDetails(true);
            btDealDetailsPage.VerifyActionDetailSec(MMSNote, true);
        }

        [Then(@"I verify Action Required section for Motion broker alert available on Broker Tracker")]
        public void ThenIVerifyActionRequiredSectionForMotionBrokerAlertAvailableOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyAlertDealDetailsMotion(true);
            btDealDetailsPage.VerifyActionDetailSecMotion(MotionNote, true);
        }

        [Then(@"I verify Action Required section for Motion broker alert unavailable on Broker Tracker")]
        public void ThenIVerifyActionRequiredSectionForMotionBrokerAlertUnavailableOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyAlertDealDetailsMotion(false);
            btDealDetailsPage.VerifyActionDetailSecMotion(MotionNote, false);
        }

        [Then(@"I verify Action Required section for second broker alert available on Broker Tracker")]
        public void ThenIVerifyActionRequiredSectionForSecondBrokerAlertAvailableOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyAlertDealDetails(true);
            btDealDetailsPage.VerifyActionDetailSec(MMSNote2, true);
        }

        [Then(@"I verify Action Required section for second Motion broker alert available on Broker Tracker")]
        public void ThenIVerifyActionRequiredSectionForSecondMotionBrokerAlertAvailableOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyAlertDealDetailsMotion(true);
            btDealDetailsPage.VerifyActionDetailSecMotion(MotionNote2, true);
        }

        [Then(@"I verify Action Required section for broker alert unavailable on Broker Tracker")]
        public void ThenIVerifyActionRequiredSectionForBrokerAlertUnavailableOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyAlertDealDetails(false);
            btDealDetailsPage.VerifyActionDetailSec(MMSNote, false);
        }

        [Then(@"I acknowledge NO to broker alert on Broker Tracker")]
        public void ThenIAcknowledgeNOToBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.AcknowledgeAlert(false);
        }

        [Then(@"Motion - I acknowledge NO to broker alert on Broker Tracker")]
        public void ThenMotion_IAcknowledgeNOToBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.AcknowledgeAlertMotion(false);
        }

        [Then(@"I acknowledge YES to broker alert on Broker Tracker")]
        public void ThenIAcknowledgeYESToBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.AcknowledgeAlert(true, MMSNote);
        }

        [Then(@"I acknowledge YES to Motion broker alert on Broker Tracker")]
        public void ThenIAcknowledgeYESToMotionBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.AcknowledgeAlertMotion(true, MotionNote);
        }

        [Then(@"I cancel reply to broker alert on Broker Tracker")]
        public void ThenICancelReplyToBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.ReplyAlert(false);
        }

        [Then(@"Motion - I cancel reply to broker alert on Broker Tracker")]
        public void ThenMotion_ICancelReplyToBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.ReplyAlertMotion(false);
        }

        [Then(@"I submit reply to Motion broker alert on Broker Tracker")]
        public void ThenISubmitReplyToMotionBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.ReplyAlertMotion(true, BrokerUsername, BrokerAlertReply, MotionNote);
        }

        [Then(@"I submit reply to broker alert on Broker Tracker")]
        public void ThenISubmitReplyToBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.ReplyAlert(true, BrokerUsername, BrokerAlertReply, MMSNote);
        }

        [Then(@"I submit reply to second MMS broker alert on Broker Tracker")]
        public void ThenISubmitReplyToSecondMMSBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.ReplyAlert(true, BrokerUsername, BrokerAlertReply, MMSNote2);
        }

        [Then(@"I submit reply to second Motion broker alert on Broker Tracker")]
        public void ThenISubmitReplyToSecondMotionBrokerAlertOnBrokerTracker()
        {
            btDealDetailsPage.ReplyAlertMotion(true, BrokerUsername, BrokerAlertReply, MotionNote2);
        }

        [Then(@"I cancel new note on Broker Tracker")]
        public void ThenICancelNewNoteOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.NewNote(false, true);
        }

        [Then(@"Motion - I cancel new note on Broker Tracker")]
        public void ThenMotion_ICancelNewNoteOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.NewNoteMotion(false, true);
        }

        [Then(@"I send new note to Lender on Broker Tracker")]
        public void ThenISendNewNoteToLenderOnBrokerTracker()
        {
            btDealDetailsPage.NewNote(true, true, BrokerNewNote);
        }

        [Then(@"Motion - I send new note to Lender on Broker Tracker")]
        public void ThenMotion_ISendNewNoteToLenderOnBrokerTracker()
        {
            btDealDetailsPage.NewNoteMotion(true, true, BrokerNewNote);
        }

        [Then(@"I verify blank note grid on Broker Tracker")]
        public void ThenIVerifyBlankNoteGridOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyBlankNoteGrid();
        }

        [Then(@"Motion - I verify blank note grid on Broker Tracker")]
        public void ThenMotion_IVerifyBlankNoteGridOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyBlankNoteGridMotion();
        }

        [Then(@"I verify acknowledged MMS note grid on Broker Tracker")]
        public void ThenIVerifyAcknowledgedMMSNoteGridOnBrokerTracker()
        {
            btDealDetailsPage.VerifyBTNoteGrid(1, MMSNote, "FCT");
        }

        [Then(@"I verify acknowledged Motion note grid on Broker Tracker")]
        public void ThenIVerifyAcknowledgedMotionNoteGridOnBrokerTracker()
        {
            btDealDetailsPage.VerifyBTNoteGridMotion(1, MotionNote, "FCT");
        }

        [Then(@"I verify replied MMS note grid on Broker Tracker")]
        public void ThenIVerifyRepliedMMSNoteGridOnBrokerTracker()
        {
            btDealDetailsPage.VerifyBTNoteGrid(1, BrokerAlertReply, BrokerUsername);
            btDealDetailsPage.VerifyBTNoteGrid(2, MMSNote2, "FCT");
        }

        [Then(@"I verify replied Motion note grid on Broker Tracker")]
        public void ThenIVerifyRepliedMotionNoteGridOnBrokerTracker()
        {
            btDealDetailsPage.VerifyBTNoteGridMotion(1, BrokerAlertReply, BrokerUsername);
            btDealDetailsPage.VerifyBTNoteGridMotion(2, MotionNote2, "FCT");
        }

        [Then(@"I verify MMS deal details on Broker Tracker")]
        public void ThenIVerifyMMSDealDetailsOnBrokerTracker()
        {
            var propertyAddress = PropertyAddress1 + " " + PropertyCity + " " + ReturnProvinceCode(PropertyProvince) + " " + PropertyPostalCode;
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyDealDetails(MMSNewDeal_Steps.mmsFctUrn, MMSLenderName, propertyAddress, MMSNewDeal_Steps.lenderRefNo, ConvertStringDateFormat(ClosingDate, "MM/dd/yyyy", "MMM dd, yyyy"));
        }

        [Then(@"I verify Motion deal details on Broker Tracker")]
        public void ThenIVerifyMotionDealDetailsOnBrokerTracker()
        {
            var propertyAddress = MotionPropertyAddress + ", " + MotionPropertyCity + ", " + ReturnProvinceMotion(MotionProgram) + ", " + MotionPropertyPostalCode;
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyDealDetailsMotion(MotionHome_Steps.fctUrnMotion, ReturnLenderMotion(MotionProgram), propertyAddress);
        }

        [Then(@"I verify MMS person mortgagor information on Broker Tracker")]
        public void ThenIVerifyMMSPersonMortgagorInformationOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMortgagorDealDetails(MMSMortgagor_Steps.mortgagorFirstName + " " + MMSNewDeal_Steps.mortgagorLastName);
        }

        [Then(@"I verify Motion person mortgagor information on Broker Tracker")]
        public void ThenIVerifyMotionPersonMortgagorInformationOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMortgagorDealDetailsMotion(MotionDealDetails_Steps.mortgagorFirstName + " " + MotionDealDetails_Steps.mortgagorLastName);
        }

        [Then(@"I verify MMS business mortgagor information on Broker Tracker")]
        public void ThenIVerifyMMSBusinessMortgagorInformationOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMortgagorDealDetails(MMSMortgagor_Steps.mortgagorBusiness);
        }

        [Then(@"I verify Motion business mortgagor information on Broker Tracker")]
        public void ThenIVerifyMotionBusinessMortgagorInformationOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMortgagorDealDetailsMotion(MotionMortgagor_Steps.companyName);
        }

        [Then(@"I verify multiple MMS mortgagor information on Broker Tracker")]
        public void ThenIVerifyMultipleMMSMortgagorInformationOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMortgagorDealDetails(MMSMortgagor_Steps.mortgagorBusiness);
            btDealDetailsPage.VerifyMortgagorDealDetails(MMSMortgagor_Steps.mortgagorFirstName + " " + MMSNewDeal_Steps.mortgagorLastName);
        }

        [Then(@"I verify multiple Motion mortgagor information on Broker Tracker")]
        public void ThenIVerifyMultipleMotionMortgagorInformationOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMortgagorDealDetailsMotion(MotionMortgagor_Steps.companyName);
            btDealDetailsPage.VerifyMortgagorDealDetailsMotion(MotionDealDetails_Steps.mortgagorFirstName + " " + MotionDealDetails_Steps.mortgagorLastName);
        }

        [Then(@"I verify deal milestones for MMS on Broker Tracker")]
        public void ThenIVerifyDealMilestonesForMMSOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMMSMilestones();
        }

        [Then(@"I verify deal milestones for Motion on Broker Tracker")]
        public void ThenIVerifyDealMilestonesForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestones();
        }

        [Then(@"I verify Deal received milestone status completed for MMS on Broker Tracker")]
        public void ThenIVerifyDealReceivedMilestoneStatusCompletedForMMSOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMMSMilestoneStatus("DEAL RECEIVED", true, mmsMilestoneDate);
            btDealDetailsPage.VerifyMMSMilestoneStatus("SOLICITOR INSTRUCTED", false);
            btDealDetailsPage.VerifyMMSMilestoneStatus("BROKER CONDITIONS MET", false);
            btDealDetailsPage.VerifyMMSMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Deal received milestone status completed for Motion on Broker Tracker")]
        public void ThenIVerifyDealReceivedMilestoneStatusCompletedForMotionOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Statements ordered milestone status completed for Motion on Broker Tracker")]
        public void ThenIVerifyStatementsOrderedMilestoneStatusCompletedForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Statements ordered milestone status turns incomplete for Motion on Broker Tracker")]
        public void ThenIVerifyStatementsOrderedMilestoneStatusTurnsIncompleteForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Statements received milestone status completed for Motion on Broker Tracker")]
        public void ThenIVerifyStatementsReceivedMilestoneStatusCompletedForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Statements received milestone status turns incomplete for Motion on Broker Tracker")]
        public void ThenIVerifyStatementsReceivedMilestoneStatusTurnsIncompleteForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Signing appointment booked milestone status completed for Motion on Broker Tracker")]
        public void ThenIVerifySigningAppointmentBookedMilestoneStatusCompletedForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Signing appointment booked milestone status turns incomplete for Motion on Broker Tracker")]
        public void ThenIVerifySigningAppointmentBookedMilestoneStatusTurnsIncompleteForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", false);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Funded milestone status completed for Motion on Broker Tracker")]
        public void ThenIVerifyFundedMilestoneStatusCompletedForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", true, motionMilestoneDate);
        }

        [Then(@"I verify Funded milestone status turns incomplete for Motion on Broker Tracker")]
        public void ThenIVerifyFundedMilestoneStatusTurnsIncompleteForMotionOnBrokerTracker()
        {
            btDealDetailsPage = UIHelperAndroid.PageInit<BTDealDetailsPage>(androidDriver);
            btDealDetailsPage.VerifyMotionMilestoneStatus("DEAL RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS ORDERED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("STATEMENTS RECEIVED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("SIGNING APPOINTMENT BOOKED", true, motionMilestoneDate);
            btDealDetailsPage.VerifyMotionMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Solicitor instructed milestone status completed for MMS on Broker Tracker")]
        public void ThenIVerifySolicitorInstructedMilestoneStatusCompletedForMMSOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMMSMilestoneStatus("DEAL RECEIVED", true, mmsMilestoneDate);
            btDealDetailsPage.VerifyMMSMilestoneStatus("SOLICITOR INSTRUCTED", true, mmsMilestoneDate);
            btDealDetailsPage.VerifyMMSMilestoneStatus("BROKER CONDITIONS MET", false);
            btDealDetailsPage.VerifyMMSMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Broker conditions met milestone status completed for MMS on Broker Tracker")]
        public void ThenIVerifyBrokerConditionsMetMilestoneStatusCompletedForMMSOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMMSMilestoneStatus("DEAL RECEIVED", true, mmsMilestoneDate);
            btDealDetailsPage.VerifyMMSMilestoneStatus("SOLICITOR INSTRUCTED", true, mmsMilestoneDate);
            btDealDetailsPage.VerifyMMSMilestoneStatus("BROKER CONDITIONS MET", true, mmsMilestoneDate);
            btDealDetailsPage.VerifyMMSMilestoneStatus("FUNDED", false);
        }

        [Then(@"I verify Broker conditions met milestone status is unset for MMS on Broker Tracker")]
        public void ThenIVerifyBrokerConditionsMetMilestoneStatusIsUnsetForMMSOnBrokerTracker()
        {
            btDealDetailsPage.VerifyMMSMilestoneStatus("DEAL RECEIVED", true, mmsMilestoneDate);
            btDealDetailsPage.VerifyMMSMilestoneStatus("SOLICITOR INSTRUCTED", true, mmsMilestoneDate);
            btDealDetailsPage.VerifyMMSMilestoneStatus("BROKER CONDITIONS MET", false);
            btDealDetailsPage.VerifyMMSMilestoneStatus("FUNDED", false);
        }
    }
}
