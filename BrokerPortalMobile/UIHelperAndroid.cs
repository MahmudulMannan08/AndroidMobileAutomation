using BrokerPortalMobile.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using Protractor;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerPortalMobile
{
    class UIHelperAndroid : TestBase
    {
        public static T PageInit<T>(AndroidDriver<AppiumWebElement> androidDriver) where T : class, new()
        {
            var page = new T();
            PageFactory.InitElements(androidDriver, page);

            return page;
        }

        public static void GoTo<T>(string host) where T : IPage, new()
        {
            var page = new T();
            var url = host + page.Url;
            androidDriver.Navigate().GoToUrl(url);
        }

        public static void WaitForPageLoad(int maxWaitTimeInSeconds)
        {
            string state = string.Empty;
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxWaitTimeInSeconds));

                //Checks every 500 ms whether predicate returns true if returns exit otherwise keep trying till it returns ture
                wait.Until(d =>
                {

                    try
                    {
                        state = ((IJavaScriptExecutor)androidDriver).ExecuteScript(@"return document.readyState").ToString();
                    }
                    catch (InvalidOperationException)
                    {
                        //Ignore
                    }
                    catch (NoSuchWindowException)
                    {
                        //when popup is closed, switch to last windows
                        androidDriver.SwitchTo().Window(androidDriver.WindowHandles.Last());
                    }
                    //In IE7 there are chances we may get state as loaded instead of complete
                    return (state.Equals("complete", StringComparison.InvariantCultureIgnoreCase) || state.Equals("loaded", StringComparison.InvariantCultureIgnoreCase));

                });
            }
            catch (TimeoutException)
            {
                //sometimes Page remains in Interactive mode and never becomes Complete, then we can still try to access the controls
                if (!state.Equals("interactive", StringComparison.InvariantCultureIgnoreCase))
                    throw;
            }
            catch (NullReferenceException)
            {
                //sometimes Page remains in Interactive mode and never becomes Complete, then we can still try to access the controls
                if (!state.Equals("interactive", StringComparison.InvariantCultureIgnoreCase))
                    throw;
            }
            catch (WebDriverException)
            {
                if (androidDriver.WindowHandles.Count == 1)
                {
                    androidDriver.SwitchTo().Window(androidDriver.WindowHandles[0]);
                }
                state = ((IJavaScriptExecutor)androidDriver).ExecuteScript(@"return document.readyState").ToString();
                if (!(state.Equals("complete", StringComparison.InvariantCultureIgnoreCase) || state.Equals("loaded", StringComparison.InvariantCultureIgnoreCase)))
                    throw;
            }
        }

        public static Func<IWebDriver, IWebElement> ElementIsClickable(IWebElement webElement)
        {
            return dr => (webElement.Displayed && webElement.Enabled) ? webElement : null;
        }

        //public static Func<IWebDriver, IWebElement> ElementIsNotDisplayed(IWebElement webElement)
        //{
        //    return dr => !(webElement.Displayed) ? webElement : null;
        //}

        //public static Func<IWebDriver, IWebElement> ElementIsNotDisplayed(By locator)
        //{
        //    if (androidDriver.FindElements(locator).Count().Equals(0))
        //    {
        //        return dr => androidDriver.FindElement(locator);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public static bool ElementIsNotDisplayed(By locator)
        {
            if (androidDriver.FindElements(locator).Count().Equals(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public static IWebDriver ClickOnLink(IWebElement webElement)
        //{
        //    Wait.Until(ElementIsClickable(webElement)).Click();
        //    return driver;
        //}

        public static void ClickOnLink(IWebElement webElement)
        {
            //WaitForElementVisible(webElement, 30);
            WaitForElementClickable(webElement, 30);
            webElement.Click();
        }

        public static void EnterText(IWebElement webElement, string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }

        public static void SetCheckbox(IWebElement webElement, string status)
        {
            if (webElement.Selected)
            {
                if (!status.ToUpper().Equals("OFF"))
                {
                    return;
                }

                webElement.Click();
            }
            else
            {
                if (!status.ToUpper().Equals("ON"))
                {
                    return;
                }

                webElement.Click();
            }
        }

        public static void ScrollToElement(IWebDriver Driver, IWebElement element)
        {
            var js = Driver as IJavaScriptExecutor;
            var y = element.Location.Y;
            js.ExecuteScript("javascript:window.scrollBy(0," + y + ")");
        }

        public static void SwipeToElementAndroid(IWebElement fromElement, IWebElement toElement, string direction)
        {
            var fromX = fromElement.Location.X * 0.8;
            var fromY = fromElement.Location.Y * 0.5;
            var toX = toElement.Location.X;
            var toY = toElement.Location.Y;

            TouchAction touchAndroid = new TouchAction(androidDriver);
            switch (direction.ToUpper())
            {
                case "UP":
                    touchAndroid.Press(fromX, fromY).MoveTo(fromX, toY).Release().Perform();
                    break;

                case "DOWN":
                    touchAndroid.Press(fromX, toY).MoveTo(fromX, fromY).Release().Perform();
                    break;

                case "HORIZONTAL":
                    touchAndroid.Press(toX, fromY).MoveTo(fromX, fromY).Release().Perform();
                    break;

                default:
                    break;
            }
        }

        //public static void ScrollDownAndroid()
        //{
        //    Dictionary<string, string> scrollObject = new Dictionary<string, string>();
        //    scrollObject.Add("direction", "down");
        //    ((IJavaScriptExecutor)driver).ExecuteScript("mobile: swipe", scrollObject);
        //}

        public static void ScrollToElementAndroid(string visibleText)
        {
            //androidDriver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + visibleText + "\").instance(0))");
            androidDriver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text('" + visibleText + "'))");
        }

        public static void ScrollToTop(IWebDriver Driver)
        {
            var js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("document.body.scrollTop = document.documentElement.scrollTop = 0;");
        }

        public static void ScrollToBottom()
        {
            var js = androidDriver as IJavaScriptExecutor;
            //js.ExecuteScript("javascript:window.scrollBy(0,document.body.scrollHeight)");
            js.ExecuteScript("javascript:window.scrollBy(0,524)");
            //js.ExecuteScript("javascript:window.scrollBy(0,document.querySelector('.scrollingContainer').scrollHeight)");
        }

        public static void GoBackAndroid()
        {
            androidDriver.Navigate().Back();
        }

        public static void WaitForElementInvisible(int maxTimeOutInSeconds, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while waiting for element to be invisible: " + e.Message);
            }
        }

        public static void WaitForElementVisible(IWebElement webElement, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(ElementIsClickable(webElement));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while waiting for element to be visible: " + e.Message);
            }
        }

        public static void WaitForElementVisibleEC(By locator, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while waiting for element to be visible: " + e.Message);
            }
        }

        public static void WaitForElementClickable(IWebElement webElement, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while waiting for element to be clickable: " + e.Message);
            }
        }

        public static void WaitUntilElementHasValueEC(IWebElement webElement, string verify, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(webElement, verify));
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected element was not visible " + e.Message);
            }
        }

        //public static void WaitForSpinnerInvisible(int maxTimeOutInSeconds)
        //{
        //    try
        //    {
        //        WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
        //        wait.PollingInterval = TimeSpan.FromMilliseconds(10);
        //        wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
        //        wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        //        wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
        //        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("loading-spinner")));
        //        //wait.Until(ElementIsNotDisplayed(By.ClassName("loading-spinner")));
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("There was an error while waiting for spinner to be invisible: " + e.Message);
        //    }
        //}

        public static void WaitForSpinnerInvisible(int maxTimeOutInSeconds)
        {
            if (androidDriver.FindElements(By.ClassName("loading-spinner")).Count() > 0)
            {
                try
                {
                    WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                    wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                    wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                    wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("loading-spinner")));
                    //wait.Until(ElementIsNotDisplayed(By.ClassName("loading-spinner")));
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error while waiting for spinner to be invisible: " + e.Message);
                }
            }
        }

        public static bool IsElementDisplayed(By locator)
        {
            if (androidDriver.FindElements(locator).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsAttributePreset(IWebElement webElement, string attribute)
        {
            try
            {
                if (webElement.GetAttribute(attribute).Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying find if attribute present: " + e.Message);
                return false;
            }
        }

        public static void SelectComboElement(IWebElement ddl, string option)
        {
            ClickOnLink(ddl);
            var optionCount = ddl.FindElements(By.TagName("option")).Count();
            IList<IWebElement> allOptions = ddl.FindElements(By.TagName("option"));

            for (int i = 0; i < optionCount;)
            {
                if (allOptions[i].Text == option)
                {
                    ClickOnLink(allOptions[i]);
                    break;
                }
                else
                {
                    i++;

                    if (i == optionCount)
                    {
                        Console.WriteLine(option, " not available in the drop down");
                    }
                }
            }

            WaitForPageLoad(15);
        }

        public static bool SearchGridAndVerify(IWebElement Table, string verify, int numberOfHeaderRows, int columnNumber)
        {
            var itemCount = Table.FindElements(By.TagName("tr")).Count();
            int flag = 0;
            IList<IWebElement> allOptions = Table.FindElements(By.TagName("tr"));
            //IList<IWebElement> OptionParts = allOptions[1].FindElements(By.TagName("td"));

            if (itemCount > numberOfHeaderRows)
            {
                for (int i = numberOfHeaderRows; i < itemCount;)
                {
                    IList<IWebElement> Columns = allOptions[i].FindElements(By.TagName("td"));
                    if (Columns[columnNumber].Text.Contains(verify))
                    {
                        flag = 1;
                        IWebElement linkElement = Columns[columnNumber].FindElement(By.TagName("a"));
                        Assert.True(linkElement.Displayed && linkElement.Enabled);
                        ClickOnLink(linkElement);
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Assert.True(itemCount > 1, "Table contains no data");
                return false;
            }
        }

        public static bool SearchBPNotesGridAndVerify(IWebElement Table, string verify, int numberOfHeaderRows, int columnNumber)
        {
            var itemCount = Table.FindElements(By.TagName("tr")).Count();
            int flag = 0;
            IList<IWebElement> allOptions = Table.FindElements(By.TagName("tr"));

            if (itemCount > numberOfHeaderRows)
            {
                for (int i = numberOfHeaderRows; i < itemCount;)
                {
                    IList<IWebElement> Columns = allOptions[i].FindElements(By.TagName("td"));
                    if (Columns[columnNumber].Text.Contains(verify))
                    {
                        flag = 1;
                        IWebElement linkElement = Columns[columnNumber];
                        Assert.True(linkElement.Displayed && linkElement.Enabled);
                        ClickOnLink(linkElement);
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Assert.True(itemCount > 1, "Table contains no data");
                return false;
            }
        }

        public static bool VerifyBlankGrid(IWebElement Table, int numberOfHeaderRows)
        {
            var itemCount = Table.FindElements(By.TagName("tr")).Count();
            if (itemCount > numberOfHeaderRows)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int GetTableRowCount(IWebElement Table)
        {
            return Table.FindElements(By.TagName("tr")).Count();
        }
        
        public static Func<IWebDriver, IWebElement> ExpectedTableRows(IWebElement Table, int expectedRows, int numberOfHeaderRows)
        {
            //return dr => Table.FindElements(By.TagName("tr")).Count().Equals(expectedRows + numberOfHeaderRows) ? Table : null;

            int trial = 0;
            bool status = false;
            while (trial < 5)
            {
                try
                {
                    if (Table.FindElements(By.TagName("tr")).Count().Equals(expectedRows + numberOfHeaderRows))
                    {
                        status = true;
                        break;
                    }
                }
                catch (Exception)
                {
                }

                trial++;
            }

            if (status)
            {
                return dr => Table;
            }
            else
            {
                return null;
            }
        }

        public static void WaitUntillExpectedTableEntry(IWebElement Table, int expectedRows, int numberOfHeaderRows, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(ExpectedTableRows(Table, expectedRows, numberOfHeaderRows));
            }
            catch (Exception e)
            {
                //Console.WriteLine("Table does not have expected number of rows: " + e.Message);
            }
        }

        public static Func<IWebDriver, IWebElement> ElementHasText(IWebElement webElement, string verify)
        {
            return dr => (webElement.Text.Equals(verify)) ? webElement : null;
        }

        public static void WaitUntilElementHasText(IWebElement webElement, string verify, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(webElement, verify));
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected element was not visible " + e.Message);
            }
        }

        public static void SwitchToAlertWindow(int maxTimeOutInSeconds, bool action)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());

                IAlert alert = androidDriver.SwitchTo().Alert();
                if (action)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                WaitForPageLoad(30);
                driver.SwitchTo().DefaultContent();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying to switch to Alert: " + e.Message);
            }
        }
    }
}
