using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Todo.UIAutomatedTests.Pages;

namespace Todo.UIAutomatedTests.StepDefinitions
{
    [Binding]
    public sealed class LogInSteps : BaseSteps
    {
        [Given(@"I navigated to the todo application page")]
        public void GivenINavigatedToTheTodoApplicationPage()
        {
            On<LogInPage>().GotoUrl();
        }

        [Given(@"I enter username ""(.*)""")]
        public void GivenIEnterUsername(string username)
        {
            On<LogInPage>().EnterUsername(username);
        }

        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string password)
        {
            On<LogInPage>().EnterPassword(password);
        }

        [Given(@"I click on the login button")]
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            On<LogInPage>().ClickLogInButton();
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            On<LogInPage>().VerifySuccessLogIn();
        }
        


    }
}
