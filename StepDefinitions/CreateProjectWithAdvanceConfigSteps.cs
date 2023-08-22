using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thermon.CompuTrace.UI.Automation.Hook;

namespace Thermon.CompuTrace.UI.Automation.StepDefinitions
{
    [Binding]
    public class CreateProjectWithAdvanceConfigSteps
    { 

        public CreateProjectWithAdvanceConfigSteps()
        {
            
        } 
            
            [When("I click on Advance Configuration checkbox")]
            public void WhenIClickOnAdvanceConfigurationCheckbox()
            {
                IWebElement advanceConfigCheckbox = Driver.Instance.FindElement(By.XPath("//span[contains(text(),'Advanced Configuration')]"));
                advanceConfigCheckbox.Click();
            }


            [When(@"I click on Next button on Advance Configuration page")]
            public void WhenIClickOnNextButtonOnAdvanceConfigurationPage()
            {
                IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
                nextButton.Click();
            }


            [When("I click on Next button on Templates for Custom BoM Entries page")]
            public void WhenIClickOnNextButtonOnTemplatesForCustomBoMEntriesPage()
            {
                IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
                nextButton.Click();
            }


            [When("I click on Next button on Project Miscellaneous Defaults page")]
            public void WhenIClickOnNextButtonOnProjectMiscellaneousDefaultsPage()
            {
                IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
                nextButton.Click();
            }


            [When("I click on Next button on Project Level Custom Components")]
            public void WhenIClickOnNextButtonOnProjectLevelCustomComponents()
            {
                IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
                nextButton.Click();
            }


            [When("I click on Next button on Project Extra Requirements")]
            public void WhenIClickOnNextButtonOnProjectExtraRequirements()
            {
                    IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
                    nextButton.Click();
            }


            [When("I click on Next button on Project Available Components")]
            public void WhenIClickOnNextButtonOnProjectAvailableComponents()
            {
                IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
                nextButton.Click();
            }


            [When("I click on Next button on Project Tag Defaults")]
            public void WhenIClickOnNextButtonOnProjectTagDefaults()
            {
                IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
                nextButton.Click();
            }


            [When("I click on Next button on Circuit Reference Drawing List")]
            public void WhenIClickOnNextButtonOnCircuitReferenceDrawingList()
            {
                IWebElement nextButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Next')]"));
                nextButton.Click();
            }



            [When(@"I click on Finish button on Circuit Reference Drawing List")]
            public void WhenIClickOnFinishButtonOnCircuitReferenceDrawingList()
            {
                IWebElement finishButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Finish')]"));
                finishButton.Click();
            }



            [Then("I should be able to see project created with Advance Configuration")]
            public void ThenIShouldSeeProjectCreatedWithAdvanceConfiguration()
            {
                var saveButton = Driver.Instance.FindElement(By.XPath("//button[@aria-label=('Save')]"));
                Assert.True(saveButton.Displayed, "Save button is not visible.");
            }
        }

}





