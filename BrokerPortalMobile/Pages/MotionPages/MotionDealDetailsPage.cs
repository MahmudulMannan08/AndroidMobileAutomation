using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoIt;

namespace BrokerPortalMobile.Pages.MotionPages
{
    public class MotionDealDetailsPage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//select[contains(@name, 'cboLenderProgram')]")]
        public IWebElement ddlProgram;

        [FindsBy(How = How.XPath, Using = "//input[contains(@class, 'clsBorderNone')]")]
        public IWebElement btnLenderLogo;

        [FindsBy(How = How.Id, Using = "txtRFIFaxReceiveDate")]
        public IWebElement txtRFIReceivedDate;

        [FindsBy(How = How.Id, Using = "txtMortgageCenterNumber")]
        public IWebElement txtRSCMOSE;

        [FindsBy(How = How.Id, Using = "lblMortgagorInformation_C")]
        public IWebElement lblMortgagorInformation;

        [FindsBy(How = How.Id, Using = "txtMortgagorFirstName")]
        public IWebElement txtMortgagorFirstName;

        [FindsBy(How = How.Id, Using = "txtMortgagorLastName")]
        public IWebElement txtMortgagorLastName;

        [FindsBy(How = How.Id, Using = "txtMortgagorBusinessPhoneNumber")]
        public IWebElement txtMortgagorBusinessPhoneNo;

        [FindsBy(How = How.Id, Using = "txtMortgagorStreetAddress1")]
        public IWebElement txtMortgagorAddress;

        [FindsBy(How = How.Id, Using = "txtMortgagorCity")]
        public IWebElement txtMortgagorCity;

        [FindsBy(How = How.Id, Using = "txtMortgagorProvince")]
        public IWebElement txtMortgagorProvince;

        [FindsBy(How = How.Id, Using = "txtMortgagorPostalCode")]
        public IWebElement txtMortgagorPostalCode;

        [FindsBy(How = How.Id, Using = "txtMortgagorPhone")]
        public IWebElement txtMortgagorServicePhone;

        [FindsBy(How = How.Id, Using = "lblProperty_C")]
        public IWebElement lblProperty;

        [FindsBy(How = How.Id, Using = "txtPropertyLegalDescription")]
        public IWebElement txtPropertyLegalDesc;

        [FindsBy(How = How.Id, Using = "txtPropertyPIN")]
        public IWebElement txtPropertyPIN;

        [FindsBy(How = How.Id, Using = "cboPropertyTypeOfEstate")]
        public IWebElement ddlProprertyTypeOfEstate;

        [FindsBy(How = How.Id, Using = "txtMunicipalAddressUnitNumber")]
        public IWebElement txtPropertyUnitNo;

        [FindsBy(How = How.Id, Using = "txtMunicipalAddressStreetAddress1")]
        public IWebElement txtPropertyAddress;

        [FindsBy(How = How.Id, Using = "txtMunicipalAddressCity")]
        public IWebElement txtPropertyCity;

        [FindsBy(How = How.Id, Using = "cboProvince")]
        public IWebElement ddlPropertyProvince;

        [FindsBy(How = How.Id, Using = "txtMunicipalAddressPostalCode")]
        public IWebElement txtPropertyPostalCode;

        [FindsBy(How = How.Id, Using = "cboMortgageProduct")]
        public IWebElement ddlMortgageProduct;

        [FindsBy(How = How.Id, Using = "txtMortgageNumber")]
        public IWebElement txtMortgageNumber;

        [FindsBy(How = How.Id, Using = "txtAltChannelRefNumber")]
        public IWebElement txtMIMsRefNo;

        [FindsBy(How = How.Id, Using = "txtMortgageClosingDate")]
        public IWebElement txtMortgageClosingDate;

        [FindsBy(How = How.Id, Using = "txtSplitAmount")]
        public IWebElement txtMortgageAmount;

