using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BrokerPortalMobile.Pages.MMSPortalPages
{
    public class MMSNotesPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_ddlStandardNotes")]
        public IWebElement ddlNotes;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_txtNote")]
        public IWebElement txtNotes;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_chkBrokerAlert")]
        public IWebElement chkBrokerAlert;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_btnAdd")]
        public IWebElement btnAddNote;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_grdNotes")]
        public IWebElement tblNotes;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_grdNotes_ctl02_chkNoteBrokerAlert")]
        public IWebElement chkTblNotesBrokerAlert1;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_grdNotes_ctl02_chkNoteAcknowledge")]
        public IWebElement chkTblNotesAcknowledge1;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_grdNotes_ctl02_lblAcknowledgementUpdatedBy")]
        public IWebElement chkTblNotesAcknowledgedBy1;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_grdNotes_ctl02_lblAcknowledgementUpdatedDate")]
        public IWebElement chkTblNotesAcknowledgeDate1;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Notes_grdNotes_ctl02_lblNoteOrigin")]
        public IWebElement chkTblNotesNoteOrigin1;

        public void AddNoteWithWithoutBrokerAlert(string noteOption, string chkBrokerAlertStatus, int totalNoteRows)
        {
            UIHelper.SelectComboElement(ddlNotes, noteOption);
            UIHelper.SetCheckbox(chkBrokerAlert, chkBrokerAlertStatus);
            UIHelper.ClickOnLink(btnAddNote);
            UIHelper.WaitForPageLoad(15);
            Thread.Sleep(1500);
            UIHelper.WaitUntillExpectedTableEntry(tblNotes, totalNoteRows, 1, 30);
            UIHelper.SearchGridAndVerify(driver, tblNotes, noteOption, 1, 2);
            Assert.True(UIHelper.VerifyCheckboxStatus(chkTblNotesBrokerAlert1, chkBrokerAlertStatus), "MMS notes table Broker Alert checkbox found: " + chkBrokerAlertStatus);
        }

        public void VerifyMMSNotesGridForAcknowledgement(string noteOption, string noteOrigin, string AckChkStatus)
        {
            UIHelper.SearchGridAndVerify(driver, tblNotes, noteOption, 1, 2);
            //Assert.True(chkTblNotesAcknowledgedBy1.Text.Equals("Br. " + BrokerUsername), "Acknowledged By value does not match");
            Assert.True(UIHelper.VerifyCheckboxStatus(chkTblNotesAcknowledge1, AckChkStatus), "Expected MMS notes table Acknowledge checkbox checked, but found unchecked");
            if (AckChkStatus == "ON")
            {
                Assert.True(chkTblNotesAcknowledgeDate1.Text.Length > 0, "Acknowledged Date is empty");
            }
            else
            {
                Assert.True(chkTblNotesAcknowledgeDate1.Text.Length.Equals(0), "Acknowledged Date is not empty");
            }
            Assert.True(chkTblNotesNoteOrigin1.Text.Equals(noteOrigin), "Note Origin value does not match");
        }

        public void AcknowledgeBrokerReply()
        {
            UIHelper.SetCheckbox(chkTblNotesAcknowledge1, "ON");
            Thread.Sleep(3000);

            Assert.True(UIHelper.VerifyCheckboxStatus(chkTblNotesAcknowledge1, "ON"), "Expected MMS notes table Acknowledge checkbox checked, but found unchecked");
            Assert.True(chkTblNotesAcknowledgedBy1.Text.Contains(MMSUsername), "Acknowledged By value does not match");
            Assert.True(chkTblNotesAcknowledgeDate1.Text.Length > 0, "Acknowledged Date has not generated");
        }

        public void VerifyMMSNotesGridForNoteByBroker(string brokerNote, string noteOrigin)
        {
            UIHelper.SearchGridAndVerify(driver, tblNotes, brokerNote, 1, 2);
            IWebElement txtTblNotesUser1 = tblNotes.FindElements(By.TagName("tr"))[1].FindElements(By.TagName("td"))[1];
            IWebElement txtTblNotesDate1 = tblNotes.FindElements(By.TagName("tr"))[1].FindElements(By.TagName("td"))[0];
            Assert.True(txtTblNotesUser1.Text.Equals("Br. " + BrokerUsername), "User value does not match");
            Assert.True(txtTblNotesDate1.Text.Length > 0, "Date is empty");
            Assert.True(chkTblNotesNoteOrigin1.Text.Equals(noteOrigin), "Note Origin value does not match");
        }

        public void AddCustomNoteWithWithoutBrokerAlert(string note, string chkBrokerAlertStatus, int totalNoteRows)
        {
            UIHelper.EnterText(txtNotes, note);
            UIHelper.SetCheckbox(chkBrokerAlert, chkBrokerAlertStatus);
            UIHelper.ClickOnLink(btnAddNote);
            UIHelper.WaitForPageLoad(15);
            Thread.Sleep(1500);
            UIHelper.WaitUntillExpectedTableEntry(tblNotes, totalNoteRows, 1, 30);
            UIHelper.SearchGridAndVerify(driver, tblNotes, note, 1, 2);
            Assert.True(UIHelper.VerifyCheckboxStatus(chkTblNotesBrokerAlert1, chkBrokerAlertStatus), "MMS notes table Broker Alert checkbox found: " + chkBrokerAlertStatus);
        }

        public void ChkUnchkTableBrokerAlert(string chkBrokerAlertStatus)
        {
            UIHelper.SetCheckbox(chkTblNotesBrokerAlert1, chkBrokerAlertStatus);
            Assert.True(UIHelper.VerifyCheckboxStatus(chkTblNotesBrokerAlert1, chkBrokerAlertStatus), "MMS notes table Broker Alert checkbox found: " + chkBrokerAlertStatus);
        }
    }
}
