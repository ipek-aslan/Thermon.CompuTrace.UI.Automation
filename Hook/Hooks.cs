using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium;

namespace Thermon.CompuTrace.UI.Automation.Hook
{
    [Binding]
    public sealed class Hooks
    {
        //public static ChromeDriver ChromeDriver { get; private set; }
        public static int Timeout = 40;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            //string username = "svc-cptautomation@thermon.onmicrosoft.com";
            //string password = "Fon48413";
            var driver = new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            
            options.AddArgument("--ignore-ssl-errors=yes");
            options.AddArgument("--ignore-certificate-errors");
            Driver.Instance = new ChromeDriver(options);
            Driver.Instance.Manage().Window.Maximize();
            Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Timeout);
            Driver.Instance.Navigate().GoToUrl("https://devweb002.eastus2.cloudapp.azure.com/#/dashboard");
            Driver.Instance.FindElement(By.XPath("//button[contains(text(),'LOGIN')]")).Click();
            Driver.Instance.FindElement(By.Name("loginfmt")).SendKeys("svc-cptautomation@thermon.onmicrosoft.com");
            Thread.Sleep(3000);
            Driver.Instance.FindElement(By.Id("idSIButton9")).Click();
            Driver.Instance.FindElement(By.Name("passwd")).SendKeys("Fon48413");
            Thread.Sleep(3000);
            Driver.Instance.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(3000);
            Driver.Instance.FindElement(By.Id("idSIButton9")).Click();
            Thread.Sleep(1000);

            //Driver.Instance.FindElement(By.XPath("//div[contains(text(),'svc-cptautomation@thermon.onmicrosoft.com')]")).Click();
            //Driver.Instance.FindElement(By.Id("continueButton")).Click();
            //Driver.Instance.FindElement(By.XPath("//input[@type='submit']")).Click();
            //Driver.Instance.Navigate().GoToUrl("https://" + username + ":" + password + "@" + "//adfs.thermon.com/"); 
            //Driver.Instance.FindElement(By.Id("idSIButton9")).Click();

        }


        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Instance.Quit();
            Driver.Instance.Dispose();
        }
    }
}