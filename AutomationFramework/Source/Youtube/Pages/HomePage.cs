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
        private IWebElement _signInLink => _driver.FindElement(By.XPath("//*[@id='buttons']/ytd-button-renderer"));
        private IWebElement _dumby => _driver.FindElement(By.Id("chips"));

        public void UseSearchBox(string searchText)
        {
            _searchBox.SendKeys(searchText);
            _searchButton.Click();
        }

        public void ClickSignInLink()
        {
            _signInLink.Click();
        }

        public void WaitForChips(int time)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
            wait.Until(d => _dumby.Displayed);
        }
    }
}