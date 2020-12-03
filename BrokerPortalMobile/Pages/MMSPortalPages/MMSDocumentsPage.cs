using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerPortalMobile.Pages.MMSPortalPages
{
    public class MMSDocumentsPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "LeftMenu1_Documents_cboDocumentType")]
        public IWebElement ddlDocumentType;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Documents_fileUploadControl")]
        public IWebElement txtChooseFile;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Documents_btnSend")]
        public IWebElement btnSend;

        [FindsBy(How = How.Id, Using = "LeftMenu1_Documents_DocumentList_grdDocumentList")]
        public IWebElement tblDocuments;

        public void SendDocumentMMS(string documentTypeOption, string documentPath)
        {
            UIHelper.SelectComboElement(ddlDocumentType, documentTypeOption);
            UIHelper.EnterText(txtChooseFile, documentPath);
            UIHelper.ClickOnLink(btnSend);
            UIHelper.WaitForPageLoad(30);
            UIHelper.WaitUntillExpectedTableEntry(tblDocuments, 2, 1, 15);
            Assert.True(UIHelper.SearchGridAndVerify(driver, tblDocuments, documentTypeOption, 1, 0));
        }
    }
}
