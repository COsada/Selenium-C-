using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Source.Youtube.Pages
{
    public class VideoPage: ElementInteractivity
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
        private IWebElement _topVideoName => _driver.FindElement(By.Id("(//*[@id='video-title']/yt-formatted-string)[1]"));

        public void ClickTopVideo()
        {
            ClickElement(_topVideoName);
        }
    }
}
