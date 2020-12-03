using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MMSPortalPages
{
    public class MMSStatusPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "LeftMenu1_PolicyStatus_txtRFIReceivedDate")]
        public IWebElement txtRFIReceivedDate;

        [FindsBy(How = How.Id, Using = "LeftMenu1_PolicyStatus_txtSolicitorsSent")]
        public IWebElement txtSolicitorInsSent;

        [FindsBy(How = How.Id, Using = "LeftMenu1_PolicyStatus_txtCOIIssued")]
        public IWebElement txtCOIIssued;

        [FindsBy(How = How.Id, Using = "LeftMenu1_PolicyStatus_btnHold")]
        //[FindsBy(How = How.XPath, Using = "//input[@name='LeftMenu1$PolicyStatus$btnHold']")]
        public IWebElement btnHold;

        [FindsBy(How = How.Id, Using = "ddlReason")]
        public IWebElement ddlReason;

        [FindsBy(How = How.Id, Using = "txtReason")]
        public IWebElement txtReason;

        [FindsBy(How = How.Id, Using = "btnYes")]
        public IWebElement btnYes;

        [FindsBy(How = How.Id, Using = "LeftMenu1_PolicyStatus_btnCOI")]
        public IWebElement btnCOI;

        [FindsBy(How = How.Id, Using = "LeftMenu1_PolicyStatus_btnCancel")]
        public IWebElement btnCancelDeal;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'OK')]")]
        public IWebElement btnOK;

        public string VerifyRFIReceivedDate()
        {
            Assert.True(txtRFIReceivedDate.GetAttribute("value").Length > 0, "RFI received date is not populated in MMS");
            
            var rfiReceivedTimeStamp = txtRFIReceivedDate.GetAttribute("value");
            return rfiReceivedTimeStamp.Substring(rfiReceivedTimeStamp.IndexOf(' '));
        }

        public string VerifySolicitorsInsSentDate()
        {
            Assert.True(txtSolicitorInsSent.GetAttribute("value").Length > 0, "Solicitors instruction sent date is not populated in MMS");

            var solicitorsInsSentTimeStamp = txtSolicitorInsSent.GetAttribute("value");
            return solicitorsInsSentTimeStamp.Substring(solicitorsInsSentTimeStamp.IndexOf(' '));
        }

        public void VerifyCOIIssuedDate()
        {
            Assert.True(txtCOIIssued.GetAttribute("value").Length > 0, "COI Issued date is not populated in MMS");
        }

        public void HoldUnholdDeal(bool isHold)
        {
            UIHelper.ClickOnLink(btnHold);
            UIHelper.SwitchToPopup(15, 2);
            Thread.Sleep(1500);

            if (isHold)
            {
                UIHelper.SelectComboElement(ddlReason, "Other");
                UIHelper.EnterText(txtReason, "Automated test deal");
                UIHelper.ClickOnLink(btnYes);
                UIHelper.SwitchToWindow(15, 1);
                UIHelper.WaitForPageLoad(15);
                Assert.True(btnHold.GetAttribute("value").Equals("Release Hold"), "Failed to hold MMS deal");
            }
            else
            {
                UIHelper.SelectComboElement(ddlReason, "Please specify");
                UIHelper.EnterText(txtReason, "Automated test deal");
                UIHelper.ClickOnLink(btnYes);
                UIHelper.SwitchToWindow(15, 1);
                UIHelper.WaitForPageLoad(15);
                UIHelper.WaitUntilElementHasValue(btnHold, "Hold", 15);
                Assert.True(btnHold.GetAttribute("value").Equals("Hold"), "Failed to unhold MMS deal");
            }
        }

        public void IssueCOI()
        {
            UIHelper.ClickOnLink(btnCOI);
            Thread.Sleep(2000);
            UIHelper.WaitForPageLoad(60);
            UIHelper.SwitchToWindow(60, 2);
            UIHelper.ClickOnLink(btnOK);
            UIHelper.SwitchToWindow(15, 1);
            VerifyCOIIssuedDate();
        }

        public void CancelUncancelDeal(bool isCancelled)
        {
            UIHelper.ClickOnLink(btnCancelDeal);
            UIHelper.SwitchToPopup(15, 2);

            if (isCancelled)
            {
                UIHelper.SelectComboElement(ddlReason, "Other");
                UIHelper.EnterText(txtReason, "Automated test deal");
                UIHelper.ClickOnLink(btnYes);
                UIHelper.SwitchToWindow(15, 1);
                UIHelper.WaitForPageLoad(30);
                Assert.True(btnCancelDeal.GetAttribute("value").Equals("Un-Cancel"), "Failed to cancel MMS deal");
            }
            else
            {
                UIHelper.EnterText(txtReason, "Automated test deal");
                UIHelper.ClickOnLink(btnYes);
                UIHelper.SwitchToWindow(15, 1);
                UIHelper.WaitForPageLoad(15);
                Assert.True(btnCancelDeal.GetAttribute("value").Equals("Cancel"), "Failed to un-cancel MMS deal");
            }
        }
    }
}