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
    public class MotionPropertyPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "tabEncumbrance")]
        public IWebElement btnEncumbranceTab;

        [FindsBy(How = How.Id, Using = "tabPayoutFacility")]
        public IWebElement btnPayoutFacilityTab;

        [FindsBy(How = How.Id, Using = "txtPayoutPayoutOrderdDate")]
        public IWebElement txtPayoutOrderdDate;

        [FindsBy(How = How.Id, Using = "txtPayoutPayoutReceivedDate")]
        public IWebElement txtPayoutReceivedDate;

        [FindsBy(How = How.Id, Using = "txtPayoutActualPayoutAmt")]
        public IWebElement txtActualPayoutAmt;

        [FindsBy(How = How.Id, Using = "txtPayoutActualPayoutAmtRecvd")]
        public IWebElement txtActualPayoutAmtRecvd;

        [FindsBy(How = How.Id, Using = "cmdSave")]
        public IWebElement btnSave;

        public void SaveMotionDeal()
        {
            UIHelper.SwitchToWindowbyTitle(20, 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
            UIHelper.SwitchToFrame(30, By.Name("fraUtilityBar"));
            UIHelper.ClickOnLink(btnSave);
            UIHelper.WaitForPageLoad(15);
        }

        //public void PropertySwitchToTab(string tabName)
        //{
        //    switch (tabName)
        //    {
        //        case "Encumbrances":
        //            Thread.Sleep(6000);
        //            UIHelper.SwitchToWindow(30, 1);
        //            UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            UIHelper.ClickOnLink(btnEncumbranceTab);
        //            UIHelper.WaitForPageLoad(30);
        //            UIHelper.SwitchToAlertWindow(15, true);
        //            UIHelper.SwitchToWindow(30, 1);
        //            UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            Assert.True(UIHelper.IsElementDisplayed(By.Id("cboDebtType")));
        //            break;

        //        default:
        //            break;
        //    }
        //}

        public void PropertySwitchToTab(string tabName, string dealID)
        {
            switch (tabName)
            {
                case "Encumbrances":
                    Thread.Sleep(2000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabEncumbrance"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");

                    UIHelper.ClickOnLink(btnEncumbranceTab);
                    UIHelper.WaitForPageLoad(30);
                    UIHelper.SwitchToAlertWindow(15, true);

                    UIHelper.ReTargetLastWindowWithFrame(By.Id("cboDebtType"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("cboDebtType")));
                    break;

                default:
                    break;
            }
        }

        //public void PropertySwitchToSubTab(string tabName)
        //{
        //    switch (tabName)
        //    {
        //        case "Payout Facility":
        //            Thread.Sleep(6000);
        //            UIHelper.SwitchToWindow(30, 1);
        //            UIHelper.SwitchToFrame(30, By.Name("fraDetails"));
        //            UIHelper.ClickOnLink(btnPayoutFacilityTab);
        //            UIHelper.WaitForPageLoad(30);
        //            Assert.True(UIHelper.IsElementDisplayed(By.Id("txtPayoutPayoutOrderdDate")));
        //            break;

        //        default:
        //            break;
        //    }
        //}

        public void PropertySwitchToSubTab(string tabName, string dealID)
        {
            switch (tabName)
            {
                case "Payout Facility":
                    Thread.Sleep(2000);
                    UIHelper.ReTargetLastWindowWithFrame(By.Id("tabPayoutFacility"), By.Name("fraDetails"), 2, "Ref. " + dealID + " : Motion");

                    UIHelper.ClickOnLink(btnPayoutFacilityTab);
                    UIHelper.WaitForPageLoad(30);
                    Assert.True(UIHelper.IsElementDisplayed(By.Id("txtPayoutPayoutOrderdDate")));
                    break;

                default:
                    break;
            }
        }

        public void SetUnsetPayoutOrdered(bool isSet)
        {
            UIHelper.SetUnsetDateIE(txtPayoutOrderdDate, isSet);
            SaveMotionDeal();
        }

        public void SetUnsetPayoutReceived(bool isSet)
        {
            UIHelper.SetUnsetDateIE(txtPayoutReceivedDate, isSet);
            SaveMotionDeal();
        }
    }
}
