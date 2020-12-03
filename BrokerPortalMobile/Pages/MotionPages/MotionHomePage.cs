using AutoIt;
using BrokerPortalMobile.Steps.MotionSteps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MotionPages
{
    public class MotionHomePage : TestBase
    {
        [FindsBy(How = How.Id, Using = "cboUsers")]
        public IWebElement ddlUser;

        [FindsBy(How = How.XPath, Using = "//input[contains(@name, 'txtSearchID')]")]
        public IWebElement txtSearchID;

        [FindsBy(How = How.XPath, Using = "//input[contains(@value, 'Go!')]")]
        public IWebElement btnGo;

        [FindsBy(How = How.XPath, Using = "//img[contains(@alt, 'New Order')]")]
        public IWebElement btnNewOrder;

        [FindsBy(How = How.Id, Using = "click1_RFIASSIGN")]
        public IWebElement btnOrderApprove;

        [FindsBy(How = How.Id, Using = "click1_RFIAPPROV")]
        public IWebElement btnOrderSearch;

        [FindsBy(How = How.Id, Using = "pageNav")]
        public IWebElement trPageNavigation;

        [FindsBy(How = How.Id, Using = "cmdApprove")]
        public IWebElement btnApprove;

        [FindsBy(How = How.Id, Using = "tabLender")]
        public IWebElement btnLenderTab;

        [FindsBy(How = How.Id, Using = "tabNotes")]
        public IWebElement btnNotesTab;

        [FindsBy(How = How.Id, Using = "tabProperty")]
        public IWebElement btnPropertyTab;

        [FindsBy(How = How.Id, Using = "tabMortgagor")]
        public IWebElement btnMortgagorTab;

        [FindsBy(How = How.Id, Using = "tabFunding")]
        public IWebElement btnFundingTab;

        [FindsBy(How = How.Id, Using = "tabSLA")]
        public IWebElement btnSLATab;

        [FindsBy(How = How.Id, Using = "cmdHoldDeal")]
        public IWebElement btnHoldDeal;

        [FindsBy(How = How.Id, Using = "cmdAdd")]
        public IWebElement btnAddDelayReason;

        [FindsBy(How = How.XPath, Using = "//input[@name='cmdSubmit']")]
        public IWebElement btnSaveDelayReason;

        [FindsBy(How = How.XPath, Using = "//textarea[@name='txtResponse']")]
        public IWebElement txtHoldReason;

        [FindsBy(How = How.XPath, Using = "//input[@name='cmdOK']")]
        public IWebElement btnOKHoldReason;

        [FindsBy(How = How.Id, Using = "cmdCancelDeal")]
        public IWebElement btnCancelDeal;

        public void SelectTitleOfficer(string titleOfficer)
        {
            UIHelper.SwitchToFrame(30, By.Id("fraToolbar"));
            UIHelper.SelectDirectComboElement(ddlUser, driver.FindElement(By.XPath("//option[contains(text(),'" + titleOfficer + "')]")));
            UIHelper.WaitForPageLoad(30);
        }

        //public void SearchMotionDeal(string dealID)
        //{
        //    UIHelper.SwitchToFrame(30, By.Id("fraToolbar"));
        //    UIHelper.EnterText(txtSearchID, dealID);
        //    UIHelper.ClickOnLink(btnGo);
        //    Thread.Sleep(6000);
        //    UIHelper.SwitchToWindowIE(25, 1);
        //    //UIHelper.SwitchToWindow(25, 1);
        //    //driver.SwitchTo().Window(driver.WindowHandles.Last());
        //}

        public void SearchMotionDeal(string dealID)
        {
            UIHelper.SwitchToFrame(30, By.Id("fraToolbar"));
            UIHelper.EnterText(txtSearchID, dealID);
            UIHelper.ClickOnLink(btnGo);
            Thread.Sleep(6000);
            UIHelper.SwitchToWindowbyTitle(25, 2, "Ref. " + dealID + " : Motion");
        }

        public void ClickNewOrder()
        {
            UIHelper.ClickOnLink(btnNewOrder);
        }

        public void SearchGridMotion(By locator)
        {
            Actions actions = new Actions(driver);
            int trial = 0;

            while (trial < 5)
            {
                if (driver.FindElements(locator).Count > 0)
                {
                    IWebElement dealElement = driver.FindElement(locator);
                    UIHelper.ScrollToElement(driver, dealElement);
                    actions.Click(dealElement).Click(dealElement).Perform();
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    trial++;

                    driver.SwitchTo().DefaultContent();
                    UIHelper.SwitchToFrame(30, By.Id("fraMotion"));
                    UIHelper.SwitchToFrame(30, By.Name("fraUtilityBar"));
                    UIHelper.ClickOnLink(btnOrderApprove);

                    driver.SwitchTo().DefaultContent();
                    UIHelper.SwitchToFrame(30, By.Id("fraMotion"));
                    UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
                    UIHelper.SwitchToFrame(30, By.Name("fraDetailGrid"));
                    UIHelper.WaitForElementVisible(trPageNavigation, 15);
                    UIHelper.PageNavigationMotion(driver.FindElement(By.Id("pageNav")), 2);
                    Thread.Sleep(1000);
                }
            }
        }

        public void LocateMotionDeal(string mortgagorFirst, string mortgagorLast)
        {
            Thread.Sleep(4000);   //Waiting for deal to be available in Motion
            UIHelper.SwitchToFrame(30, By.Id("fraMotion"));
            UIHelper.SwitchToFrame(30, By.Name("fraUtilityBar"));
            UIHelper.ClickOnLink(btnOrderApprove);

            driver.SwitchTo().DefaultContent();
            UIHelper.SwitchToFrame(30, By.Id("fraMotion"));
            UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
            UIHelper.SwitchToFrame(30, By.Name("fraDetailGrid"));
            UIHelper.WaitForElementVisible(trPageNavigation, 15);
            UIHelper.PageNavigationMotion(driver.FindElement(By.Id("pageNav")), 2);
            Thread.Sleep(1000);

            SearchGridMotion(By.XPath("//span[contains(text(),'" + mortgagorFirst + " " + mortgagorLast + "')]"));
            //UIHelper.SearchGridMotion(driver.FindElement(By.Id("objGrid_Body")), mortgagorFirst + " " + mortgagorLast);
            Thread.Sleep(3000);
        }

        //public string GetFctUrnMotion()
        //{
        //    Thread.Sleep(8000);
        //    //driver.SwitchTo().Window(driver.WindowHandles.Last());
        //    UIHelper.SwitchToWindowIE(25, 1);
        //    Thread.Sleep(1000);
        //    //UIHelper.WaitForElementClickable(driver.FindElement(By.Id("divRFI")), 25);
        //    UIHelper.WaitForElementVisibleEC(By.Id("divRFI"), 10);
        //    UIHelper.ReTargetLastWindow(By.Id("divRFI"), 1);

        //    UIHelper.WaitForFrameAndSwitch(By.Id("IFrameRFI"), 25);
        //    Thread.Sleep(2000);
        //    UIHelper.WaitForFrameAndSwitch(By.Id("IFrameRFI"), 25);
        //    Thread.Sleep(2000);

        //    var dealData = driver.FindElement(By.TagName("textarea")).GetAttribute("value");
        //    dealData = dealData.Substring(dealData.IndexOf("FCTURN:"));
        //    dealData = dealData.Replace("\r\n", " ").Trim();
        //    var dealDataSplit = dealData.Split(' ');

        //    driver.Close();
        //    UIHelper.SwitchToBaseWindow();

        //    return dealDataSplit[1];
        //}

        public string GetFctUrnMotion()
        {
            Thread.Sleep(8000);
            UIHelper.SwitchToWindowbyTitle(25, 2, "View RFI");
            UIHelper.WaitForElementVisibleEC(By.Id("divRFI"), 10);

            UIHelper.WaitForFrameAndSwitch(By.Id("IFrameRFI"), 25);
            Thread.Sleep(2000);
            UIHelper.WaitForFrameAndSwitch(By.Id("IFrameRFI"), 25);
            Thread.Sleep(2000);

            var dealData = driver.FindElement(By.TagName("textarea")).GetAttribute("value");
            dealData = dealData.Substring(dealData.IndexOf("FCTURN:"));
            dealData = dealData.Replace("\r\n", " ").Trim();
            var dealDataSplit = dealData.Split(' ');

            driver.Close();
            UIHelper.SwitchToBaseWindow();

            return dealDataSplit[1];
        }

        //public void MotionSwitchToTab(string tabName)
        //{
        //    switch (tabName)
        //    {
        //        case "Lender":
        //            //Thread.Sleep(6000);
        //            UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 20);
        //            Thread.Sleep(1000);
        //            UIHelper.WaitForElementClickable(btnLenderTab, 15);
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("tabLender"), By.Name("fraDetails"), 1);

        //            UIHelper.ClickOnLink(btnLenderTab);
        //            UIHelper.WaitForPageLoad(30);
        //            //UIHelper.SwitchToWindow(30, 1);
        //            //UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("txtApptDate"), By.Name("fraDetails"), 1);
        //            Assert.True(UIHelper.IsElementDisplayed(By.Id("txtApptDate")));
        //            break;

        //        case "Notes":
        //            Thread.Sleep(6000);
        //            driver.SwitchTo().Window(driver.WindowHandles.Last());
        //            Thread.Sleep(1000);
        //            UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 5);
        //            Thread.Sleep(1000);
        //            //UIHelper.WaitForElementClickable(btnNotesTab, 15);
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("tabNotes"), By.Name("fraDetails"), 1);

        //            UIHelper.ClickOnLink(btnNotesTab);
        //            UIHelper.WaitForPageLoad(30);
        //            //UIHelper.SwitchToWindow(30, 1);
        //            //UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            UIHelper.ReTargetLastWindowWithFrame(By.XPath("//b[contains(text(),'System Log')]"), By.Name("fraDetails"), 1);
        //            Assert.True(UIHelper.IsElementDisplayed(By.XPath("//b[contains(text(),'System Log')]")));
        //            break;

        //        case "Property":
        //            Thread.Sleep(6000);
        //            driver.SwitchTo().Window(driver.WindowHandles.Last());
        //            Thread.Sleep(1000);
        //            UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 5);
        //            Thread.Sleep(1000);
        //            //UIHelper.WaitForElementClickable(btnPropertyTab, 15);
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("tabProperty"), By.Name("fraDetails"), 1);

        //            UIHelper.ClickOnLink(btnPropertyTab);
        //            UIHelper.WaitForPageLoad(30);
        //            //UIHelper.SwitchToWindow(30, 1);
        //            //UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("txtLegalDescription"), By.Name("fraDetails"), 1);
        //            Assert.True(UIHelper.IsElementDisplayed(By.Id("txtLegalDescription")));
        //            break;

        //        case "Mortgagor":
        //            Thread.Sleep(6000);
        //            driver.SwitchTo().Window(driver.WindowHandles.Last());
        //            Thread.Sleep(1000);
        //            UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 5);
        //            Thread.Sleep(1000);
        //            //UIHelper.WaitForElementClickable(btnMortgagorTab, 15);
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("tabMortgagor"), By.Name("fraDetails"), 1);

        //            UIHelper.ClickOnLink(btnMortgagorTab);
        //            UIHelper.WaitForPageLoad(30);
        //            //UIHelper.SwitchToWindow(30, 1);
        //            //UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("tabMortgagor"), By.Name("fraDetails"), 1);
        //            Assert.True(UIHelper.IsElementDisplayed(By.Id("cboMortgagorType")));
        //            break;

        //        case "Funding":
        //            Thread.Sleep(8000);
        //            driver.SwitchTo().Window(driver.WindowHandles.Last());
        //            Thread.Sleep(1000);
        //            UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 5);
        //            Thread.Sleep(1000);
        //            //UIHelper.WaitForElementClickable(btnFundingTab, 15);
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("tabFunding"), By.Name("fraDetails"), 1);

        //            UIHelper.ClickOnLink(btnFundingTab);
        //            UIHelper.WaitForPageLoad(30);
        //            //UIHelper.SwitchToWindow(30, 1);
        //            //UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 30);
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("tabFundingDetails"), By.Name("fraDetails"), 1);
        //            Assert.True(UIHelper.IsElementDisplayed(By.Id("tabFundingDetails")));
        //            break;

        //        case "SLA":
        //            Thread.Sleep(3000);
        //            driver.SwitchTo().Window(driver.WindowHandles.Last());
        //            Thread.Sleep(1000);
        //            UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 10);
        //            Thread.Sleep(1000);
        //            //UIHelper.WaitForElementClickable(btnSLATab, 15);
        //            UIHelper.ReTargetLastWindowWithFrame(By.Id("tabSLA"), By.Name("fraDetails"), 1);

        //            UIHelper.ClickOnLink(btnSLATab);
        //            UIHelper.WaitForPageLoad(30);
        //            //UIHelper.SwitchToWindow(30, 1);
        //            //UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 30);
        //            UIHelper.ReTargetLastWindowWithFrame(By.XPath("//a[contains(text(),'Select Delay Reason:')]"), By.Name("fraDetails"), 1);
        //            Assert.True(UIHelper.IsElementDisplayed(By.XPath("//a[contains(text(),'Select Delay Reason:')]")));
        //            break;

        //        default:
        //            break;
        //    }
        //}

        public void MotionSwitchToTab(string tabName, string dealID)
        {
            switch (tabName)
            {
                case "Lender":
                    //UIHelper.WaitForFrameAndSwitch(By.Name("fraDetails"), 20);
                    //Thread.Sleep(1000);
                    //UIHelper.WaitForElementClickable(btnLenderTab, 15);
                    Thread.Sleep(2000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabLender"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");

                    UIHelper.ClickOnLink(btnLenderTab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("txtApptDate"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("txtApptDate")));
                    break;

                case "Notes":
                    Thread.Sleep(2000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabNotes"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");

                    UIHelper.ClickOnLink(btnNotesTab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.ReTargetLastWindowWithFrame(By.XPath("//b[contains(text(),'System Log')]"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//b[contains(text(),'System Log')]")));
                    break;

                case "Property":
                    Thread.Sleep(2000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabProperty"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");

                    UIHelper.ClickOnLink(btnPropertyTab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("txtLegalDescription"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("txtLegalDescription")));
                    break;

                case "Mortgagor":
                    Thread.Sleep(2000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabMortgagor"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");

                    UIHelper.ClickOnLink(btnMortgagorTab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabMortgagor"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("cboMortgagorType")));
                    break;

                case "Funding":
                    Thread.Sleep(3000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabFunding"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");

                    UIHelper.ClickOnLink(btnFundingTab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabFundingDetails"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("tabFundingDetails")));
                    break;

                case "SLA":
                    Thread.Sleep(1000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabSLA"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");

                    UIHelper.ClickOnLink(btnSLATab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.ReTargetLastWindowWithFrame(By.XPath("//a[contains(text(),'Select Delay Reason:')]"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    Assert.True(UIHelper.IsElementDisplayed(By.XPath("//a[contains(text(),'Select Delay Reason:')]")));
                    break;

                default:
                    break;
            }
        }

        public void ApproveMotionDeal()
        {
            UIHelper.SwitchToFrame(30, By.Id("fraMotion"));
            UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
            UIHelper.SwitchToFrame(30, By.Name("fraDetailGrid"));
            UIHelper.ClickOnLink(btnApprove);
            UIHelper.SwitchToAlertWindow(10, true);
        }

        //public void HoldUnholdDeal(bool isHold)
        //{
        //    if (isHold)
        //    {
        //        UIHelper.ReTargetLastWindowWithFrame(By.Id("cmdHoldDeal"), By.Name("fraUtilityBar"), 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
        //        UIHelper.ClickOnLink(btnHoldDeal);
        //        Thread.Sleep(5000);

        //        driver.SwitchTo().Window(driver.WindowHandles.Last());
        //        //UIHelper.SwitchToWindowbyTitle(15, 3, "Motion Prompt");
        //        Thread.Sleep(1000);
        //        UIHelper.WaitForElementClickable(btnOKHoldReason, 15);
        //        UIHelper.EnterText(txtHoldReason, "Automated test deal");
        //        UIHelper.ClickOnLink(btnOKHoldReason);
        //        Thread.Sleep(2000);

        //        driver.SwitchTo().Window(driver.WindowHandles.Last());
        //        //UIHelper.SwitchToWindowbyTitle(15, 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
        //        UIHelper.WaitForFrameAndSwitch(By.Name("fraUtilityBar"), 30);
        //        Assert.True(btnHoldDeal.GetAttribute("value").Equals("Remove Hold"));
        //    }
        //    else
        //    {

        //    }
        //}

        public void HoldUnholdDeal(bool isHold)
        {
            if (isHold)
            {
                UIHelper.ReTargetLastWindowWithFrame(By.Id("cmdHoldDeal"), By.Name("fraUtilityBar"), 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
                UIHelper.ClickOnLink(btnHoldDeal);
                Thread.Sleep(2000);

                AutoItX.Send("Automated test deal");
                Thread.Sleep(1000);

                AutoItX.Send("{TAB 2}");
                Thread.Sleep(1000);

                AutoItX.Send("{ENTER}");
                Thread.Sleep(2000);

                //driver.SwitchTo().Window(driver.WindowHandles.Last());
                //UIHelper.WaitForFrameAndSwitch(By.Name("fraUtilityBar"), 30);
                Assert.True(btnHoldDeal.GetAttribute("value").Equals("Remove Hold"));
            }
            else
            {

            }
        }

        public void CancelDeal(string cancelComment)
        {
            //UIHelper.WaitForElementClickable(btnCancelDeal, 15);
            UIHelper.SwitchToFrame(10, By.Id("fraUtilityBar"));
            UIHelper.ReTargetLastWindowWithFrame(By.Id("cmdCancelDeal"), By.Name("fraUtilityBar"), 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
            UIHelper.ClickOnLink(btnCancelDeal);
            Thread.Sleep(3500);

            AutoItX.Send("{TAB}");
            Thread.Sleep(1000);
            AutoItX.Send("{DOWN}");
            Thread.Sleep(1000);

            AutoItX.Send("{TAB}");
            Thread.Sleep(1000);
            AutoItX.Send("" + cancelComment + "");
            Thread.Sleep(1000);

            AutoItX.Send("{TAB}");
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
            Thread.Sleep(6000);

            AutoItX.Send("!{F4}");
            Thread.Sleep(4000);
            AutoItX.Send("!{F4}");
            Thread.Sleep(1000);
        }
    }
}
