using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Source.Youtube.Pages
{
    public class VideoPage
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
        private IWebElement _videoTitle => _driver.FindElement(By.CssSelector("#title > h1 > yt-formatted-string"));
        private IWebElement _videoPlayer => _driver.FindElement(By.Id("player"));
        private IWebElement _likeDislikeButtons => _driver.FindElement(By.Id("top-level-buttons-computed"));
        private IWebElement _subscribeButton => _driver.FindElement(By.CssSelector("subscribe-button"));
        private IWebElement _videoDescription => _driver.FindElement(By.Id("description"));
        private IWebElement _commentSection => _driver.FindElement(By.Id("comments"));
        private IWebElement _videoSidebar => _driver.FindElement(By.Id("related"));

        public bool CheckVideoTitle(string expectedTitle)
        {
            return _videoTitle.Text.Equals(expectedTitle);
        }
        public bool CheckForVideoPlayer()
        {
            return ElementInteractives.SearchElement(_videoPlayer);
        }
        public bool CheckForLikeDislikeButtons()
        {
            return ElementInteractives.SearchElement(_likeDislikeButtons);
        }
        public bool CheckForSubscribeButton()
        {
            return ElementInteractives.SearchElement(_subscribeButton);
        }
        public bool CheckForVideoDescription()
        {
            return ElementInteractives.SearchElement(_videoDescription);
        }
        public bool CheckForCommentSection()
        {
            return ElementInteractives.SearchElement(_commentSection);
        }
        public bool CheckForNewVideoSidebar()
        {
            return ElementInteractives.SearchElement(_videoSidebar);
        }
    }
}
