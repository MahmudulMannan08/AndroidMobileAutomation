using AutoIt;
using BrokerPortalMobile.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrokerPortalMobile
{
    class UIHelper : TestBase
    {
        public static T PageInit<T>(IWebDriver driver) where T : class, new()
        {
            var page = new T();
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static void GoTo<T>(string host) where T : IPage, new()
        {
            var page = new T();
            var url = host + page.Url;
            driver.Navigate().GoToUrl(url);
        }

        public static void WaitForPageLoad(int maxWaitTimeInSeconds)
        {
            string state = string.Empty;
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxWaitTimeInSeconds));

                //Checks every 500 ms whether predicate returns true if returns exit otherwise keep trying till it returns ture
                wait.Until(d =>
                {

                    try
                    {
                        state = ((IJavaScriptExecutor)driver).ExecuteScript(@"return document.readyState").ToString();
                    }
                    catch (InvalidOperationException)
                    {
                        //Ignore
                    }
                    catch (NoSuchWindowException)
                    {
                        //when popup is closed, switch to last windows
                        driver.SwitchTo().Window(driver.WindowHandles.Last());
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
                if (driver.WindowHandles.Count == 1)
                {
                    driver.SwitchTo().Window(driver.WindowHandles[0]);
                }
                state = ((IJavaScriptExecutor)driver).ExecuteScript(@"return document.readyState").ToString();
                if (!(state.Equals("complete", StringComparison.InvariantCultureIgnoreCase) || state.Equals("loaded", StringComparison.InvariantCultureIgnoreCase)))
                    throw;
            }
        }

        public static Func<IWebDriver, IWebElement> ElementIsClickable(IWebElement webElement)
        {
            return dr => (webElement.Displayed && webElement.Enabled) ? webElement : null;
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

        //public static void ClickOnLinkIE(IWebElement webElement)
        //{
        //    //WaitForElementVisible(webElement, 30);
        //    //String js = "arguments[0].click();";
        //    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", webElement);
        //    //executescript("document.getElementById('" + id + "').click()")
        //    //JavaScriptLibrary.CallEmbeddedSelenium(driver, "triggerMouseEventAt", webElement, "click", "0,0");

        //    //webElement.SendKeys("");
        //    //Actions userAction = new Actions(driver);
        //    //userAction.MoveToElement(webElement).Build().Perform();
        //    //userAction.SendKeys(Keys.Enter).Perform();
        //    //userAction.MoveToElement(webElement).Click(webElement).Build().Perform();

        //    //String js = "arguments[0].setAttribute('value',' ')";
        //    //((IJavaScriptExecutor)driver).ExecuteScript(js, webElement);
        //    //Thread.Sleep(1000);
        //    //Actions userAction = new Actions(driver);
        //    //userAction.SendKeys(Keys.Enter).Build().Perform();
        //    //Thread.Sleep(1000);
        //}

        public static void ClickOnLinkIE(string elementID)
        {
            //String js = "arguments[0].click();";
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", webElement);

            try
            {
                FocusElement(elementID);
                Thread.Sleep(1000);

                String js = "document.getElementById('" + elementID + "').click();";
                ((IJavaScriptExecutor)driver).ExecuteScript(js);
            }
            catch (Exception)
            {
            }
        }

        public static void ClickOnLinkFocusedIE(string elementID)
        {
            FocusElement(elementID);
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
            Thread.Sleep(1000);
        }

        public static void EnterText(IWebElement webElement, string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }

        public static void EnterTextIE(IWebElement webElement, string text)
        {
            String js = "arguments[0].setAttribute('value','" + text + "')";
            ((IJavaScriptExecutor)driver).ExecuteScript(js, webElement);
        }

        public static void EnterTextIEFocused(string elementID, string text)
        {
            FocusElement(elementID);
            Thread.Sleep(1000);
            AutoItX.Send("" + text + "");
            Thread.Sleep(1000);
        }

        public static void FocusElement(string elementID)
        {
            String js = "document.getElementById('" + elementID + "').focus();";
            ((IJavaScriptExecutor)driver).ExecuteScript(js);
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

        public static bool VerifyCheckboxStatus(IWebElement webElement, string status)
        {
            if (status.ToUpper().Equals("ON"))
            {

                return (webElement.Selected) ? true : false;
            }
            else
            {
                return (webElement.Selected) ? false : true;
            }
        }

        public static void ScrollToElement(IWebDriver Driver, IWebElement element)
        {
            var js = Driver as IJavaScriptExecutor;
            var y = element.Location.Y;
            js.ExecuteScript("javascript:window.scrollBy(0," + y + ")");
        }

        public static void WaitForElementInvisible(int maxTimeOutInSeconds, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
            }
            catch (Exception)
            {

            }
        }

        public static void WaitForElementVisible(IWebElement webElement, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(ElementIsClickable(webElement));
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected element was not visible " + e.Message);
            }
        }

        public static void WaitForElementVisibleEC(By locator, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected element was not visible " + e.Message);
            }
        }

        public static void WaitForFrameAndSwitch(By locator, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(locator));
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected element was not visible " + e.Message);
            }
        }

        public static void WaitForElementClickable(IWebElement webElement, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected element was not clickable " + e.Message);
            }
        }

        public static Func<IWebDriver, IWebElement> ElementHasText(IWebElement webElement, string verify)
        {
            return dr => (webElement.Text.Equals(verify)) ? webElement : null;
        }

        public static Func<IWebDriver, IWebElement> ElementHasValue(IWebElement webElement, string verify)
        {
            return dr => (webElement.GetAttribute("value").Equals(verify)) ? webElement : null;
        }

        public static void WaitUntilElementHasValue(IWebElement webElement, string verify, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(ElementHasValue(webElement, verify));
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected element was not visible " + e.Message);
            }
        }

        public static void WaitUntilElementHasValueEC(IWebElement webElement, string verify, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
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

        public static void WaitForSpinnerInvisible(int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("loading-spinner")));
            }
            catch (Exception e)
            {

            }
        }

        public static bool IsElementDisplayed(By locator)
        {
            if (driver.FindElements(locator).Count() > 0)
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

        public static void SelectComboElementIE(string elementID, string keypressCount = "1")
        {
            FocusElement(elementID);
            Thread.Sleep(1000);
            if (keypressCount == "1")
            {
                AutoItX.Send("{DOWN}");
            }
            else
            {
                AutoItX.Send("{DOWN " + keypressCount + "}");
            }
            Thread.Sleep(1000);
        }

        public static void SelectDirectComboElement(IWebElement ddl, IWebElement optionElement)
        {
            try
            {
                ClickOnLink(ddl);
                ClickOnLink(optionElement);
                WaitForPageLoad(15);
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected combo box option element was not visible " + e.Message);
            }
        }

        //public static void SetUnsetDateIE(bool isSet, string date, string elementID)
        //{
        //    //((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('" + elementID + "').removeAttribute('readOnly',0);");
        //    //((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('" + elementID + "').setAttribute('readonly', false);");
        //    ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('" + elementID + "').readOnly = false;");
        //    if (isSet)
        //    {
        //        driver.FindElement(By.Id(elementID)).SendKeys(date);
        //    }
        //    else
        //    {
        //        driver.FindElement(By.Id(elementID)).Clear();
        //    }

        //    ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('" + elementID + "').readOnly = true;");
        //    //((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('" + elementID + "').setAttribute('readonly', true);");
        //}

        public static void SetUnsetDateIE(IWebElement datepickerElement, bool isSet)
        {
            ClickOnLink(datepickerElement);
            Thread.Sleep(6000);
            if (isSet)
            {
                AutoItX.Send("!{F4}");
                Thread.Sleep(1000);
            }
            else
            {
                AutoItX.Send("+{TAB}");
                Thread.Sleep(1000);
                AutoItX.Send("{ENTER}");
                Thread.Sleep(1000);
            }
        }

        public static bool SearchGridAndVerify(IWebDriver driver, IWebElement Table, string verify, int numberOfHeaderRows, int columnNumber)
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

        //public static Func<IWebDriver, IWebElement> ExpectedTableRows(IWebElement Table, int expectedRows, int numberOfHeaderRows)
        //{
        //    //try
        //    //{
        //    //    return dr => Table.FindElements(By.TagName("tr")).Count().Equals(expectedRows + numberOfHeaderRows) ? Table : null;
        //    //}
        //    //catch (StaleElementReferenceException)
        //    //{
        //    //    //Console.WriteLine("Exception occurred while verifying table row count: " + e.Message);
        //    //    return null;
        //    //}

        //    int trial = 0;
        //    while (trial < 5)
        //    {
        //        try
        //        {
        //            int rowCount = Table.FindElements(By.TagName("tr")).Count();
        //            break;
        //        }
        //        catch (Exception)
        //        {
        //        }

        //        trial++;
        //    }

        //    return dr => Table.FindElements(By.TagName("tr")).Count().Equals(expectedRows + numberOfHeaderRows) ? Table : null;
        //}

        public static Func<IWebDriver, IWebElement> ExpectedTableRows(IWebElement Table, int expectedRows, int numberOfHeaderRows)
        {
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
                Console.WriteLine("Table does not have expected number of rows: " + e.Message);
            }
        }

        public static void PageNavigationMotion(IWebElement tableRow, int numberOfHeaderCols)
        {
            var columnCount = tableRow.FindElements(By.TagName("td")).Count();
            IList<IWebElement> Columns = tableRow.FindElements(By.TagName("td"));

            if (columnCount > numberOfHeaderCols)
            {
                int i;
                for (i = numberOfHeaderCols; i < columnCount;)
                {
                    if (Columns[i].Text.Length > 0)
                    {
                        i++;
                    }
                    else
                    {
                        i--;
                        break;
                    }
                }

                Columns[i].Click();
                WaitForPageLoad(10);
            }
            else
            {
                Assert.True(columnCount.Equals(0), "Pagination not available");
            }
        }

        //public static void SearchGridMotion(IWebElement tableBody, string verify)
        //{
        //    bool found = false;
        //    var rowCount = tableBody.FindElements(By.TagName("span")).Count();
        //    IList<IWebElement> Rows = tableBody.FindElements(By.TagName("span"));

        //    for (int i = 0; i < rowCount;)
        //    {
        //        var columnCount = Rows[i].FindElements(By.TagName("span")).Count();
        //        IList<IWebElement> Columns = Rows[i].FindElements(By.TagName("span"));

        //        for (int j = 0; j < columnCount;)
        //        {
        //            if (Columns[j].Text.Equals(verify))
        //            {
        //                found = true;
        //                Columns[j].Click();
        //                break;
        //            }
        //            else
        //            {
        //                j++;
        //            }
        //        }

        //        if (found)
        //        {
        //            break;
        //        }
        //    }
        //}

        public static void SwitchToWindow(int maxTimeOutInSeconds, int windowNumber)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                string popupWindowHandle = wait.Until<string>((d) =>
                {
                    string foundHandle = null;

                    List<string> allWindowHandles = driver.WindowHandles.ToList();
                    if (allWindowHandles.Count > 1)
                    {
                        foundHandle = allWindowHandles[windowNumber];
                    }

                    return foundHandle;
                });

                driver.SwitchTo().Window(popupWindowHandle);
                driver.Manage().Window.Maximize();
                //Waiting for popup page to load fully
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying to switch window: " + e.Message);
            }
        }

        public static void SwitchToWindowIE(int maxTimeOutInSeconds, int windowNumber)
        {
            try
            {
                string parentWindow = driver.CurrentWindowHandle;
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                string popupWindowHandle = wait.Until<string>((d) =>
                {
                    string foundHandle = null;

                    List<string> allWindowHandles = driver.WindowHandles.ToList();
                    if (!allWindowHandles[windowNumber].Equals(parentWindow))
                    {
                        foundHandle = allWindowHandles[windowNumber];
                    }

                    return foundHandle;
                });

                driver.SwitchTo().Window(popupWindowHandle);
                //Waiting for popup page to load fully
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying to switch window: " + e.Message);
            }
        }

        public static void SwitchToWindowbyTitle(int maxTimeOutInSeconds, int totalWindows, string windowTitle)
        {
            try
            {
                string parentWindow = driver.CurrentWindowHandle;
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.Until<bool>((d) =>
                {
                    bool foundHandle = false;

                    List<string> allWindowHandles = driver.WindowHandles.ToList();
                    if (allWindowHandles.Count == totalWindows)
                    {
                        foreach(string handle in allWindowHandles)
                        {
                            if (driver.SwitchTo().Window(handle).Title == windowTitle)
                            {
                                foundHandle = true;
                                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
                                break;
                            }
                        }
                        if (!foundHandle)
                        {
                            driver.SwitchTo().Window(parentWindow);
                        }
                        return foundHandle;
                    }
                    else
                    {
                        return false;
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying to switch window by title: " + e.Message);
            }
        }

        public static void SwitchToPopup(int maxTimeOutInSeconds, int windowNumber)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                string popupWindowHandle = wait.Until<string>((d) =>
                {
                    string foundHandle = null;

                    List<string> allWindowHandles = driver.WindowHandles.ToList();
                    if (allWindowHandles.Count > 1)
                    {
                        foundHandle = allWindowHandles[windowNumber];
                    }

                    return foundHandle;
                });

                driver.SwitchTo().Window(popupWindowHandle);
                Thread.Sleep(1000);
                //Waiting for popup page to load fully
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying to switch window: " + e.Message);
            }
        }

        public static void SwitchToIFrame(int maxTimeOutInSeconds, int iframeNumber)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                bool iframeWindowHandle = wait.Until((d) =>
                {
                    int iframeCount = driver.FindElements(By.TagName("iframe")).Count;
                    if (iframeCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });

                driver.SwitchTo().Frame(iframeNumber);
                //Waiting for popup page to load fully
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying to switch to iframe: " + e.Message);
            }
        }

        public static void SwitchToFrame(int maxTimeOutInSeconds, By frameLocator)
        {
            try
            {
                //WaitForElementVisible(driver.FindElement(frameLocator), maxTimeOutInSeconds);
                WaitForElementVisibleEC(frameLocator, maxTimeOutInSeconds);
                driver.SwitchTo().Frame(driver.FindElement(frameLocator));
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying to switch to frame: " + e.Message);
            }
        }

        public static void SwitchToBaseWindow()
        {
            try
            {
                driver.SwitchTo().Window(driver.WindowHandles.First());
                //driver.SwitchTo().DefaultContent();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception occurred while trying to switch to base window: " + e.Message);
            }
        }

        //public static void ReTargetLastWindow(By locator)
        //{
        //    int trial = 0;

        //    while (trial < 5)
        //    {
        //        if (driver.FindElements(locator).Count > 0)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            driver.SwitchTo().Window(driver.WindowHandles.First());
        //            Thread.Sleep(1000);
        //            trial++;
        //            driver.SwitchTo().Window(driver.WindowHandles.Last());
        //            Thread.Sleep(1000);
        //            WaitForElementVisibleEC(locator, 10);
        //        }
        //    }
        //}

        public static void ReTargetLastWindow(By locator, int windowNumber)
        {
            int trial = 0;

            while (trial < 5)
            {
                if (driver.FindElements(locator).Count > 0)
                {
                    break;
                }
                else
                {
                    SwitchToWindowIE(15, 0);
                    trial++;
                    SwitchToWindowIE(15, windowNumber);
                    Thread.Sleep(1000);
                    WaitForElementVisibleEC(locator, 10);
                }
            }
        }

        //public static void ReTargetLastWindowWithFrame(By locator, By frameLocator, int windowNumber)
        //{
        //    int trial = 0;

        //    while (trial < 5)
        //    {
        //        if (driver.FindElements(locator).Count > 0)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            SwitchToWindowIE(15, 0);
        //            trial++;
        //            SwitchToWindowIE(15, windowNumber);
        //            Thread.Sleep(1000);
        //            WaitForFrameAndSwitch(frameLocator, 10);
        //        }
        //    }
        //}

        public static void ReTargetLastWindowWithFrame(By locator, By frameLocator, int totalWindows, string windowTitle)
        {
            int trial = 0;

            while (trial < 5)
            {
                if (driver.FindElements(locator).Count > 0)
                {
                    break;
                }
                else
                {
                    trial++;
                    SwitchToWindowbyTitle(15, totalWindows, windowTitle);
                    Thread.Sleep(1000);
                    WaitForFrameAndSwitch(frameLocator, 10);
                }
            }
        }

        public static void SwitchToAlertWindow(int maxTimeOutInSeconds, bool action)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());

                IAlert alert = driver.SwitchTo().Alert();
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
