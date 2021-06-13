using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Todo.UIAutomatedTests.Pages;

namespace Todo.UIAutomatedTests.StepDefinitions
{
    [Binding]
    public sealed class ViewTodoSteps : BaseSteps
    {

        [Given(@"I click on items")]
        public void GivenIClickOnItems()
        {
            On<TodoPage>().ClickOnItems();
        }

        [When(@"I click on todo item with title ""(.*)""")]
        public void WhenIClickOnTodoItemWithTitle(string title)
        {
            On<TodoPage>().ClickOnItemWithTitle(title);
        }

        [Then(@"I should see the todo item details")]
        public void ThenIShouldSeeTheTodoItemDetails()
        {
            On<TodoPage>().VerifyTodoItemDetails();
        }

    }
}
