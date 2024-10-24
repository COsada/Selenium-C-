using OpenQA.Selenium;
using AutomationFramework.Utilities;


namespace AutomationFramework.Source.Youtube
{
    public class BaseTest
    {
        public IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(TestVariables.GetYoutubeHomePageUrl());
        }

        [TearDown]
        public void Cleanup()
        {
            try
            {
                _driver.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
