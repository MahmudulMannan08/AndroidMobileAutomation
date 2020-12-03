using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Protractor;
using TechTalk.SpecFlow;

namespace BrokerPortalMobile
{
    [Binding]
    public class TestBase
    {
        public static string BrokerPortal = null;
        public static string BrokerUsername = null;
        public static string BrokerPassword = null;
        public static string BrokerIDNo = null;
        public static string BrokerCRMFirstName = null;
        public static string BrokerCRMLastName = null;
        public static string BrokerCRMEmail = null;
        public static string BrokerName = null;
        public static string BrokerAdminUsername = null;
        public static string BrokerAdminPassword = null;
        public static string BrokerAdminIDNo = null;
        public static string BrokerAdminCRMFirstName = null;
        public static string BrokerAdminCRMLastName = null;
        public static string BrokerToDelegateUsername = null;
        public static string BrokerToDelegatePassword = null;
        public static string BrokerDelegateCRMFirstName = null;
        public static string BrokerDelegateCRMLastName = null;
        public static string BrokerDelegateName = null;
        public static string InactiveBrokerUsername = null;
        public static string InactiveBrokerPassword = null;
        public static string DeclinedBrokerUsername = null;
        public static string DeclinedBrokerPassword = null;
        public static string LockedBrokerUsername = null;
        public static string LockedBrokerPassword = null;

        public static string MMSPortal = null;
        public static string MMSUsername = null;
        public static string MMSPassword = null;
        public static string MMSLenderName = null;
        public static string MMSNote = null;
        public static string MMSNote2 = null;
        public static string NoResultFoundMessage = null;
        public static string MMSCustomNote = null;
        public static string BrokerAlertReply = null;
        public static string BrokerNewNote = null;
        public static string BrokerNewNote2 = null;
        public static string PropertyAddress1 = null;
        public static string PropertyCity = null;
        public static string PropertyProvince = null;
        public static string PropertyPostalCode = null;
        public static string MortgagorAddress1 = null;
        public static string MortgagorCity = null;
        public static string MortgagorProvince = null;
        public static string MortgagorPostalCode = null;
        
        public static string MotionPortal = null;
        public static string MotionUsername = null;
        public static string MotionPassword = null;
        public static string MotionTitleOfficer = null;
        public static string MotionProgram = null;
        public static string MotionMortgagorBusinessPhoneNo = null;
        public static string MotionMortgagorAddress = null;
        public static string MotionMortgagorCity = null;
        public static string MotionMortgagorProvince = null;
        public static string MotionMortgagorPostalCode = null;
        public static string MotionMortgagorServicePhone = null;
        public static string MotionPropertyLegalDesc = null;
        public static string MotionPropertyPIN = null;
        public static string MotionPropertyTypeOfEstate = null;
        public static string MotionPropertyPostalCode = null;
        public static string MotionMortgageProduct = null;
        public static string MotionMortgageNumber = GenerateNumber(7);
        public static string MotionMIMsRefNumber = GenerateNumber(6);
        public static string MotionMortgageAmount = null;
        public static string MotionExistingMortgageAmount = null;
        public static string MotionExistingMortgagee = null;
        public static string MotionExistingMortgageRegNo = GenerateNumber(8);
        public static string MotionExistingMortgageFacilityID = GenerateNumber(5);
        public static string MotionExistingMortgageNo = GenerateNumber(9);
        public static string MotionMortgagePrimeRate = null;
        public static string RSCMOSE = null;
        public static string OriginatingBranchNo = null;
        public static string OriginatingContactFirst = null;
        public static string OriginatingContactLast = null;
        public static string SigningBranchNo = null;
        public static string SigningContactFirst = null;
        public static string SigningContactLast = null;
        public static string SigningPhone = null;
        public static string MotionDealSource = null;
        public static string MotionPropertyAddress = null;
        public static string MotionPropertyCity = null;
        public static string MotionNote = null;
        public static string MotionNote2 = null;

        public static string Environment = null;
        public static string ClosingDate = CurrentOrFutureDate("MM/dd/yyyy");
        public static int initialBucketCount = 0;
        public static DateTime ResultWeekday;
        public static string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private static readonly Random Random = new Random((int)DateTime.Now.Ticks);

        public static AndroidDriver<AppiumWebElement> androidDriver;
        public static IWebDriver driver;
        public static WebDriverWait Wait;

