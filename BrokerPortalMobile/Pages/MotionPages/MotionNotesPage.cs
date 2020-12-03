using AutoIt;
using BrokerPortalMobile.Steps.MotionSteps;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MotionPages
{
    public class MotionNotesPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "cmdNew")]
        public IWebElement btnNew;

        [FindsBy(How = How.Id, Using = "scrNotes")]
        public IWebElement tblNotes;

        public void VerifyMotionAlertChkBoxStatus(int rowNumber, bool chkboxStatus)
        {
            IList<IWebElement> Rows = tblNotes.FindElements(By.TagName("tr"));
            IWebElement chkboxElement = Rows[rowNumber].FindElements(By.TagName("td"))[1];
            if (chkboxStatus)
            {
                Assert.True(UIHelper.IsAttributePreset(chkboxElement, "CHECKED"), "Expected checkbox checked but found unchecked");
            }
            else
            {
                Assert.False(UIHelper.IsAttributePreset(chkboxElement, "CHECKED"), "Expected checkbox unchecked but found checked");
            }
        }

        public void ChkUnchkTableAlertChkBox(int rowNumber, string chkboxStatus)
        {
            IList<IWebElement> Rows = tblNotes.FindElements(By.TagName("tr"));
            IWebElement chkboxElement = Rows[rowNumber].FindElements(By.TagName("td"))[1];
            if (chkboxStatus.ToUpper() == "ON")
            {
                if (UIHelper.IsAttributePreset(chkboxElement, "CHECKED").Equals(false))
                {
                    chkboxElement.Click();
                }
            }
            if (chkboxStatus.ToUpper() == "OFF")
            {
                if (UIHelper.IsAttributePreset(chkboxElement, "CHECKED"))
                {
                    chkboxElement.Click();
                }
            }
        }

        public void VerifyTableAckdStatus(int rowNumber, bool ackdStatus)
        {
            IList<IWebElement> Rows = tblNotes.FindElements(By.TagName("tr"));
            IWebElement ackdElement = Rows[rowNumber].FindElements(By.TagName("td"))[4];
            if (ackdStatus)
            {
                Assert.True(ackdElement.Text.Equals("Yes"), "Note is not found acknowledged");
            }
            else
            {
                Assert.True(ackdElement.Text.Equals("No"), "Note is found acknowledged");
            }
        }

        public void VerifyTableDateAvailable(int rowNumber)
        {
            IList<IWebElement> Rows = tblNotes.FindElements(By.TagName("tr"));
            IWebElement dateElement = Rows[rowNumber].FindElements(By.TagName("td"))[2];

            Assert.True(dateElement.Text.Length > 0, "Date is empty");
        }

        public string GetTableUser(int rowNumber)
        {
            IList<IWebElement> Rows = tblNotes.FindElements(By.TagName("tr"));
            IWebElement userElement = Rows[rowNumber].FindElements(By.TagName("td"))[3];

            return userElement.Text;
        }

        public void AddMotionNoteWithWithoutAlert(string note, bool chkBrokerAlert, int totalNoteRows)
        {
            clickNewNote();

            AutoItX.Send("" + note + "");
            Thread.Sleep(1000);

            AutoItX.Send("{TAB 2}");
            Thread.Sleep(1000);
            if (chkBrokerAlert)
            {
                AutoItX.Send("{SPACE}");
                Thread.Sleep(1000);
            }

            AutoItX.Send("{TAB}");
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
            Thread.Sleep(1500);

            UIHelper.WaitUntillExpectedTableEntry(tblNotes, totalNoteRows, 1, 30);
            UIHelper.SearchGridAndVerify(driver, tblNotes, note, 1, 5);
            //VerifyMotionAlertChkBoxStatus(1, chkBrokerAlert);
        }

        public void clickNewNote()
        {
            UIHelper.ClickOnLink(btnNew);
            Thread.Sleep(2000);
        }

        public void ChkUnchkTableBrAlert(int rowNumber, string chkboxStatus)
        {
            //UIHelper.SwitchToWindow(30, 1);
            //UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
            UIHelper.SwitchToWindowbyTitle(20, 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
            UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
            ChkUnchkTableAlertChkBox(rowNumber, chkboxStatus);
        }

        public void VerifyMotionNotesGridForAcknowledgement(int rowNumber, string note, string user)
        {
            UIHelper.SearchGridAndVerify(driver, tblNotes, note, 1, 5);
            VerifyTableAckdStatus(rowNumber, true);
            Assert.True(GetTableUser(rowNumber).Equals(user), "User value does not match");
            VerifyTableDateAvailable(rowNumber);
        }

        public void VerifyMotionNotesGridForNoteByBroker(int rowNumber, string brokerNote, string user)
        {
            UIHelper.SearchGridAndVerify(driver, tblNotes, brokerNote, 1, 5);
            Assert.True(GetTableUser(rowNumber).Equals("Br. " + user), "User value does not match");
            VerifyTableDateAvailable(rowNumber);
        }
    }
}
