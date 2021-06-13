using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Todo.UIAutomatedTests.Pages
{
    public class LogInPage : MainPage
    {
        private const string HomePageTitle = "Todo Application";

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-lg btn-primary btn-block']")]
        public IWebElement LogIn { get; set; }


        public void GotoUrl()
        {
            var url = ConfigurationManager.AppSettings["Url"];
            GoToUrl(url);
        }

        public void EnterUsername(string username)
        {
            SendTextToIWebElement(Username, username);
        }

        public void EnterPassword(string password)
        {
            SendTextToIWebElement(Password, password);
        }

        public void ClickLogInButton()
        {
            LogIn.Click();
        }

        public void VerifySuccessLogIn()
        {
            WaitForTitle(HomePageTitle);
            Assert.AreEqual(HomePageTitle, PageTitle());
        }
    }
}
