using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using Thermon.CompuTrace.UI.Automation.Hook;
using Thermon.CompuTrace.UI.Automation.Utils;


namespace Thermon.CompuTrace.UI.Automation.StepDefinitions
{
    [Binding]
    public class UserProfilePageSteps
    {
        ScenarioContext _scenarioContext;
        public UserProfilePageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //Add Connection String

        [Given(@"I click User Profile button")]
        public void GivenIClickUserProfileButton()
        {
            IWebElement userProfileButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'User Profile')]"));
            userProfileButton.Click();
        }
      

        [When(@"I click on Add connection button & enter the details and click on save button")]
        public void WhenIEnterAddConnectionDetailsAndClickOnSaveButton(Table table)
        {
            var entries = table.CreateSet<UserProfile>();
            var Count = entries.Count<UserProfile>();
           
            _scenarioContext.Add("itemsCount", Count);
            foreach (UserProfile item in entries)
            {
                IWebElement addConnectionButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Add connection')]"));
                addConnectionButton.Click();
                Driver.Instance.FindElement(By.Name("connectionName")).SendKeys(item.connectionName);
                Driver.Instance.FindElement(By.Name("connectionString")).SendKeys(item.connectionString);

                //click on save button
                Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Save')]")).Click();
                Thread.Sleep(3000);
              
            }

        }      

        [Then(@"I should see connection string added")]
        public void ThenIShouldSeeConnectionStringAdded()
        {
            List<IWebElement> addedItemElement = Driver.Instance.FindElements(By.XPath("//div[contains(@class,'MuiDataGrid-virtualScrollerRenderZone')]//div[@role='row']")).ToList();
            Assert.True(addedItemElement.Count.Equals(_scenarioContext["itemsCount"]), "All connection strings are not added");

            //Delete all records
           // int row = 1;
            foreach (IWebElement itemElement in addedItemElement)
            {
                Driver.Instance.FindElement(By.XPath("//button[@aria-label='Delete connection']")).Click();
                //click on delete button on pop up
                Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Delete')]")).Click();
                Thread.Sleep(3000);


                //row++;
            }
        }


        //User Profile

        [When(@"I enter User Domain Name '([^']*)'")]
        public void WhenIEnterUserDomainName(string userDomainName)
        {

            IWebElement userDomainNameInput = Driver.Instance.FindElement(By.XPath("//input[@placeholder='User Domain Name']"));
            userDomainNameInput.Click();
            userDomainNameInput.Clear();
            userDomainNameInput.SendKeys(userDomainName);
        }


        [When(@"I click Update button")]
        public void WhenIClickUpdateButton()
        {
            IWebElement updateButton = Driver.Instance.FindElement(By.XPath("//button[contains(text()='Update'])"));
            updateButton.Click();
        }


        [Then(@"I should see success message")]
        public void ThenIShouldSeeSuccessMessage()
        {   
            IWebElement successMessage = Driver.Instance.FindElement(By.XPath("//h6[contains(text(),'Profile updated')]"));
            Assert.True(successMessage.Displayed, "Failed to update the profile");

        }


        //User Profile as a different user

        [When(@"I enter user name '([^']*)'")]
        public void WhenIEnterUserName(string userName)
        {

            IWebElement userNameInput = Driver.Instance.FindElement(By.Name("userName"));
            userNameInput.Click();
            userNameInput.Clear();
            userNameInput.SendKeys(userName);

        }


        [When(@"I enter user email '([^']*)'")]
        public void WhenIEnterUserEmail(string userEmail)
        {

            IWebElement userEmailInput = Driver.Instance.FindElement(By.Name("email"));
            userEmailInput.Click();
            userEmailInput.Clear();
            userEmailInput.SendKeys(userEmail);

        }

    }
}
