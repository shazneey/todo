using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;

namespace Todo.UIAutomatedTests.Pages
{
    public class MainPage : IVerifiable
    {
        private WebDriverWait _wait;


        protected MainPage()
        {
            PageFactory.InitElements(Browser.Current, this);
        }
        public void WaitForTitle(string title, TimeSpan? timeout = null)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Current, timeout ?? TimeSpan.FromSeconds(30));
            wait.Until((d) => { return d.Title == title; });
        }

        private const int TimeoutSeconds = 30;

        protected WebDriverWait Wait => _wait ?? (_wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(TimeoutSeconds))
        {
            PollingInterval = TimeSpan.FromMilliseconds(10000)
        });


        public static void GoToUrl(string url)
        {
            Browser.Current.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TimeoutSeconds);
            Browser.Current.Navigate().GoToUrl(url);
        }


        public IWebElement WaitForElementToBeClickable(IWebElement element)
        {
            Wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException), typeof(StaleElementReferenceException));
            return Wait.Until(ElementIsClickable(element));
        }

        private static Func<IWebDriver, IWebElement> ElementIsClickable(IWebElement element)
        {
            return driver => (element != null && element.Displayed && element.Enabled) ? element : null;
        }

        public void SendTextToIWebElement(IWebElement element, string textToSend)
        {
            WaitForElementToBeClickable(element).Click();
            element.Clear();
            element.SendKeys(textToSend);
        }

        public string PageTitle()
        {
            return Browser.Current.Title;
        }

        public void CloseBrowser()
        {
            Browser.Current.Close();
        }


        public void Verify()
        {
        }
    }
}
