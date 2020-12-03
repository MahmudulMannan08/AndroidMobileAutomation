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
    public class MotionMortgagorPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "cmdAdd")]
        public IWebElement btnAdd;

        [FindsBy(How = How.Id, Using = "cboMortgagorType")]
        public IWebElement ddlMortgagorType;

        [FindsBy(How = How.Id, Using = "txtMortgagorFirstName")]
        public IWebElement txtMortgagorFirstName;

        [FindsBy(How = How.Id, Using = "txtMortgagorLastName")]
        public IWebElement txtMortgagorLastName;

        [FindsBy(How = How.Id, Using = "txtCorporationName")]
        public IWebElement txtCompanyName;

        [FindsBy(How = How.Id, Using = "cmdSave")]
        public IWebElement btnSave;

        public void VerifyPageReady()
        {
            int trial = 0;

            while (trial < 5)
            {

            }
        }

        public void SaveMotionDeal()
        {
            UIHelper.SwitchToWindowbyTitle(20, 2, "Ref. " + MotionHome_Steps.fctUrnMotion + " : Motion");
            UIHelper.SwitchToFrame(30, By.Name("fraUtilityBar"));
            UIHelper.ClickOnLink(btnSave);
            UIHelper.WaitForPageLoad(15);
        }

        public void UpdateMotionMortgagor(string mortgagorType, string companyName = null, string mortgagorFirst = null, string mortgagorLast = null)
        {
            UIHelper.SelectDirectComboElement(ddlMortgagorType, driver.FindElement(By.XPath("//option[contains(text(),'" + mortgagorType + "')]")));

            switch (mortgagorType)
            {
                case "Business":
                    //UIHelper.WaitForElementVisible(txtCompanyName, 10);
                    UIHelper.WaitForElementVisibleEC(By.Id("txtCorporationName"), 10);
                    UIHelper.EnterText(txtCompanyName, companyName);
                    break;

                case "Person":
                    //UIHelper.WaitForElementVisible(txtMortgagorFirstName, 10);
                    UIHelper.WaitForElementVisibleEC(By.Id("txtMortgagorFirstName"), 10);
                    UIHelper.EnterText(txtMortgagorFirstName, mortgagorFirst);
                    UIHelper.EnterText(txtMortgagorLastName, mortgagorLast);
                    break;

                default:
                    break;
            }

            SaveMotionDeal();
        }

        public void AddMotionMortgagor(string mortgagorType, string companyName = null, string mortgagorFirst = null, string mortgagorLast = null)
        {
            UIHelper.ClickOnLink(btnAdd);
            UpdateMotionMortgagor(mortgagorType, companyName, mortgagorFirst, mortgagorLast);
        }
    }
}
