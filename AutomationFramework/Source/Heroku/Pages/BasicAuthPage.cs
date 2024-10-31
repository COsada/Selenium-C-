using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Source.Heroku.Pages
{
    public class BasicAuthPage
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
        private IWebElement _pageTitle => _driver.FindElement(By.CssSelector("#content > * > h3"));
        private IWebElement _titleSubText => _driver.FindElement(By.CssSelector("#content > * > p"));
        private string credentials = TestData.GetHerokuInformation("TestVariables:BasicAuth:Credentials");

        public void EnterCredentials()
        {
            _driver.Navigate().GoToUrl(credentials);
        }
        public bool CheckForTitle()
        {
            return ElementInteractives.SearchElement(_pageTitle, TestData.GetHerokuInformation("TestVariables:BasicAuth:Title"));
        }
        public bool CheckForContent()
        {
            return ElementInteractives.SearchElement(_titleSubText, TestData.GetHerokuInformation("TestVariables:BasicAuth:Content"));
        }
    }
}
