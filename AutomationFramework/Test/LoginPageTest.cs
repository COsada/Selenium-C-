using AutomationFramework.Source.Pages;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace AutomationFramework.Test
{
    public class LoginPageTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(
                new EdgeConfig(), version: "Latest"
                );
            _driver = new EdgeDriver();
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
