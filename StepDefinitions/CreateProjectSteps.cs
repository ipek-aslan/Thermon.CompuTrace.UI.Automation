using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.ComponentModel;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Thermon.CompuTrace.UI.Automation.Hook;
using Thermon.CompuTrace.UI.Automation.Utilities;

namespace Thermon.CompuTrace.UI.Automation.StepDefinitions
{
    [Binding]
    public sealed class CreateProjectSteps
    {

        public CreateProjectSteps()
        {
            
        }


        [Given(@"I click Dashboard button")]
        public void GivenIClickDashboardButton()
        {
            IWebElement dashboardButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'dashboard')]"));
            dashboardButton.Click();
        }


        [When("I click on Create Project")]
        public void WhenIClickOnCreateProject()
        {
            IWebElement createProjectButton = Driver.Instance.FindElement(By.XPath("//button[@aria-label='Create project']"));
            createProjectButton.Click();
        }



        [When(@"I enter project name")]
        public void WhenIEnterProjectName()
        {
           string projectName=TestUtilities.GetRandomString(8);
            //Random random = new Random();
            IWebElement projectNameInput = Driver.Instance.FindElement(By.Name("projectName"));
            projectNameInput.SendKeys("QA-UI-Automation "+projectName);
            Thread.Sleep(1000);
        }


        [When(@"I enter project number")]
        public void WhenIEnterProjectNumber()
        {
            string projectNumber=TestUtilities.GetRandomNumber(6);
            IWebElement projectNumberInput = Driver.Instance.FindElement(By.Name("projectNumber"));
            projectNumberInput.Click();
            projectNumberInput.SendKeys(projectNumber);
            
        }

        [When("I click on location column")]
        public void WhenIClickOnLocationColumn()
        {

            IWebElement locationColumn = Driver.Instance.FindElement(By.Name("location"));
            locationColumn.Click();
        }


        [When(@"I click on Next button on Project Reference page")]
        public void WhenIClickOnNextButtonProjectReferencePage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();

        }

        [When(@"I select default project units")]
        public void WhenISelectDefaultProjectUnits(Table table)
        {
            var projectUnit = table.CreateInstance<Utils.CreateProject>();
            Driver.Instance.FindElement(By.XPath("//input[@name='pipeInsulationUnits'][@value='" + projectUnit.PipeUnits + "']")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@name='temperatureUnits'][contains(@value,'" + projectUnit.TemperatureUnits + "')]")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@name='otherUnits'][contains(@value,'" + projectUnit.OtherUnits + "')]")).Click();
            TestUtilities.ScrollToElement(Driver.Instance.FindElement(By.XPath("//div[contains(text(),'ATEX: Ordinary/Zones')]")));
            Thread.Sleep(1000);
            Driver.Instance.FindElement(By.XPath("//div[@id='mui-component-select-electricalCodeAndStandarts']")).Click();
            
            List<IWebElement> listbox = Driver.Instance.FindElements(By.XPath("//ul[@role='listbox']/li")).ToList();
            foreach(var element in listbox) 
            {
                if(element.GetAttribute("data-value").Contains(projectUnit.ElectricalCodes))
                element.FindElement(By.XPath("//ul[@role='listbox']/li[@data-value='" + projectUnit.ElectricalCodes+"']")).Click();
                break;
            
            }
        }

        [When(@"I click on Next button on Set Project Units page")]
        public void WhenIClickOnNextButtonOnSetProjectUnitsPage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();

        }


        [When(@"I click on Next button on Design Defaults page")]
        public void WhenIClickOnNextButtonDesignDefaultsPage()
        {
            IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
            nextButton.Click();
        }


        [When(@"I click on Finish button on Advance Configuration page")]
        public void WhenIClickOnFinishButtonOnAdvanceConfigurationPage()
        {
            IWebElement finishButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Finish')]"));
            finishButton.Click();
        }

        [Then("I should be able to see project created")]
        public void ThenIShouldBeAbleToSeeProjectCreated()
        {

            var saveButton = Driver.Instance.FindElement(By.XPath("//button[@aria-label=('Save')]"));
            Assert.True(saveButton.Displayed, "Save button is not visible.");

        }

    }
}