        //public void StartAppiumDriver()
        //{
        //    ////Set the capabilities
        //    //DesiredCapabilities cap = new DesiredCapabilities();
        //    //cap.SetCapability("deviceName", "donatello");
        //    //cap.SetCapability("platformVersion", "6.0.0");
        //    //cap.SetCapability("udid", "169.254.76.233:5555");
        //    //cap.SetCapability("fullReset", "True");
        //    //cap.SetCapability(MobileCapabilityType.App, "Browser");
        //    //cap.SetCapability("platformName", "Android");
        //    //androidDriver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

        //    AppiumOptions cap = new AppiumOptions();
        //    //cap.AddAdditionalCapability("automationName", ConfigurationManager.AppSettings["automationEngine"]);
        //    cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, ConfigurationManager.AppSettings["deviceName"]);
        //    cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, ConfigurationManager.AppSettings["platformName"]);
        //    cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, ConfigurationManager.AppSettings["platformVersion"]);
        //    cap.AddAdditionalCapability(MobileCapabilityType.BrowserName, "Chrome");
        //    //cap.AddAdditionalCapability("udid", ConfigurationManager.AppSettings["udid"]);
        //    //cap.AddAdditionalCapability("fullReset", ConfigurationManager.AppSettings["fullReset"]);
        //    //cap.AddAdditionalCapability(MobileCapabilityType.App, ConfigurationManager.AppSettings["MobileCapabilityType"]);

        //    androidDriver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
        //}

        public static void InitializeMobileDriver(string platform = "ANDROID")
        {
            ScenarioContext.Current["BROWSER_AUTOMATION"] = "FALSE";

            if (platform.ToUpper() == "IOS")
            {
                ScenarioContext.Current["platform"] = "IOS";

                //Set the capabilities
            }
            else
            {
                ScenarioContext.Current["platform"] = "ANDROID";

                //Set the capabilities
                AppiumOptions cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, ConfigurationManager.AppSettings["deviceName"]);
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, ConfigurationManager.AppSettings["platformName"]);
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, ConfigurationManager.AppSettings["platformVersion"]);
                cap.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
                //cap.AddAdditionalCapability(MobileCapabilityType.BrowserName, browser);
                cap.AddAdditionalCapability(MobileCapabilityType.BrowserName, "Chrome");       //using Chrome browser only on Android
                cap.AddAdditionalCapability(MobileCapabilityType.NoReset, true);
                cap.AddAdditionalCapability("unicodeKeyboard", true);      //Capabilities to not open soft keyboard
                cap.AddAdditionalCapability("resetKeyboard", true);
                //androidDriver.HideKeyboard();
                
