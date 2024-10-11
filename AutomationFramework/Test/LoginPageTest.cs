using AutomationFramework.Source.Pages;
using AutomationFramework.Utilities;
using OpenQA.Selenium;
using System.Configuration;
using static AutomationFramework.Utilities.Webdrivers;

namespace AutomationFramework.Test
{
    public class LoginPageTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            _driver = getWebDriver(AppSettings.GetSetting("Settings:BrowserType"));
        }

        [Test]
        public void SearchVideo()
        {
            HomePage hp = new HomePage(_driver);


            
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Dispose();
        }
    }
}
