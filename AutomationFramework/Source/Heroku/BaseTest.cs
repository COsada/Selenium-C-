using OpenQA.Selenium;
using AutomationFramework.Utilities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


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
            //_driver = new EdgeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void Cleanup()
        {
            try
            {
                _driver.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
