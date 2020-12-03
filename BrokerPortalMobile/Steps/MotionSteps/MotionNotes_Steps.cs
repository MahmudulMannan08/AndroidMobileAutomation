using BrokerPortalMobile.Pages.MotionPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile.Steps.MotionSteps
{
    [Binding]
    public sealed class MotionNotes_Steps : TestBase
    {
        private readonly ScenarioContext context;
        public static MotionHomePage motionHomePage;
        public static MotionNotesPage motionNotesPage;
        public static MotionLenderPage motionLenderPage;

        public MotionNotes_Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Then(@"I add Motion note with broker alert")]
        public void ThenIAddMotionNoteWithBrokerAlert()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Notes", MotionHome_Steps.fctUrnMotion);

            motionNotesPage = UIHelper.PageInit<MotionNotesPage>(driver);
            motionNotesPage.AddMotionNoteWithWithoutAlert(MotionNote, true, 1);

            motionLenderPage = UIHelper.PageInit<MotionLenderPage>(driver);
            motionLenderPage.SaveMotionDeal();
            Thread.Sleep(4000);
        }

        [Then(@"I add second Motion note with broker alert")]
        public void ThenIAddSecondMotionNoteWithBrokerAlert()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Notes", MotionHome_Steps.fctUrnMotion);

            motionNotesPage = UIHelper.PageInit<MotionNotesPage>(driver);
            motionNotesPage.AddMotionNoteWithWithoutAlert(MotionNote2, true, 2);

            motionLenderPage = UIHelper.PageInit<MotionLenderPage>(driver);
            motionLenderPage.SaveMotionDeal();
            Thread.Sleep(4000);
        }

        [Then(@"I add Motion note without broker alert")]
        public void ThenIAddMotionNoteWithoutBrokerAlert()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Notes", MotionHome_Steps.fctUrnMotion);

            motionNotesPage = UIHelper.PageInit<MotionNotesPage>(driver);
            motionNotesPage.AddMotionNoteWithWithoutAlert(MotionNote, false, 1);

            motionLenderPage = UIHelper.PageInit<MotionLenderPage>(driver);
            motionLenderPage.SaveMotionDeal();
            Thread.Sleep(2000);
        }

        [Then(@"I check broker alert checkbox on Motion note grid")]
        public void ThenICheckBrokerAlertCheckboxOnMotionNoteGrid()
        {
            motionNotesPage.ChkUnchkTableBrAlert(1, "ON");
            motionLenderPage.SaveMotionDeal();
            Thread.Sleep(2000);
        }

        [Then(@"I verify note reply by broker on Motion Portal")]
        public void ThenIVerifyNoteReplyByBrokerOnMotionPortal()
        {
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Notes", MotionHome_Steps.fctUrnMotion);

            motionNotesPage = UIHelper.PageInit<MotionNotesPage>(driver);
            motionNotesPage.VerifyMotionNotesGridForAcknowledgement(1, BrokerAlertReply, BrokerUsername);
        }

        [Then(@"I verify new note by broker on Motion Portal")]
        public void ThenIVerifyNewNoteByBrokerOnMotionPortal()
        {
            Thread.Sleep(2000);
            motionHomePage = UIHelper.PageInit<MotionHomePage>(driver);
            motionHomePage.MotionSwitchToTab("Notes", MotionHome_Steps.fctUrnMotion);

            motionNotesPage = UIHelper.PageInit<MotionNotesPage>(driver);
            motionNotesPage.VerifyMotionNotesGridForNoteByBroker(1, BrokerNewNote, BrokerUsername);
        }
    }
}
