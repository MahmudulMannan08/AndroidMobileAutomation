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
    public class MotionSLAPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "cmdAdd")]
        public IWebElement btnAddSLA;

        [FindsBy(How = How.Id, Using = "cmdSave")]
        public IWebElement btnSave;

        public void SaveMotionDeal()
        {
            UIHelper.SwitchToWindowbyTitle(20, 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
            UIHelper.SwitchToFrame(30, By.Name("fraUtilityBar"));
            UIHelper.ClickOnLink(btnSave);
            UIHelper.WaitForPageLoad(15);
        }

        public void AddSLAMotion()
        {
            UIHelper.ClickOnLink(btnAddSLA);
            SaveMotionDeal();
        }
    }
}
