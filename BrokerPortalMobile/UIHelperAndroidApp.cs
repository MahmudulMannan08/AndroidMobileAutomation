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
    class UIHelperAndroidApp : TestBase
    {
        public static void WaitForSpinnerInvisible(int maxTimeOutInSeconds)
        {
            if (androidDriver.FindElements(By.ClassName("android.widget.ProgressBar")).Count() > 0)
            {
                try
                {
                    WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                    wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                    wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                    wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("android.widget.ProgressBar")));
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error while waiting for spinner to be invisible: " + e.Message);
                }
            }
        }

        public static void AcknAlertIfAvailable()
        {
            if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 0)
            {
                androidDriver.FindElement(By.Id("android:id/button2")).Click();
                WaitForSpinnerInvisible(15);
            }
        }

        public static void RefreshAndroidApp()
        {
            var size = androidDriver.Manage().Window.Size;
            int starty = (int)(size.Height * 0.90);
            int endy = (int)(size.Height * 0.20);
            int startx = size.Width / 2;

            //androidDriver.Swipe(startx, endy, startx, starty, 3000);
            TouchAction touchAndroid = new TouchAction(androidDriver);
            touchAndroid.Press(startx, endy).MoveTo(startx, starty).Release().Perform();
            WaitForSpinnerInvisible(30);
        }

        public static void EnterText(IWebElement webElement, string text)
        {
            try
            {
                webElement.Clear();
                webElement.SendKeys(text);
            }
            catch (NoSuchElementException)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 0)
                {
                    androidDriver.FindElement(By.Id("android:id/button2")).Click();
                    WaitForSpinnerInvisible(15);

                    EnterText(webElement, text);
                }
            }
        }

        public static void ClickOnLink(IWebElement webElement)
        {
            try
            {
                UIHelperAndroid.WaitForElementClickable(webElement, 30);
                webElement.Click();
            }
            catch (NoSuchElementException)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 0)
                {
                    androidDriver.FindElement(By.Id("android:id/button2")).Click();
                    WaitForSpinnerInvisible(15);

                    //ClickOnLink(webElement);
                    webElement.Click();
                }
            }
        }

        public static void GoBackAndroid()
        {
            try
            {
                androidDriver.Navigate().Back();
            }
            catch (Exception)
            {
                if (androidDriver.FindElements(By.Id("android:id/button1")).Count > 0)
                {
                    androidDriver.FindElement(By.Id("android:id/button2")).Click();
                    WaitForSpinnerInvisible(15);

                    GoBackAndroid();
                }
            }
        }

        //public static void SwipeToElementAndroid(IWebElement fromElement, IWebElement toElement, string direction)
        //{
        //    var fromX = fromElement.Location.X * 2;
        //    var fromY = fromElement.Location.Y * 0.5;
        //    var toX = toElement.Location.X;
        //    var toY = toElement.Location.Y;

        //    TouchAction touchAndroid = new TouchAction(androidDriver);
        //    switch (direction.ToUpper())
        //    {
        //        case "UP":
        //            touchAndroid.Press(fromX, fromY).MoveTo(fromX, toY).Release().Perform();
        //            break;

        //        case "DOWN":
        //            touchAndroid.Press(fromX, toY).MoveTo(fromX, fromY).Release().Perform();
        //            break;

        //        case "HORIZONTAL":
        //            touchAndroid.Press(toX, fromY).MoveTo(fromX, fromY).Release().Perform();
        //            break;

        //        default:
        //            break;
        //    }
        //}

        public static void SwipeAndroidApp(double fromX, double fromY, string direction)
        {
            TouchAction touchAndroid = new TouchAction(androidDriver);
            switch (direction.ToUpper())
            {
                case "UP":
                    touchAndroid.Press(fromX, fromY - 300).MoveTo(fromX, fromY).Release().Perform();
                    break;

                case "DOWN":
                    touchAndroid.Press(fromX, fromY + 300).MoveTo(fromX, fromY).Release().Perform();
                    break;

                case "RIGHT":
                    touchAndroid.Press(fromX + 200, fromY).MoveTo(fromX, fromY).Release().Perform();
                    break;

                case "LEFT":
                    touchAndroid.Press(fromX - 200, fromY).MoveTo(fromX, fromY).Release().Perform();
                    break;

                default:
                    break;
            }
        }

        public static void SwipeAndroidApp(IWebElement fromElement, IWebElement toElement, string direction)
        {
            TouchAction touchAndroid = new TouchAction(androidDriver);
            switch (direction.ToUpper())
            {
                case "UP":
                    //touchAndroid.Press(fromX, fromY - 300).MoveTo(fromX, fromY).Release().Perform();
                    break;

                case "DOWN":
                    //touchAndroid.Press(fromX, fromY + 300).MoveTo(fromX, fromY).Release().Perform();
                    break;

                case "RIGHT":
                    touchAndroid.Press(toElement).MoveTo(fromElement).Release().Perform();
                    break;

                case "LEFT":
                    //touchAndroid.Press(fromX - 200, fromY).MoveTo(fromX, fromY).Release().Perform();
                    break;

                default:
                    break;
            }
        }

        public static void TapElementByLocation(double xPoint, double yPoint)
        {
            TouchAction touchAndroid = new TouchAction(androidDriver);
            touchAndroid.Tap(xPoint, yPoint).Perform();
        }

        public static Func<IWebDriver, IWebElement> SwipeAndVerify(double fromX, double fromY, IWebElement webElement)
        {
            TouchAction touchAndroid = new TouchAction(androidDriver);
            touchAndroid.Press(fromX, fromY + 100).MoveTo(fromX, fromY).Release().Perform();

            return dr => (webElement.Displayed && webElement.Enabled) ? webElement : null;
        }

        public static void SwipeToElementAndroidApp(double fromX, double fromY, IWebElement webElement, int maxTimeOutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(maxTimeOutInSeconds));
                wait.PollingInterval = TimeSpan.FromMilliseconds(10);
                wait.Timeout = TimeSpan.FromSeconds(maxTimeOutInSeconds);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                wait.Until(SwipeAndVerify(fromX, fromY, webElement));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured while swiping to element " + e.Message);
            }
        }
    }
}
