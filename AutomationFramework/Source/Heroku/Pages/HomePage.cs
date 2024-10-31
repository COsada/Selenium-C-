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
        private IWebElement _linkFromListByIndex;

        public bool CheckForTitle()
        {
            if(ElementInteractives.SearchElement(_pageTitle, "Welcome to the-internet"))
            {
                return true;
            }
            return false;
        }
        public bool CheckForSubTitle()
        {
            if (ElementInteractives.SearchElement(_pageSubTitle, "Available Examples"))
            {
                return true;
            }
            return false;
        }
        public bool CheckForListOfLinks()
        {
            if (ElementInteractives.SearchElement(_listOfLinks))
            {
                return true;
            }
            return false;
        }
        public void ClickHomePageLinkByGivenIndex(int index)
        {
            _linkFromListByIndex = _driver.FindElement(By.XPath("//*[@id='content']//li[" + index + "]/a"));
            _linkFromListByIndex.Click();
        }
    }
}