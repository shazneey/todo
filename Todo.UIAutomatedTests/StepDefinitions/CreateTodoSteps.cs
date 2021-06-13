using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Todo.UIAutomatedTests.Pages;

namespace Todo.UIAutomatedTests.StepDefinitions
{
    [Binding]
    public sealed class CreateTodoSteps : BaseSteps
    {

        [Given(@"I click on the Add todo icon")]
        public void GivenIClickOnTheAddTodoIcon()
        {
            On<TodoPage>().ClickAddIcon();
        }

        [Given(@"I enter title ""(.*)""")]
        public void GivenIEnterTitle(string title)
        {
            On<TodoPage>().EnterTitle(title);
        }

        [Given(@"I enter description ""(.*)""")]
        public void GivenIEnterDescription(string descr)
        {
            On<TodoPage>().EnterDescription(descr);
        }

        [When(@"I click on the save button")]
        public void WhenIClickOnTheSaveButton()
        {
            On<TodoPage>().ClickSave();
        }

        [Then(@"The todo should be craeted successfully")]
        public void ThenTheTodoShouldBeCraetedSuccessfully()
        {
            On<TodoPage>().VerifyTodoItemCreated();
        }

        [When(@"I click on the todo item ""(.*)""")]
        public void WhenIClickOnTheTodoItem(string item)
        {
            On<TodoPage>().ClickOnTodoItem(item);
        }

        [Then(@"I should see all the todo item details")]
        public void ThenIShouldSeeAllTheTodoItemDetails()
        {
            On<TodoPage>().VerifyTodoItemDetails();
        }

    }
}