        [FindsBy(How = How.Id, Using = "txtAbvBlwInterestRate")]
        public IWebElement txtPrimeRate;

        [FindsBy(How = How.Id, Using = "lblOrigBranch_C")]
        public IWebElement lblOriginatingBranch;

        [FindsBy(How = How.Id, Using = "txtOriginatingBranchNumber")]
        public IWebElement txtOriginatingBranchNo;

        [FindsBy(How = How.Id, Using = "txtOriginatingBranchContactFirstName")]
        public IWebElement txtOriginatingContactFirst;

        [FindsBy(How = How.Id, Using = "txtOriginatingBranchContactLastName")]
        public IWebElement txtOriginatingContactLast;

        [FindsBy(How = How.Id, Using = "txtOriginatingBranchEmail")]
        public IWebElement txtOriginatingEmail;

        [FindsBy(How = How.Id, Using = "txtSigningBranchNumber")]
        public IWebElement txtSigningBranchNo;

        [FindsBy(How = How.Id, Using = "txtSigningBranchContactFirstName")]
        public IWebElement txtSigningContactFirst;

        [FindsBy(How = How.Id, Using = "txtSigningBranchContactLastName")]
        public IWebElement txtSigningContactLast;

        [FindsBy(How = How.Id, Using = "txtSigningBranchPhoneNumber")]
        public IWebElement txtSigningPhoneNo;

        [FindsBy(How = How.Id, Using = "txtSigningBranchEmail")]
        public IWebElement txtSigningBranchEmail;

        [FindsBy(How = How.Id, Using = "cboSourceOpt")]
        public IWebElement ddlDealSource;

        [FindsBy(How = How.Id, Using = "RFISubmit")]
        public IWebElement btnSubmitForApproval;

        //public void SelectLenderProgram(string programName)
        //{
        //    Thread.Sleep(8000);
        //    //driver.SwitchTo().Window(driver.WindowHandles.Last());
        //    UIHelper.SwitchToWindowIE(25, 1);
        //    Thread.Sleep(2000);
        //    UIHelper.ReTargetLastWindow(By.Id("idLendersList"), 1);
        //    //((IJavaScriptExecutor)driver).ExecuteScript("window.focus();");

        //    UIHelper.WaitForElementClickable(ddlProgram, 15);
        //    UIHelper.SelectComboElement(ddlProgram, programName);
        //    UIHelper.ClickOnLink(btnLenderLogo);
        //    UIHelper.WaitForPageLoad(20);
        //}

        public void SelectLenderProgram(string programName)
        {
            Thread.Sleep(4000);
            UIHelper.SwitchToWindowbyTitle(25, 2, "Select Lender & Program");

            UIHelper.WaitForElementClickable(ddlProgram, 15);
            UIHelper.SelectComboElement(ddlProgram, programName);
            UIHelper.ClickOnLink(btnLenderLogo);
            UIHelper.WaitForPageLoad(20);
        }

        //public void CreateNewOrder(string rfiReceivedDate, string mortgagorFirst, string mortgagorLast, string propertyAddress, string propertyCity, string closingDate)
        //{
        //    //Lender Program
        //    UIHelper.WaitForElementVisible(txtRFIReceivedDate, 20);
        //    UIHelper.EnterTextIE(txtRFIReceivedDate, rfiReceivedDate);

        //    //RSC/MOSE
        //    UIHelper.EnterTextIE(txtRSCMOSE, RSCMOSE);

