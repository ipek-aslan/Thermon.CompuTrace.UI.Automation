using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thermon.CompuTrace.UI.Automation.Hook;

namespace Thermon.CompuTrace.UI.Automation.StepDefinitions
{
    [Binding]
    public class ProjectDashboardSteps
    {

        private IWebDriver driver;

        public void VerifyListOfProjects()
        {
            // Create a new instance of the ChromeDriver
            using (IWebDriver driver = new ChromeDriver())
            {

               
                ReadOnlyCollection<IWebElement> projectElements = driver.FindElements(By.Name("project"));

                
                List<string> expectedProjectNames = new List<string>
                {
                    "Project 1",
                    "Project 2",
                    "Project 3"
                };

                Assert.Equal(expectedProjectNames.Count, projectElements.Count);

               
                for (int i = 0; i < projectElements.Count; i++)
                {
                    string actualProjectName = projectElements[i].Text;
                    string expectedProjectName = expectedProjectNames[i];

                    Assert.Equal(expectedProjectName, actualProjectName);
                }
            }


        }


            [When(@"I click on Dashboard button")]
            public void WhenIClickOnHomeButton()
            {
                
                IWebElement dashboardButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'dashboard')]")); 
                dashboardButton.Click();
            }


            [Then(@"I should see the CompuTrace Home Page")]
            public void ThenIShouldSeeTheCompuTraceHomePage()
            {
                // Assert that you are on the expected page (CompuTrace Home Page)
                string expectedTitle = "Welcome to CompuTrace"; 
                string actualTitle = driver.Title;
                Assert.Equal(expectedTitle, actualTitle);
            }

            
        }

    }


