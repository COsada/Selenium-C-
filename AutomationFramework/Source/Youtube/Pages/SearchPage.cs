using AngleSharp.Dom;
using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Source.Youtube.Pages
{
    public class SearchPage
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
        private IWebElement _chips => _driver.FindElement(By.CssSelector("#chip-bar"));
        private IWebElement _topVideoName => _driver.FindElement(By.XPath("(//*[@id='video-title']/yt-formatted-string)[1]"));

        public void ClickTopVideo()
        {
            ElementInteractives.ClickElement(_topVideoName);
        }

        public string GetTopVideoName()
        {
            return _topVideoName.Text;
        }
        //public void WaitForChips(int time)
        //{
        //    //WaitForElements(_chips, time);
        //    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
        //    wait.Until(d => _chips.Displayed && _chips.Enabled);
        //}
    }
}
