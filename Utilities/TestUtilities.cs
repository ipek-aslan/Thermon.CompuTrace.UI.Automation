global using TechTalk.SpecFlow;
global using Xunit;
using AngleSharp.Dom;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Thermon.CompuTrace.UI.Automation.Hook;

namespace Thermon.CompuTrace.UI.Automation.Utilities
{
    public static class TestUtilities
    {
        public static int Timeout = 40;

       // public static IWebDriver Driver { get; set; }

        public static void InitializeTest()
        {
            Driver.Instance = new ChromeDriver(Environment.CurrentDirectory);
            Driver.Instance.Manage().Window.Maximize();
            Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Timeout);
        }

        public static void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }



        public static void ScrollToView(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)", element);
        }

        public static bool Exists(By elementBy)
        {
            try
            {
                return Driver.Instance.FindElement(elementBy).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool Exists(IWebElement baseElement, By elementBy)
        {
            try
            {
                return baseElement.FindElement(elementBy).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static void SelectBy(IWebElement element, String value, String methodName)
        {
            SelectElement select = new SelectElement(element);
            switch (methodName)
            {
                case "text":
                    select.SelectByText(value);
                    break;
                case "index":
                    select.SelectByIndex((int)Int64.Parse(value));
                    break;
                case "value":
                    select.SelectByValue(value);
                    break;
                default:
                    Console.WriteLine("Method name is not available. Use text, index or value for method name.");
                    break;
            }
        }

        public static void ExplicitWait()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public static void Click(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", element);
        }

        public static string GetRandomNumber(int length)
        {
            Random random = new Random();
            const string pool = "0123456789";
            var chars = Enumerable.Range(0, length)
                .Select(x => pool[random.Next(0, pool.Length)]);
            var NumberString = new string(chars.ToArray());
            return (NumberString);
        }

        public static string GetRandomString(int length)
        {
            Random random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz";
            var chars = Enumerable.Range(0, length)
                .Select(x => pool[random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }

        public static void RefreshPage()
        {
            Driver.Instance.Navigate().Refresh();
        }
    }
}