        //    //Mortgagor Information
        //    AutoItX.Send("{TAB 15}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{M}{o}{r}{t}{F}");
        //    Thread.Sleep(1000);
        //    //UIHelper.EnterTextIE(txtMortgagorFirstName, mortgagorFirst);
        //    AutoItX.Send("{TAB}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{M}{o}{r}{t}{L}");
        //    Thread.Sleep(1000);
        //    //UIHelper.EnterTextIE(txtMortgagorLastName, mortgagorLast);
        //    UIHelper.EnterTextIE(txtMortgagorBusinessPhoneNo, MotionMortgagorBusinessPhoneNo);
        //    UIHelper.EnterTextIE(txtMortgagorAddress, MotionMortgagorAddress);
        //    UIHelper.EnterTextIE(txtMortgagorCity, MotionMortgagorCity);
        //    UIHelper.EnterTextIE(txtMortgagorProvince, MotionMortgagorProvince);
        //    UIHelper.EnterTextIE(txtMortgagorPostalCode, MotionMortgagorPostalCode);
        //    UIHelper.EnterTextIE(txtMortgagorServicePhone, MotionMortgagorServicePhone);

        //    //Property
        //    UIHelper.ScrollToElement(driver, lblProperty);
        //    UIHelper.EnterTextIE(txtPropertyLegalDesc, MotionPropertyLegalDesc);
        //    Thread.Sleep(2000);
        //    //UIHelper.EnterTextIE(txtPropertyPIN, MotionPropertyPIN);
        //    //UIHelper.SelectComboElement(ddlProprertyTypeOfEstate, MotionPropertyTypeOfEstate);
        //    //AutoItX.Send("+{TAB 43}");
        //    AutoItX.Send("{TAB 60}");
        //    Thread.Sleep(4000);
        //    AutoItX.Send("{DOWN}");
        //    Thread.Sleep(1000);

        //    AutoItX.Send("{TAB 6}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{4}{8}{SPACE}{H}{a}{v}{e}{n}{SPACE}{R}{d}");
        //    Thread.Sleep(1000);
        //    //UIHelper.EnterTextIE(txtPropertyAddress, propertyAddress);
        //    AutoItX.Send("{TAB 2}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{T}{o}{r}{o}{n}{t}{o}");
        //    Thread.Sleep(1000);
        //    //UIHelper.EnterTextIE(txtPropertyCity, propertyCity);
        //    UIHelper.EnterTextIE(txtPropertyPostalCode, MotionPropertyPostalCode);

        //    //Mortgage Information
        //    //UIHelper.SelectComboElementIE(ddlMortgageProduct, MotionMortgageProduct);
        //    //AutoItX.Send("{TAB 23}");
        //    AutoItX.Send("{TAB 15}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{DOWN 2}");
        //    Thread.Sleep(2000);
        //    UIHelper.WaitForElementVisible(txtMortgageClosingDate, 5);
        //    AutoItX.Send("{TAB}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{3}{7}{3}{9}{5}{2}{6}");
        //    Thread.Sleep(1000);
        //    //UIHelper.EnterTextIE(txtMortgageNumber, MotionMortgageNumber);
        //    AutoItX.Send("{TAB}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{3}{7}{3}{9}{5}");
        //    Thread.Sleep(1000);
        //    //UIHelper.EnterTextIE(txtMIMsRefNo, MotionMIMsRefNumber);
        //    UIHelper.EnterTextIE(txtMortgageClosingDate, closingDate);
        //    //AutoItX.Send("{TAB}");
        //    //Thread.Sleep(2000);
        //    //AutoItX.Send("{DOWN}");
        //    //Thread.Sleep(1000);
        //    //AutoItX.Send("{T}{h}{u}{ASC &#46;}{SPACE}{M}{a}{y}{.}{SPACE}{1}{3}{,}{SPACE}{2}{0}{2}{1}");
        //    //UIHelper.EnterTextIE(txtMortgageClosingDate, closingDate);
        //    UIHelper.EnterTextIE(txtMortgageAmount, MotionMortgageAmount);

        //    //Originating Branch
        //    UIHelper.ScrollToElement(driver, lblOriginatingBranch);
        //    UIHelper.EnterTextIE(txtOriginatingBranchNo, OriginatingBranchNo);
        //    UIHelper.EnterTextIE(txtOriginatingContactFirst, OriginatingContactFirst);
        //    UIHelper.EnterTextIE(txtOriginatingContactLast, OriginatingContactLast);

