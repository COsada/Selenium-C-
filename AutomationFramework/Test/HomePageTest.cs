using OpenQA.Selenium;
using AutomationFramework.Source.Pages;
using AutomationFramework.Core;
using static AutomationFramework.Utilities.Webdrivers;
using AutomationFramework.Utilities;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Runtime;

namespace AutomationFramework.Test
{
    public class HomePageTest
    {
        private IWebDriver _driver;
        private string browserType;



        [SetUp]
        public void InitScript()
        {
            _driver = getWebDriver(AppSettings.GetSetting("BrowserType"));
        }

        [Test]
        public void SearchVideo()
        {
            HomePage hp = new HomePage(_driver);
            Wrappers wr = new Wrappers(_driver);

            _driver.Navigate().GoToUrl("https://www.youtube.com");
            hp.UseSearchBox("funny cat videos");
            hp.WaitForChips(_driver);

            Assert.True(_driver.Title.Contains("funny") && _driver.Title.Contains("cat") && _driver.Title.Contains("videos"));
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Dispose();
        }
    }
}
