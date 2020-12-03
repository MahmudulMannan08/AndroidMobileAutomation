using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BrokerPortalMobile.Pages.BrokerPortalPages
{
    public class BPDealDetailsPage : TestBase
    {
        //[FindsBy(How = How.TagName, Using = "app-action-required")]
        //[FindsBy(How = How.TagName, Using = "img")]
        //public IWebElement lblAlertDealDetails;

        [FindsBy(How = How.XPath, Using = "//label[@class='subheader2-label']")]
        public IWebElement lblDealDetails;

        [FindsBy(How = How.TagName, Using = "app-deal-status")]
        public IWebElement divAppDealStatus;

        [FindsBy(How = How.TagName, Using = "app-deal-details")]
        public IWebElement divAppDealDetails;

        [FindsBy(How = How.TagName, Using = "app-action-required")]
        public IWebElement divActionRequired;

        [FindsBy(How = How.LinkText, Using = "Acknowledge")]
        public IWebElement btnAcknowledge;

        [FindsBy(How = How.LinkText, Using = "Reply")]
        public IWebElement btnReply;

        //[FindsBy(How = How.XPath, Using = "//div[starts-with(@id, 'confirmSec-')]")]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'collapse show')]")]
        public IWebElement modalAcknowledgeReply;

        ////[FindsBy(How = How.XPath, Using = "//div[starts-with(@id, 'confirmSec-')]")]
        //[FindsBy(How = How.XPath, Using = "//div[contains(@class, 'collapse show')]")]
        //[FindsBy(How = How.TagName, Using = "button")]
        //public IList<IWebElement> btnAcknowledgeConfirm;

        [FindsBy(How = How.XPath, Using = "//table[contains(@class,'table-condensed')]")]
        public IWebElement tblNotes;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'New Note')]")]
        public IWebElement btnNewNote;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'collapse show')]")]
        public IWebElement modalNewNote;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Closing Date')]")]
        public IWebElement lblCosingDate;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'FCT Reference No.')]")]
        public IWebElement lblFctRefNo;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Lender Name')]")]
        public IWebElement lblLenderName;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Mortgagor(s)')]")]
        public IWebElement lblMortgagors;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Address(es)')]")]
        public IWebElement lblAddresses;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Lender Reference No.')]")]
        public IWebElement lblLenderRefNo;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Deal received')]")]
        public IWebElement lblDealReceivedMilestone;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Solicitor instructed')]")]
        public IWebElement lblSolInstrMilestone;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Broker conditions met')]")]
        public IWebElement lblBrokerCondMilestone;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Funded')]")]
        public IWebElement lblFundedMilestone;

        [FindsBy(How = How.XPath, Using = "//body/app-root/app-layouts-auth/fw-framework-body/div[@id='fctApp']/div/div/div/div/app-deal/div/app-deal-status/div/div/div[2]/div[1]")]
        public IWebElement statDealReceivedMilestone;

        [FindsBy(How = How.XPath, Using = "//body/app-root/app-layouts-auth/fw-framework-body/div[@id='fctApp']/div/div/div/div/app-deal/div/app-deal-status/div/div/div[2]/div[2]")]
        public IWebElement statSolInstrMilestone;

        [FindsBy(How = How.XPath, Using = "//body/app-root/app-layouts-auth/fw-framework-body/div[@id='fctApp']/div/div/div/div/app-deal/div/app-deal-status/div/div/div[2]/div[2]")]
        public IWebElement statStatementOrdMilestone;

        [FindsBy(How = How.XPath, Using = "//app-deal-status//div[2]//div[3]")]
        public IWebElement statBrokerCondMilestone;

        [FindsBy(How = How.XPath, Using = "//app-deal-status//div[2]//div[3]")]
        public IWebElement statStatementRcvMilestone;

        [FindsBy(How = How.XPath, Using = "//app-deal-status//div[2]//div[4]")]
        public IWebElement statFundedMilestone;

        [FindsBy(How = How.XPath, Using = "//app-deal-status//div[2]//div[4]")]
        public IWebElement statSigningApptMilestone;

        [FindsBy(How = How.XPath, Using = "//app-deal-status//div[2]//div[5]")]
        public IWebElement statFundedMotionMilestone;

        public void VerifyAlertDealDetails(bool status)
        {
            UIHelperAndroid.ScrollToElement(androidDriver, lblLenderRefNo);
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.TagName("app-action-required")), "Action Required section not visible on deal details page");
            if (status)
            {
                Assert.True(androidDriver.FindElement(By.TagName("app-action-required")).FindElements(By.TagName("img")).Count() > 0, "Alert icon not found on Action Required section in Deal Details.");
            }
            else
            {
                Assert.True(androidDriver.FindElement(By.TagName("app-action-required")).FindElements(By.TagName("img")).Count() <= 0, "Alert icon found on Action Required section in Deal Details.");
            }
        }

        public void VerifyActionDetailSec(string noteOption, bool status)
        {
            if (status)
            {
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.TagName("app-action-required")), "Action Required section not visible on deal details page");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.LinkText("Acknowledge")), "Acknowledge link is not available");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.LinkText("Reply")), "Reply link is not available");
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'" + noteOption + "')]")));
            }
            else
            {
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.TagName("app-action-required")), "Action Required section not visible on deal details page");
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.LinkText("Acknowledge")), "Acknowledge link is not available");
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.LinkText("Reply")), "Reply link is not available");
                Assert.False(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'" + noteOption + "')]")));
                Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'There are no new notifications.')]")));
            }
        }

        public void VerifyBlankNoteGrid()
        {
            Assert.True(UIHelperAndroid.VerifyBlankGrid(tblNotes, 1), "Note grid contains data");
        }

        public void AcknowledgeAlert(bool status, string note = null)
        {
            UIHelperAndroid.ScrollToElement(androidDriver, divAppDealDetails);
            UIHelperAndroid.ClickOnLink(btnAcknowledge);
            UIHelperAndroid.WaitForElementVisible(modalAcknowledgeReply, 15);
            IList<IWebElement> btnAcknowledgeConfirm = new List<IWebElement>(androidDriver.FindElement(By.XPath("//div[contains(@class, 'collapse show')]")).FindElements(By.TagName("button")));

            if (status)
            {
                Assert.True(btnAcknowledgeConfirm[0].Displayed && btnAcknowledgeConfirm[0].Enabled, "Alert acknowledge No button is not displayed");
                Assert.True(btnAcknowledgeConfirm[1].Displayed && btnAcknowledgeConfirm[1].Enabled, "Alert acknowledge Yes button is not displayed");
                UIHelperAndroid.ClickOnLink(btnAcknowledgeConfirm[1]);
                UIHelperAndroid.WaitForSpinnerInvisible(30);
                VerifyAlertDealDetails(false);
                UIHelperAndroid.WaitUntillExpectedTableEntry(tblNotes, 1, 1, 30);
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, note, 1, 1));
            }
            else
            {
                Assert.True(btnAcknowledgeConfirm[0].Displayed && btnAcknowledgeConfirm[0].Enabled, "Alert acknowledge No button is not displayed");
                Assert.True(btnAcknowledgeConfirm[0].Text.Equals("No"));
                Assert.True(btnAcknowledgeConfirm[1].Displayed && btnAcknowledgeConfirm[1].Enabled, "Alert acknowledge Yes button is not displayed");
                Assert.True(btnAcknowledgeConfirm[1].Text.Equals("Yes"));
                UIHelperAndroid.ClickOnLink(btnAcknowledgeConfirm[0]);
                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("//div[contains(@class, 'collapse show')]"));
                VerifyAlertDealDetails(true);
            }
        }

        public void ReplyAlert(bool status, string brokerUsername, string reply = null, string lenderNote = null)
        {
            UIHelperAndroid.ScrollToElement(androidDriver, divAppDealDetails);
            UIHelperAndroid.ClickOnLink(btnReply);
            UIHelperAndroid.WaitForElementVisible(modalAcknowledgeReply, 15);
            IList<IWebElement> btnReplyCancelSubmit = new List<IWebElement>(androidDriver.FindElement(By.XPath("//div[contains(@class, 'collapse show')]")).FindElements(By.TagName("button")));
            IList<IWebElement> lblReply = new List<IWebElement>(androidDriver.FindElement(By.XPath("//div[contains(@class, 'collapse show')]")).FindElements(By.TagName("label")));
            IWebElement txtReply = androidDriver.FindElement(By.XPath("//div[contains(@class, 'collapse show')]")).FindElement(By.TagName("textarea"));
            
            Assert.True(btnReplyCancelSubmit[0].Displayed && btnReplyCancelSubmit[0].Enabled, "Alert reply Cancel button is not displayed");
            Assert.True(btnReplyCancelSubmit[1].Displayed && btnReplyCancelSubmit[1].Enabled, "Alert reply Submit button is not displayed");
            Assert.True(btnReplyCancelSubmit[0].Text.Equals("Cancel"));
            Assert.True(btnReplyCancelSubmit[1].Text.Equals("Submit"));
            Assert.True(lblReply[1].Displayed, "Alert reply character count label is not displayed");
            Assert.True(lblReply[1].Text.Equals("0 / 1000 characters"));
            Assert.True(txtReply.Displayed, "Alert reply text area is not displayed");

            if (status)
            {
                UIHelperAndroid.EnterText(txtReply, reply);
                UIHelperAndroid.ClickOnLink(btnReplyCancelSubmit[1]);
                UIHelperAndroid.WaitForSpinnerInvisible(30);
                VerifyAlertDealDetails(false);
                UIHelperAndroid.WaitUntillExpectedTableEntry(tblNotes, 2, 1, 30);
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, reply, 1, 1));
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, brokerUsername, 1, 0));
                IWebElement tblNotesDate1 = tblNotes.FindElements(By.TagName("tr"))[1].FindElements(By.TagName("td"))[2];
                Assert.True(tblNotesDate1.Text.Length > 0);
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, lenderNote, 1, 1));
            }
            else
            {
                UIHelperAndroid.ClickOnLink(btnReplyCancelSubmit[0]);
                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("//div[contains(@class, 'collapse show')]"));
                VerifyAlertDealDetails(true);
            }
        }

        public void ReplyAlertWithoutScroll(bool status, string brokerUsername, string reply = null, string lenderNote = null)
        {
            UIHelperAndroid.ClickOnLink(btnReply);
            UIHelperAndroid.WaitForElementVisible(modalAcknowledgeReply, 15);
            IList<IWebElement> btnReplyCancelSubmit = new List<IWebElement>(androidDriver.FindElement(By.XPath("//div[contains(@class, 'collapse show')]")).FindElements(By.TagName("button")));
            IList<IWebElement> lblReply = new List<IWebElement>(androidDriver.FindElement(By.XPath("//div[contains(@class, 'collapse show')]")).FindElements(By.TagName("label")));
            IWebElement txtReply = androidDriver.FindElement(By.XPath("//div[contains(@class, 'collapse show')]")).FindElement(By.TagName("textarea"));

            Assert.True(btnReplyCancelSubmit[0].Displayed && btnReplyCancelSubmit[0].Enabled, "Alert reply Cancel button is not displayed");
            Assert.True(btnReplyCancelSubmit[1].Displayed && btnReplyCancelSubmit[1].Enabled, "Alert reply Submit button is not displayed");
            Assert.True(btnReplyCancelSubmit[0].Text.Equals("Cancel"));
            Assert.True(btnReplyCancelSubmit[1].Text.Equals("Submit"));
            Assert.True(lblReply[1].Displayed, "Alert reply character count label is not displayed");
            Assert.True(lblReply[1].Text.Equals("0 / 1000 characters"));
            Assert.True(txtReply.Displayed, "Alert reply text area is not displayed");

            if (status)
            {
                UIHelperAndroid.EnterText(txtReply, reply);
                UIHelperAndroid.ClickOnLink(btnReplyCancelSubmit[1]);
                UIHelperAndroid.WaitForSpinnerInvisible(30);
                VerifyAlertDealDetails(false);
                UIHelperAndroid.WaitUntillExpectedTableEntry(tblNotes, 2, 1, 30);
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, reply, 1, 1));
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, brokerUsername, 1, 0));
                IWebElement tblNotesDate1 = tblNotes.FindElements(By.TagName("tr"))[1].FindElements(By.TagName("td"))[2];
                Assert.True(tblNotesDate1.Text.Length > 0);
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, lenderNote, 1, 1));
            }
            else
            {
                UIHelperAndroid.ClickOnLink(btnReplyCancelSubmit[0]);
                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("//div[contains(@class, 'collapse show')]"));
                VerifyAlertDealDetails(true);
            }
        }

        public void NewNote(bool status, string brokerUsername, string note = null)
        {
            UIHelperAndroid.ScrollToElement(androidDriver, divActionRequired);
            UIHelperAndroid.ClickOnLink(btnNewNote);
            UIHelperAndroid.WaitForElementVisible(modalNewNote, 15);
            UIHelperAndroid.ScrollToElement(androidDriver, btnNewNote);
            IList<IWebElement> btnNewNoteCancelSend = new List<IWebElement>(androidDriver.FindElement(By.Id("newNote")).FindElements(By.TagName("button")));
            IList<IWebElement> lblNewNote = new List<IWebElement>(androidDriver.FindElement(By.Id("newNote")).FindElements(By.TagName("label")));
            IWebElement txtNewNote = androidDriver.FindElement(By.Id("newNote")).FindElement(By.TagName("textarea"));

            Assert.True(btnNewNoteCancelSend[0].Displayed && btnNewNoteCancelSend[0].Enabled, "New Note Cancel button is not displayed");
            Assert.True(btnNewNoteCancelSend[1].Displayed && btnNewNoteCancelSend[1].Enabled, "New Note Send Note button is not displayed");
            Assert.True(btnNewNoteCancelSend[0].Text.Equals("Cancel"));
            Assert.True(btnNewNoteCancelSend[1].Text.Equals("Send Note"));
            Assert.True(lblNewNote[3].Displayed, "New Note character count label is not displayed");
            Assert.True(lblNewNote[3].Text.Equals("0 / 1000 characters"));
            Assert.True(txtNewNote.Displayed, "New Note text area is not displayed");

            if (status)
            {
                UIHelperAndroid.EnterText(txtNewNote, note);
                UIHelperAndroid.ClickOnLink(btnNewNoteCancelSend[1]);
                UIHelperAndroid.WaitForSpinnerInvisible(30);
                UIHelperAndroid.WaitUntillExpectedTableEntry(tblNotes, 1, 1, 30);
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, note, 1, 1));
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, brokerUsername, 1, 0));

                IWebElement tblNotesDate1 = tblNotes.FindElements(By.TagName("tr"))[1].FindElements(By.TagName("td"))[2];
                Assert.True(tblNotesDate1.Text.Length > 0);
            }
            else
            {
                UIHelperAndroid.ClickOnLink(btnNewNoteCancelSend[0]);
                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("//div[contains(@class, 'collapse show')]"));
            }
        }

        public void NewNoteWithoutScroll(bool status, string brokerUsername, string note = null)
        {
            UIHelperAndroid.ScrollToElement(androidDriver, lblLenderRefNo);
            UIHelperAndroid.ClickOnLink(btnNewNote);
            UIHelperAndroid.WaitForElementVisible(modalNewNote, 15);
            UIHelperAndroid.ScrollToElement(androidDriver, btnNewNote);
            IList<IWebElement> btnNewNoteCancelSend = new List<IWebElement>(androidDriver.FindElement(By.Id("newNote")).FindElements(By.TagName("button")));
            IList<IWebElement> lblNewNote = new List<IWebElement>(androidDriver.FindElement(By.Id("newNote")).FindElements(By.TagName("label")));
            IWebElement txtNewNote = androidDriver.FindElement(By.Id("newNote")).FindElement(By.TagName("textarea"));

            Assert.True(btnNewNoteCancelSend[0].Displayed && btnNewNoteCancelSend[0].Enabled, "New Note Cancel button is not displayed");
            Assert.True(btnNewNoteCancelSend[1].Displayed && btnNewNoteCancelSend[1].Enabled, "New Note Send Note button is not displayed");
            Assert.True(btnNewNoteCancelSend[0].Text.Equals("Cancel"));
            Assert.True(btnNewNoteCancelSend[1].Text.Equals("Send Note"));
            Assert.True(lblNewNote[3].Displayed, "New Note character count label is not displayed");
            Assert.True(lblNewNote[3].Text.Equals("0 / 1000 characters"));
            Assert.True(txtNewNote.Displayed, "New Note text area is not displayed");

            if (status)
            {
                UIHelperAndroid.EnterText(txtNewNote, note);
                UIHelperAndroid.ClickOnLink(btnNewNoteCancelSend[1]);
                UIHelperAndroid.WaitForSpinnerInvisible(30);
                UIHelperAndroid.WaitUntillExpectedTableEntry(tblNotes, 1, 1, 30);
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, note, 1, 1));
                Assert.True(UIHelperAndroid.SearchBPNotesGridAndVerify(tblNotes, brokerUsername, 1, 0));

                IWebElement tblNotesDate1 = tblNotes.FindElements(By.TagName("tr"))[1].FindElements(By.TagName("td"))[2];
                Assert.True(tblNotesDate1.Text.Length > 0);
            }
            else
            {
                UIHelperAndroid.ClickOnLink(btnNewNoteCancelSend[0]);
                UIHelperAndroid.WaitForElementInvisible(15, By.XPath("//div[contains(@class, 'collapse show')]"));
            }
        }

        public void VerifyDealDetails(string fctUrn, string Lender, string propertyAddress, string lenderRefNo = null, string closingDate = null)
        {
            UIHelperAndroid.ScrollToElement(androidDriver, androidDriver.FindElement(By.XPath("//label[@class='subheader2-label']")));
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'Closing Date')]")), "Closing Date label not found");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'FCT Reference No.')]")), "FCT Reference No. label not found");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'Lender Name')]")), "Lender Name label not found");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'Mortgagor(s)')]")), "Mortgagor(s) label not found");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'Address(es)')]")), "Address(es) label not found");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'Lender Reference No.')]")), "Lender Reference No. label not found");

            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'" + closingDate + "')]")), "Closing Date value does not match");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'" + fctUrn + "')]")), "FCT Reference No. value does not match");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'" + Lender + "')]")), "Lender Name value does not match");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'" + propertyAddress + "')]")), "Address(es) value does not match");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'" + lenderRefNo + "')]")), "Lender Reference No. value does not match");
        }

        public void VerifyMortgagorDealDetails(string mortgagor)
        {
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//label[contains(text(),'" + mortgagor + "')]")), "Mortgagor(s) value does not match");
        }

        public void VerifyMMSMilestones()
        {
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Deal received')]")), "Deal received milestone label is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Solicitor instructed')]")), "Solicitor instructed milestone label is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Broker conditions met')]")), "Broker conditions met milestone label is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Funded')]")), "Funded milestone label is not available");
        }

        public void VerifyMotionMilestones()
        {
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Deal received')]")), "Deal received milestone label is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Statements ordered')]")), "Statements ordered milestone label is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Statements received')]")), "Statements received milestone label is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Signing appointment booked')]")), "Signing appointment booked milestone label is not available");
            Assert.True(UIHelperAndroid.IsElementDisplayed(By.XPath("//span[contains(text(),'Funded')]")), "Funded milestone label is not available");
        }

        public void VerifyMMSMilestoneStatus(string milestone, bool status, string milestoneDate = null)
        {
            switch (milestone.ToUpper())
            {
                case "DEAL RECEIVED":
                    if (status)
                    {
                        Assert.True(statDealReceivedMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statDealReceivedMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statDealReceivedMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statDealReceivedMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                case "SOLICITOR INSTRUCTED":
                    if (status)
                    {
                        Assert.True(statSolInstrMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statSolInstrMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statSolInstrMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statSolInstrMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                case "BROKER CONDITIONS MET":
                    if (status)
                    {
                        Assert.True(statBrokerCondMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statBrokerCondMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statBrokerCondMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statBrokerCondMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                case "FUNDED":
                    if (status)
                    {
                        Assert.True(statFundedMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statFundedMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statFundedMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statFundedMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                default:
                    break;
            }
        }

        public void VerifyMotionMilestoneStatus(string milestone, bool status, string milestoneDate = null)
        {
            switch (milestone.ToUpper())
            {
                case "DEAL RECEIVED":
                    if (status)
                    {
                        Assert.True(statDealReceivedMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statDealReceivedMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statDealReceivedMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statDealReceivedMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                case "STATEMENTS ORDERED":
                    if (status)
                    {
                        Assert.True(statStatementOrdMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statStatementOrdMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statStatementOrdMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statStatementOrdMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                case "STATEMENTS RECEIVED":
                    if (status)
                    {
                        Assert.True(statStatementRcvMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statStatementRcvMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statStatementRcvMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statStatementRcvMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                case "SIGNING APPOINTMENT BOOKED":
                    if (status)
                    {
                        Assert.True(statSigningApptMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statSigningApptMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statSigningApptMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statSigningApptMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                case "FUNDED":
                    if (status)
                    {
                        Assert.True(statFundedMotionMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statFundedMotionMilestone.FindElement(By.XPath("//div[contains(@class, 'bs-wizard-dot')]")).GetAttribute("title").Equals(milestoneDate));
                    }
                    else
                    {
                        Assert.False(statFundedMotionMilestone.GetAttribute("class").Contains("complete"));
                        Assert.True(statFundedMotionMilestone.GetAttribute("class").Contains("disabled"));
                    }
                    break;

                default:
                    break;
            }
        }

        public void VerifyBPAckNotesGrid(IWebElement Table, String verify, int rowNumber, int columnNumber)
        {
            IList<IWebElement> allRows = Table.FindElements(By.TagName("tr"));
            int rowCount = allRows.Count;
            IList<IWebElement> Columns = allRows[rowNumber].FindElements(By.TagName("td"));

            if (rowCount > 1)
            {
                Assert.True(Columns[columnNumber].Text.Contains(verify));
            }
            else
            {
                Assert.True(rowCount > 1, "Table contains no data");
            }
        }

        public void VerifyBPNoteGrid(int rowNumber, string user, string note, string date, string brokerName = null, string noteType = null)
        {
            if (noteType == null)
            {
                VerifyBPAckNotesGrid(tblNotes, user, rowNumber, 0);
                VerifyBPAckNotesGrid(tblNotes, note, rowNumber, 1);
                VerifyBPAckNotesGrid(tblNotes, date, rowNumber, 2);
            }
            else
            {
                VerifyBPAckNotesGrid(tblNotes, user, rowNumber, 0);
                VerifyBPAckNotesGrid(tblNotes, note + "(Acknowledged - " + brokerName + " - " + date + ", ", rowNumber, 1);
                VerifyBPAckNotesGrid(tblNotes, date, rowNumber, 2);
            }
        }
    }
}
