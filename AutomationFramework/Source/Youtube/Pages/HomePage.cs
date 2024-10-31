using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Source.Youtube.Pages
{
    public class HomePage
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());

        private IWebElement _searchBox => _driver.FindElement(By.Name("search_query"));
        private IWebElement _searchButton => _driver.FindElement(By.Id("search-icon-legacy"));

        public void UseSearchBox(string searchText)
        {
            _searchBox.SendKeys(searchText);
            ElementInteractives.ClickElement(_searchButton);
        }
    }
}