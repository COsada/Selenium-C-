using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using AutomationFramework.Source.Pages;

namespace AutomationFramework.Test
{
    public class HomePageTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(
                new EdgeConfig(), version:"Latest"
                );
            _driver = new EdgeDriver();
        }

        [Test]
        public void SearchVideo()
        {
            HomePage hp = new HomePage(_driver);
            
            _driver.Navigate().GoToUrl("https://www.youtube.com");
            hp.UseSearchBox("funny cat videos");
            Assert.True(_driver.Title.Contains("funny") && _driver.Title.Contains("cat") && _driver.Title.Contains("videos"));
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Dispose();
        }
    }
}