        //    //Signing Branch
        //    UIHelper.EnterTextIE(txtSigningBranchNo, SigningBranchNo);
        //    UIHelper.EnterTextIE(txtSigningContactFirst, SigningContactFirst);
        //    UIHelper.EnterTextIE(txtSigningContactLast, SigningContactLast);
        //    UIHelper.EnterTextIE(txtSigningPhoneNo, SigningPhone);

        //    //Lender Remarks
        //    //UIHelper.SelectComboElementIE(ddlDealSource, MotionDealSource);
        //    //AutoItX.Send("{TAB 18}");
        //    AutoItX.Send("{TAB 16}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{DOWN 3}");
        //    Thread.Sleep(1000);

        //    //UIHelper.ClickOnLinkIE(btnSubmitForApproval);
        //    AutoItX.Send("{TAB 2}");
        //    Thread.Sleep(2000);

        //    //UIHelper.ScrollToElement(driver, lblMortgagorInformation);
        //    //UIHelper.EnterTextIE(txtMortgagorFirstName, "Abddd");
        //    //UIHelper.EnterTextIE(txtMortgagorLastName, "Zdhhh");
        //    //UIHelper.ScrollToElement(driver, lblProperty);
        //    //UIHelper.EnterTextIE(txtPropertyAddress, "hfhhs ssss");
        //    //UIHelper.EnterTextIE(txtPropertyCity, "Toronto");
        //    //UIHelper.EnterTextIE(txtMortgageClosingDate, "Thu. May. 14, 2020");
        //    //Thread.Sleep(2000);

        //    AutoItX.Send("{ENTER}");
        //    Thread.Sleep(5000);
        //}

        //public void CreateNewOrder(string rfiReceivedDate, string mortgagorFirst, string mortgagorLast, string propertyAddress, string propertyCity, string closingDate)
        //{
        //    //Lender Program
        //    UIHelper.WaitForElementVisible(txtRFIReceivedDate, 20);
        //    UIHelper.EnterTextIE(txtRFIReceivedDate, rfiReceivedDate);

        //    //RSC/MOSE
        //    UIHelper.EnterTextIE(txtRSCMOSE, RSCMOSE);

        //    //Mortgagor Information
        //    UIHelper.EnterTextIE(txtMortgagorFirstName, mortgagorFirst);
        //    UIHelper.EnterTextIE(txtMortgagorLastName, mortgagorLast);
        //    UIHelper.EnterTextIE(txtMortgagorBusinessPhoneNo, MotionMortgagorBusinessPhoneNo);
        //    UIHelper.EnterTextIE(txtMortgagorAddress, MotionMortgagorAddress);
        //    UIHelper.EnterTextIE(txtMortgagorCity, MotionMortgagorCity);
        //    UIHelper.EnterTextIE(txtMortgagorProvince, MotionMortgagorProvince);
        //    UIHelper.EnterTextIE(txtMortgagorPostalCode, MotionMortgagorPostalCode);
        //    UIHelper.EnterTextIE(txtMortgagorServicePhone, MotionMortgagorServicePhone);

        //    //Property
        //    UIHelper.ScrollToElement(driver, lblProperty);
        //    UIHelper.EnterTextIE(txtPropertyLegalDesc, MotionPropertyLegalDesc);
        //    Thread.Sleep(2000);
        //    //UIHelper.EnterTextIE(txtPropertyPIN, MotionPropertyPIN);
        //    //UIHelper.SelectComboElement(ddlProprertyTypeOfEstate, MotionPropertyTypeOfEstate);
        //    AutoItX.Send("+{TAB 43}");
        //    Thread.Sleep(4000);
        //    AutoItX.Send("{DOWN}");
        //    Thread.Sleep(1000);
        //    UIHelper.EnterTextIE(txtPropertyAddress, propertyAddress);
        //    UIHelper.EnterTextIE(txtPropertyCity, propertyCity);
        //    UIHelper.EnterTextIE(txtPropertyPostalCode, MotionPropertyPostalCode);

