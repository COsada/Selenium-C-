using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Source.Youtube.Pages
{
    public class SearchPage: ElementInteractivity
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
        private IWebElement _dumby => _driver.FindElement(By.Id("chips"));
        private IWebElement _topVideoName => _driver.FindElement(By.Id("(//*[@id='video-title']/yt-formatted-string)[1]"));

        public void ClickTopVideo()
        {
            ClickElement(_topVideoName);
        }

        public string GetTopVideoName()
        {
            return _topVideoName.Text;
        }
        public void WaitForChips(int time)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
            wait.Until(d => _dumby.Displayed);
        }
    }
}
