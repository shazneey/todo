using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.UIAutomatedTests.Pages
{
    public class TodoPage : MainPage
    {
        private const string HomePageTitle = "Todo Application";

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'svg-inline--fa fa-plus fa-w-14 fa-2x')]")]
        public IWebElement AddTodoItem { get; set; }

        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement Save { get; set; }

        [FindsBy(How = How.XPath, Using = "	//a[contains(text(),'Items')]")]
        public IWebElement Items { get; set; }


        public void ClickAddIcon()
        {
            AddTodoItem.Click();
        }

        public void EnterTitle(string title)
        {
            SendTextToIWebElement(Title, title);
        }

        public void ClickOnItems()
        {
            Items.Click();
        }

        public void EnterDescription(string descr)
        {
            SendTextToIWebElement(Description, descr);
        }

        public void ClickOnItemWithTitle(string title)
        {
            throw new NotImplementedException();
        }

        public void ClickSave()
        {
            Save.Click();
        }

        public void VerifyTodoItemCreated()
        {
            throw new NotImplementedException();
        }

        public void ClickOnTodoItem(string item)
        {
            throw new NotImplementedException();
        }

        public void VerifyTodoItemDetails()
        {
            throw new NotImplementedException();
        }
    }
}