        //    //Mortgage Information
        //    //UIHelper.SelectComboElementIE(ddlMortgageProduct, MotionMortgageProduct);
        //    AutoItX.Send("{TAB 23}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{DOWN 2}");
        //    Thread.Sleep(2000);
        //    UIHelper.WaitForElementVisible(txtMortgageClosingDate, 5);
        //    UIHelper.EnterTextIE(txtMortgageNumber, MotionMortgageNumber);
        //    UIHelper.EnterTextIE(txtMIMsRefNo, MotionMIMsRefNumber);
        //    UIHelper.EnterTextIE(txtMortgageClosingDate, closingDate);
        //    UIHelper.EnterTextIE(txtMortgageAmount, MotionMortgageAmount);

        //    //Originating Branch
        //    UIHelper.ScrollToElement(driver, lblOriginatingBranch);
        //    UIHelper.EnterTextIE(txtOriginatingBranchNo, OriginatingBranchNo);
        //    UIHelper.EnterTextIE(txtOriginatingContactFirst, OriginatingContactFirst);
        //    UIHelper.EnterTextIE(txtOriginatingContactLast, OriginatingContactLast);

        //    //Signing Branch
        //    UIHelper.EnterTextIE(txtSigningBranchNo, SigningBranchNo);
        //    UIHelper.EnterTextIE(txtSigningContactFirst, SigningContactFirst);
        //    UIHelper.EnterTextIE(txtSigningContactLast, SigningContactLast);
        //    UIHelper.EnterTextIE(txtSigningPhoneNo, SigningPhone);

        //    //Lender Remarks
        //    //UIHelper.SelectComboElementIE(ddlDealSource, MotionDealSource);
        //    AutoItX.Send("{TAB 18}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{DOWN 3}");
        //    Thread.Sleep(1000);

        //    //UIHelper.ClickOnLinkIE(btnSubmitForApproval);
        //    AutoItX.Send("{TAB 2}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{ENTER}");
        //    Thread.Sleep(5000);
        //}

