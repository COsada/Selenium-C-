using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Source.Heroku.Pages
{
    public class HomePage
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
        //private IWebDriver _driver = new EdgeDriver();

        private IWebElement _pageTitle => _driver.FindElement(By.XPath("//*[@id='content']/h1"));
        private IWebElement _pageSubTitle => _driver.FindElement(By.XPath("//*[@id='content']/h2"));
        private IWebElement _listOfLinks => _driver.FindElement(By.XPath("//*[@id='content']/ul"));
        private IWebElement _addRemoveLink => _driver.FindElement(By.XPath("//*[@id='content']//li[2]/a"));

        public bool CheckForTitle()
        {
            if(_pageTitle.Displayed && _pageTitle.Enabled && _pageTitle.Text.Equals("Welcome to the-internet") && _pageTitle.Size.Width > 10 && _pageTitle.Size.Height > 10)
            {
                return true;
            }
            return false;
        }
        public bool CheckForSubTitle()
        {
            if (_pageSubTitle.Displayed && _pageSubTitle.Enabled && _pageSubTitle.Text.Equals("Available Examples") && _pageSubTitle.Size.Width > 10 && _pageSubTitle.Size.Height > 10)
            {
                return true;
            }
            return false;
        }
        public bool CheckForListOfLinks()
        {
            if (_listOfLinks.Displayed && _listOfLinks.Enabled && _listOfLinks.Size.Width > 10 && _listOfLinks.Size.Height > 10)
            {
                return true;
            }
            return false;
        }
        public bool CheckForHomepageUrl()
        {
            //Comeback here
            if (_listOfLinks.Displayed && _listOfLinks.Enabled && _listOfLinks.Size.Width > 10 && _listOfLinks.Size.Height > 10)
            {
                return true;
            }
            return false;
        }
        public void ClickAddRemoveLink()
        {
            _addRemoveLink.Click();
        }
    }
}