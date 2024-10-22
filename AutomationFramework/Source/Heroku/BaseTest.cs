using OpenQA.Selenium;
using AutomationFramework.Utilities;


namespace AutomationFramework.Source.Heroku
{
    public class BaseTest
    {
        public IWebDriver _driver;
        string url = TestVariables.GetHerokuHomePageUrl();

        [SetUp]
        public void InitScript()
        {
            _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(url);
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