                androidDriver = new AndroidDriver<AppiumWebElement>(new Uri(ConfigurationManager.AppSettings["appiumServerUrl"]), cap);
                androidDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                androidDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
            }
        }

        public static void InitializeMobileAppDriver(string platform = "ANDROID")
        {
            ScenarioContext.Current["BROWSER_AUTOMATION"] = "FALSE";

            if (platform.ToUpper() == "IOS")
            {
                ScenarioContext.Current["platform"] = "IOS";

                //Set the capabilities
            }
            else
            {
                ScenarioContext.Current["platform"] = "ANDROID";
                string appPath = projectDirectory + @"\BrokerPortalMobile\BrokerPortalMobile\MobileApp\ANDROID\" + Environment.ToUpper() + @"\com.fct.mobile.brokersvs.apk";

                //Set the capabilities
                AppiumOptions cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, ConfigurationManager.AppSettings["deviceName"]);
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, ConfigurationManager.AppSettings["platformName"]);
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, ConfigurationManager.AppSettings["platformVersion"]);
                cap.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
                cap.AddAdditionalCapability(MobileCapabilityType.App, appPath);
                //cap.AddAdditionalCapability(MobileCapabilityType.NoReset, false);
                cap.AddAdditionalCapability(MobileCapabilityType.FullReset, true);
                cap.AddAdditionalCapability("unicodeKeyboard", true);      //Capabilities to not open soft keyboard
                cap.AddAdditionalCapability("resetKeyboard", true);
                //cap.AddAdditionalCapability("noSign", true);
                //cap.AddAdditionalCapability("autoAcceptAlerts", true);
                //cap.AddAdditionalCapability("autoDismissAlerts", true);
                //androidDriver.HideKeyboard();

                androidDriver = new AndroidDriver<AppiumWebElement>(new Uri(ConfigurationManager.AppSettings["appiumServerUrl"]), cap);
                androidDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                //androidDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
            }
        }

        public static void InitializeDriver(string browser = "Chrome")
        {
            //IWebDriver driver;

            //ScenarioContext.Current["BROWSER_AUTOMATION"] = "TRUE";
            ScenarioContext.Current["platform"] = "BROWSER";

            if (browser.ToUpper().Equals("FIREFOX"))
            {
                driver = new FirefoxDriver();
            }
            if (browser.ToUpper().Equals("INTERNETEXPLORER"))
            {
                InternetExplorerOptions options = new InternetExplorerOptions();
                options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                options.EnableNativeEvents = true;
                options.IgnoreZoomLevel = true;
                //options.RequireWindowFocus = true;
                options.EnablePersistentHover = true;
                options.EnsureCleanSession = true;
                options.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
                driver = new InternetExplorerDriver(options);
                //driver = new InternetExplorerDriver(@"C:\drivers_32bit", options);
                //((IJavaScriptExecutor)driver).ExecuteScript("document.body.style.zoom = '100%';");
                //SetZoom100();

                //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                //options.IgnoreZoomLevel = true;
                //options.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
                //options.EnablePersistentHover = true;
                //options.EnableNativeEvents = false;
                //options.EnsureCleanSession = true;
            }
            else
            {
                //Add Chrome option arguments
                var options = new ChromeOptions();
                options.AddArguments("test-type");
                driver = new ChromeDriver(options);
            }

            //var ngdriver = new NgWebDriver(driver);
            //ngdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            //ngdriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            //ngdriver.Manage().Window.Maximize();
            //Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //ngdriver.IgnoreSynchronization = true;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public static void SetZoom100()
        {
            // Get DPI setting.
            RegistryKey dpiRegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop\\WindowMetrics");
            int dpi = (int)dpiRegistryKey.GetValue("AppliedDPI");
            // 96 DPI / Smaller / 100%
            int zoomFactor100Percent = 100000;
            switch (dpi)
            {
                case 120: // Medium / 125%
                    zoomFactor100Percent = 80000;
                    break;
                case 144: // Larger / 150%
                    zoomFactor100Percent = 66667;
                    break;
            }
            // Get IE zoom.
            RegistryKey zoomRegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Zoom", true);
            int currentZoomFactor = (int)zoomRegistryKey.GetValue("ZoomFactor");
            if (currentZoomFactor != zoomFactor100Percent)
            {
                // Set IE zoom and remember the previous value.
                zoomRegistryKey.SetValue("ZoomFactor", zoomFactor100Percent, RegistryValueKind.DWord);
                //m_PreviousZoomFactor = currentZoomFactor;
            }
        }

        private static void UpdateInternetExplorerRegistrySettings()
        {
            try
            {
                const string REGISTRY_KEY_IE_ZOOM = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Zoom";
                const string REGISTRY_KEY_IE_MAIN = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main";
                const string REGISTRY_KEY_IE_NEWWINDOW = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows";

                // Set value of "Enabled Protected Mode" to disabled for all Zones
                //string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\{0}";
                //for (int zone = 1; zone <= 4; zone++)
                //{
                //    Registry.SetValue(string.Format(keyName, zone), "2500", 3);
                //}

                // Set IE zoom level to 100%
                Registry.SetValue(REGISTRY_KEY_IE_ZOOM, "ZoomFactor", 100000);

                // Disable script debugger and script error notification
                Registry.SetValue(REGISTRY_KEY_IE_MAIN, "DisableScriptDebuggerIE", "yes");              //string value “yes” or “no”
                Registry.SetValue(REGISTRY_KEY_IE_MAIN, "Disable Script Debugger", "yes");
                Registry.SetValue(REGISTRY_KEY_IE_MAIN, "Error Dlg Displayed On Every Error", "no");       //string value “yes” or “no”

                // Turn off pop-up blocker
                Registry.SetValue(REGISTRY_KEY_IE_NEWWINDOW, "PopupMgr", 0);

            }
            catch (Exception ex)
            {
                //Debug.WriteLine("Error modifying IE's settings; " + ex.Message);
            }
        }

        public static void RunSettingsData()
        {
            StreamReader jsonFile = new StreamReader(projectDirectory + @"\BrokerPortalMobile\BrokerPortalMobile\TestData\RunSettings.json");
            string json = jsonFile.ReadToEnd();
            var jsonContent = JObject.Parse(json);
            var Env = jsonContent["Settings"]["Environment"].ToString();
            Environment = Env;

            BrokerPortal = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerPortal"].ToString();
            BrokerUsername = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerUsername"].ToString();
            BrokerPassword = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerPassword"].ToString();
            BrokerIDNo = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerIDNo"].ToString();
            BrokerCRMFirstName = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerCRMFirstName"].ToString();
            BrokerCRMLastName = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerCRMLastName"].ToString();
            BrokerCRMEmail = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerCRMEmail"].ToString();
            BrokerName = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerName"].ToString();
            BrokerAdminUsername = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerAdminUsername"].ToString();
            BrokerAdminPassword = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerAdminPassword"].ToString();
            BrokerAdminIDNo = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerAdminIDNo"].ToString();
            BrokerAdminCRMFirstName = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerAdminCRMFirstName"].ToString();
            BrokerAdminCRMLastName = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerAdminCRMLastName"].ToString();
            BrokerToDelegateUsername = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerToDelegateUsername"].ToString();
            BrokerToDelegatePassword = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerToDelegatePassword"].ToString();
            BrokerDelegateCRMFirstName = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerDelegateCRMFirstName"].ToString();
            BrokerDelegateCRMLastName = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerDelegateCRMLastName"].ToString();
            BrokerDelegateName = jsonContent["Settings"]["BrokerDetails"][Env]["BrokerDelegateName"].ToString();
            InactiveBrokerUsername = jsonContent["Settings"]["BrokerDetails"][Env]["InactiveBrokerUsername"].ToString();
            InactiveBrokerPassword = jsonContent["Settings"]["BrokerDetails"][Env]["InactiveBrokerPassword"].ToString();
            DeclinedBrokerUsername = jsonContent["Settings"]["BrokerDetails"][Env]["DeclinedBrokerUsername"].ToString();
            DeclinedBrokerPassword = jsonContent["Settings"]["BrokerDetails"][Env]["DeclinedBrokerPassword"].ToString();
            LockedBrokerUsername = jsonContent["Settings"]["BrokerDetails"][Env]["LockedBrokerUsername"].ToString();
            LockedBrokerPassword = jsonContent["Settings"]["BrokerDetails"][Env]["LockedBrokerPassword"].ToString();

            MMSPortal = jsonContent["Settings"]["LenderDetails"]["MMSLender"][Env]["MMSPortal"].ToString();
            MMSUsername = jsonContent["Settings"]["LenderDetails"]["MMSLender"][Env]["MMSUsername"].ToString();
            MMSPassword = jsonContent["Settings"]["LenderDetails"]["MMSLender"][Env]["MMSPassword"].ToString();
            MMSLenderName = jsonContent["Settings"]["LenderDetails"]["MMSLender"][Env]["MMSLenderName"].ToString();
            
            MotionPortal = jsonContent["Settings"]["LenderDetails"]["MotionLender"][Env]["MotionPortal"].ToString();
            MotionUsername = jsonContent["Settings"]["LenderDetails"]["MotionLender"][Env]["MotionUsername"].ToString();
            MotionPassword = jsonContent["Settings"]["LenderDetails"]["MotionLender"][Env]["MotionPassword"].ToString();
            MotionTitleOfficer = jsonContent["Settings"]["LenderDetails"]["MotionLender"][Env]["MotionTitleOfficer"].ToString();
            MotionProgram = jsonContent["Settings"]["LenderDetails"]["MotionLender"][Env]["MotionProgram"].ToString();
        }

        public static void TestData()
        {
            StreamReader jsonFile = new StreamReader(projectDirectory + @"\BrokerPortalMobile\BrokerPortalMobile\TestData\TestData.json");
            string json = jsonFile.ReadToEnd();
            var jsonContent = JObject.Parse(json);

            //MMS Test Data
            MMSNote = jsonContent["Settings"]["LenderData"]["MMSLender"]["MMSNote"].ToString();
            MMSNote2 = jsonContent["Settings"]["LenderData"]["MMSLender"]["MMSNote2"].ToString();
            NoResultFoundMessage = jsonContent["Settings"]["BrokerData"]["NoResultFoundMessage"].ToString();
            MMSCustomNote = jsonContent["Settings"]["LenderData"]["MMSLender"]["MMSCustomNote"].ToString();
            PropertyAddress1 = jsonContent["Settings"]["LenderData"]["MMSLender"]["PropertyAddress1"].ToString();
            PropertyCity = jsonContent["Settings"]["LenderData"]["MMSLender"]["PropertyCity"].ToString();
            PropertyProvince = jsonContent["Settings"]["LenderData"]["MMSLender"]["PropertyProvince"].ToString();
            PropertyPostalCode = jsonContent["Settings"]["LenderData"]["MMSLender"]["PropertyPostalCode"].ToString();
            MortgagorAddress1 = jsonContent["Settings"]["LenderData"]["MMSLender"]["MortgagorAddress1"].ToString();
            MortgagorCity = jsonContent["Settings"]["LenderData"]["MMSLender"]["MortgagorCity"].ToString();
            MortgagorProvince = jsonContent["Settings"]["LenderData"]["MMSLender"]["MortgagorProvince"].ToString();
            MortgagorPostalCode = jsonContent["Settings"]["LenderData"]["MMSLender"]["MortgagorPostalCode"].ToString();
            
            //Broker Portal Test Data
            BrokerAlertReply = jsonContent["Settings"]["BrokerData"]["BrokerAlertReply"].ToString();
            BrokerNewNote = jsonContent["Settings"]["BrokerData"]["BrokerNewNote"].ToString();
            BrokerNewNote2 = jsonContent["Settings"]["BrokerData"]["BrokerNewNote2"].ToString();

            //Motion Test Data
            RSCMOSE = jsonContent["Settings"]["LenderData"]["MotionLender"]["RSCMOSE"].ToString();
            MotionMortgagorBusinessPhoneNo = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgagorBusinessPhoneNo"].ToString();
            MotionMortgagorAddress = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgagorAddress"].ToString();
            MotionMortgagorCity = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgagorCity"].ToString();
            MotionMortgagorProvince = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgagorProvince"].ToString();
            MotionMortgagorPostalCode = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgagorPostalCode"].ToString();
            MotionMortgagorServicePhone = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgagorServicePhone"].ToString();
            MotionPropertyLegalDesc = jsonContent["Settings"]["LenderData"]["MotionLender"]["PropertyLegalDesc"].ToString();
            MotionPropertyPIN = jsonContent["Settings"]["LenderData"]["MotionLender"]["PropertyPIN"].ToString();
            MotionPropertyTypeOfEstate = jsonContent["Settings"]["LenderData"]["MotionLender"]["PropertyTypeOfEstate"].ToString();
            MotionPropertyPostalCode = jsonContent["Settings"]["LenderData"]["MotionLender"]["PropertyPostalCode"].ToString();
            MotionMortgageProduct = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgageProduct"].ToString();
            MotionMortgageAmount = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgageAmount"].ToString();
            MotionExistingMortgageAmount = jsonContent["Settings"]["LenderData"]["MotionLender"]["ExistingMortgageAmount"].ToString();
            MotionExistingMortgagee = jsonContent["Settings"]["LenderData"]["MotionLender"]["ExistingMortgagee"].ToString();
            MotionMortgagePrimeRate = jsonContent["Settings"]["LenderData"]["MotionLender"]["MortgagePrimeRate"].ToString();
            OriginatingBranchNo = jsonContent["Settings"]["LenderData"]["MotionLender"]["OriginatingBranchNo"].ToString();
            OriginatingContactFirst = jsonContent["Settings"]["LenderData"]["MotionLender"]["OriginatingContactFirst"].ToString();
            OriginatingContactLast = jsonContent["Settings"]["LenderData"]["MotionLender"]["OriginatingContactLast"].ToString();
            SigningBranchNo = jsonContent["Settings"]["LenderData"]["MotionLender"]["SigningBranchNo"].ToString();
            SigningContactFirst = jsonContent["Settings"]["LenderData"]["MotionLender"]["SigningContactFirst"].ToString();
            SigningContactLast = jsonContent["Settings"]["LenderData"]["MotionLender"]["SigningContactLast"].ToString();
            SigningPhone = jsonContent["Settings"]["LenderData"]["MotionLender"]["SigningPhone"].ToString();
            MotionDealSource = jsonContent["Settings"]["LenderData"]["MotionLender"]["DealSource"].ToString();
            MotionPropertyAddress = jsonContent["Settings"]["LenderData"]["MotionLender"]["PropertyAddress"].ToString();
            MotionPropertyCity = jsonContent["Settings"]["LenderData"]["MotionLender"]["PropertyCity"].ToString();
            MotionNote = jsonContent["Settings"]["LenderData"]["MotionLender"]["MotionNote"].ToString();
            MotionNote2 = jsonContent["Settings"]["LenderData"]["MotionLender"]["MotionNote2"].ToString();
        }

        public static string GenerateString(int size)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        public static string GenerateNumber(int size)
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 0; i < size; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }

        public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;

            return start.AddDays(daysToAdd);
        }

        public static DateTime GetLastWeekday(DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Friday)
            {
                date = date.AddDays(-1);
            }

            return date;
        }

        public static string CurrentOrFutureDate(string format)
        {
            //var Today = new DateTime();
            //var CurrentYear = DateTime.Now.Year;
            //var CurrentMonth = DateTime.Now.Month;
            //DateTime ResultWeekday;
            var CurrentDate = DateTime.Now.Date;
            var CurrentDayofWeek = DateTime.Now.DayOfWeek;
            var LastDayofMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            if ((CurrentDayofWeek == DayOfWeek.Saturday) || (CurrentDayofWeek == DayOfWeek.Sunday))
            {
                ResultWeekday = GetNextWeekday(CurrentDate, DayOfWeek.Monday);
            }

            else
            {
                ResultWeekday = CurrentDate;
            }

            return ResultWeekday.ToString(format);
        }

        public static string CurrentOrPastDate(string format)
        {
            //DateTime ResultWeekday;
            var CurrentDate = DateTime.Now.Date;
            var CurrentDayofWeek = DateTime.Now.DayOfWeek;
            var LastDayofMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            if ((CurrentDayofWeek == DayOfWeek.Saturday) || (CurrentDayofWeek == DayOfWeek.Sunday))
            {
                ResultWeekday = GetLastWeekday(CurrentDate);
            }

            else
            {
                ResultWeekday = CurrentDate;
            }

            return ResultWeekday.ToString(format);
        }

        public static string ConvertDateFormat(DateTime date, string format)
        {
            return date.ToString(format);
        }

        public static string ConvertStringDateFormat(string date, string fromFormat, string toFormat)
        {
            //return DateTime.ParseExact(date, fromFormat, System.Globalization.CultureInfo.InvariantCulture).ToString(format);
            return DateTime.ParseExact(date, fromFormat, null).ToString(toFormat);
        }

        public static string CurrentDate(string format)
        {
            return DateTime.Now.Date.ToString(format);
        }

        public static string CurrentDay()
        {
            return DateTime.Now.ToString("ddd");
        }
        
        public string ReturnProvinceCode(string province)
        {
            switch (province.ToUpper())
            {
                case "ONTARIO":
                    return "ON";

                case "SASKATCHEWAN":
                    return "SK";

                case "NEWFOUNDLAND":
                    return "NL";

                case "PRINCE EDWARD ISLAND":
                    return "PE";

                default:
                    return "ON";
            }
        }

        public string ReturnProvinceMotion(string motionProgram)
        {
            switch (motionProgram)
            {
                case "Bank of Nova Scotia - Collateral ON":
                    return "Ontario";

                case "Bank of Nova Scotia - Collateral AB":
                    return "Alberta";

                default:
                    return "Alberta";
            }
        }

        public string ReturnLenderMotion(string motionProgram)
        {
            if (motionProgram.Contains("Bank of Nova Scotia"))
            {
                return "The Bank of Nova Scotia";
            }
            else
            {
                return null;
            }
        }

        [BeforeScenario]
        public void LoadTestData()
        {
            //Load data files
            RunSettingsData();
            TestData();
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            if (ConfigurationManager.AppSettings["VERBOSE_MODE"].Equals("OFF") && ScenarioContext.Current["platform"] == "ANDROID")
            {
                //UIHelper.SendEmailOnErrorWithAttachment(UIHelper.TakeScreenshot());

                //Close application, but keep emulator open
                androidDriver.CloseApp();

                //IWebElement dropBtn = androidDriver.FindElement(By.Id("com.android.systemui:id/dismiss_task"));
                //dropBtn.Click();
            }
            if (ConfigurationManager.AppSettings["VERBOSE_MODE"].Equals("OFF") && ScenarioContext.Current["platform"] == "IOS")
            {
                //Close application, but keep emulator open

            }
            if (ConfigurationManager.AppSettings["VERBOSE_MODE"].Equals("OFF") && ScenarioContext.Current["platform"] == "BROWSER")
            {
                driver.Quit();
            }
        }

    }
}