        public void CreateNewOrder(string mortgagorFirst, string mortgagorLast, string propertyAddress, string propertyCity, string closingDate)
        {
            //Lender Program
            UIHelper.WaitForElementVisibleEC(By.Id("txtRFIFaxReceiveDate"), 10);

            //RSC/MOSE
            UIHelper.EnterTextIEFocused("txtMortgageCenterNumber", RSCMOSE);

            //Mortgagor Information
            UIHelper.EnterTextIEFocused("txtMortgagorFirstName", mortgagorFirst);
            UIHelper.EnterTextIEFocused("txtMortgagorLastName", mortgagorLast);
            UIHelper.EnterTextIE(txtMortgagorBusinessPhoneNo, MotionMortgagorBusinessPhoneNo);
            UIHelper.EnterTextIEFocused("txtMortgagorStreetAddress1", MotionMortgagorAddress);
            UIHelper.EnterTextIEFocused("txtMortgagorCity", MotionMortgagorCity);
            UIHelper.EnterTextIEFocused("txtMortgagorProvince", MotionMortgagorProvince);
            UIHelper.EnterTextIE(txtMortgagorPostalCode, MotionMortgagorPostalCode);
            UIHelper.EnterTextIE(txtMortgagorServicePhone, MotionMortgagorServicePhone);

            //Property
            UIHelper.ScrollToElement(driver, lblProperty);
            UIHelper.EnterTextIEFocused("txtPropertyLegalDescription", MotionPropertyLegalDesc);
            UIHelper.SelectComboElementIE("cboPropertyTypeOfEstate");
            UIHelper.EnterTextIEFocused("txtMunicipalAddressStreetAddress1", propertyAddress);
            UIHelper.EnterTextIEFocused("txtMunicipalAddressCity", propertyCity);
            UIHelper.EnterTextIEFocused("txtMunicipalAddressPostalCode", MotionPropertyPostalCode);
            //UIHelper.EnterTextIE(txtPropertyPostalCode, MotionPropertyPostalCode);

            //Existing Mortgage
            UIHelper.SelectComboElementIE("cboExistingMortgageAction");
            UIHelper.EnterTextIEFocused("txtExistingMortgageAmount", MotionExistingMortgageAmount);
            UIHelper.EnterTextIEFocused("txtExistingMortgageMortgagee", MotionExistingMortgagee);
            UIHelper.EnterTextIEFocused("txtExistingMortgageRegistrationNumber", MotionExistingMortgageRegNo);
            UIHelper.EnterTextIEFocused("txtFacilityUID", MotionExistingMortgageFacilityID);
            UIHelper.EnterTextIEFocused("txtExistingMortgageNumber", MotionExistingMortgageNo);

            //Mortgage Information
            UIHelper.SelectComboElementIE("cboMortgageProduct");
            UIHelper.EnterTextIEFocused("txtMortgageNumber", MotionMortgageNumber);
            UIHelper.EnterTextIEFocused("txtAltChannelRefNumber", MotionMIMsRefNumber);
            //UIHelper.EnterTextIEFocused("txtMortgageClosingDate", closingDate);
            UIHelper.EnterTextIEFocused("txtSplitAmount", MotionMortgageAmount);
            UIHelper.EnterTextIEFocused("txtAbvBlwInterestRate", MotionMortgagePrimeRate);

            //Originating Branch
            UIHelper.ScrollToElement(driver, lblOriginatingBranch);
            UIHelper.EnterTextIEFocused("txtOriginatingBranchNumber", OriginatingBranchNo);
            UIHelper.EnterTextIEFocused("txtOriginatingBranchContactFirstName", OriginatingContactFirst);
            UIHelper.EnterTextIEFocused("txtOriginatingBranchContactLastName", OriginatingContactLast);

            //Signing Branch
            UIHelper.EnterTextIEFocused("txtSigningBranchNumber", SigningBranchNo);
            UIHelper.EnterTextIEFocused("txtSigningBranchContactFirstName", SigningContactFirst);
            UIHelper.EnterTextIEFocused("txtSigningBranchContactLastName", SigningContactLast);
            UIHelper.EnterTextIE(txtSigningPhoneNo, SigningPhone);

            //Lender Remarks
            UIHelper.SelectComboElementIE("cboSourceOpt", "3");

            //Submit RFI
            UIHelper.ClickOnLinkFocusedIE("RFISubmit");

            driver.Close();
            UIHelper.SwitchToBaseWindow();
        }

        //public void CreateNewOrder()
        //{
        //    //Lender Program
        //    UIHelper.WaitForElementVisible(txtRFIReceivedDate, 10);

        //    //Mortgagor Information
        //    UIHelper.EnterTextIE(txtMortgagorBusinessPhoneNo, MotionMortgagorBusinessPhoneNo);
        //    UIHelper.EnterTextIE(txtMortgagorPostalCode, MotionMortgagorPostalCode);
        //    UIHelper.EnterTextIE(txtMortgagorServicePhone, MotionMortgagorServicePhone);

        //    //Property
        //    UIHelper.EnterTextIE(txtPropertyPostalCode, MotionPropertyPostalCode);

        //    //Originating Branch
        //    UIHelper.ScrollToElement(driver, lblOriginatingBranch);

        //    //Signing Branch
        //    UIHelper.EnterTextIE(txtSigningPhoneNo, SigningPhone);

        //    //Submit RFI
        //    //UIHelper.ClickOnLinkIE(btnSubmitForApproval);
        //    AutoItX.Send("+{TAB 2}");
        //    Thread.Sleep(2000);
        //    AutoItX.Send("{ENTER}");
        //    Thread.Sleep(2000);

        //    driver.Close();
        //    UIHelper.SwitchToBaseWindow();
        //}
    }
}
