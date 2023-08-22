using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Thermon.CompuTrace.UI.Automation.Hook;
using Xunit;

namespace Thermon.CompuTrace.UI.Automation.StepDefinitions
{
    [Binding]
    public class FeedbackDialogSteps
    {
       
        public FeedbackDialogSteps()
        {
           // this.driver = driver;
        }

        [Given(@"I click on Feedback button")]
        public void WhenIClickFeedbackButton()
        {
            IWebElement feedbackButton = Driver.Instance.FindElement(By.XPath("//*[@id='root']/div[2]/header/div/header/div/div[3]/div/div[1]/div/button"));
            feedbackButton.Click();
        }


        [When(@"I enter username '([^']*)'")]
        public void WhenIEnterThermonUsername(string username)
        {

            IWebElement usernameInput = Driver.Instance.FindElement(By.Name("name"));
            usernameInput.SendKeys(username);
        }


        [When(@"I enter email '([^']*)'")]
        public void WhenIEnterThermonEmail(string email)
        {
            IWebElement passwordInput = Driver.Instance.FindElement(By.Name("email"));
            passwordInput.SendKeys(email);
        }



        [When(@"I enter feedback '([^']*)'")]
        public void WhenIEnterFeedback(string feedback)
        {

            IWebElement feedbackColumn = Driver.Instance.FindElement(By.Name("comments"));
            feedbackColumn.SendKeys(feedback);
        }


        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            IWebElement submitButton = Driver.Instance.FindElement(By.XPath("//button[@type='submit']"));
            submitButton.Click();
        }



        //[Then(@"I should be able to see Feedback is submitted")]
        //public void ThenIShouldBeAbleToSeeFeedbackIsSubmitted()
        //{
        //    var successMessage = driver.FindElement(By.Id(""));
        //    Assert.True(successMessage.Displayed);
        //}

    }
}
