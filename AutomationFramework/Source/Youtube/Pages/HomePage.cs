using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Source.Youtube.Pages
{
    public class HomePage: ElementInteractivity
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());

        private IWebElement _searchBox => _driver.FindElement(By.Name("search_query"));
        private IWebElement _searchButton => _driver.FindElement(By.Id("search-icon-legacy"));
        private IWebElement _dumby => _driver.FindElement(By.Id("chips")); 
        private IWebElement _topVideoName => _driver.FindElement(By.Id("(//*[@id='video-title']/yt-formatted-string)[1]"));

        public void UseSearchBox(string searchText)
        {
            _searchBox.SendKeys(searchText);
            ClickElement(_searchBox);
        }
    }
}