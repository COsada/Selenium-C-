using OpenQA.Selenium;
using AutomationFramework.Utilities;


namespace AutomationFramework.Test
{
    public class BaseTest
    {
        public IWebDriver _driver;
        String url = "https://www.youtube.com";

        [SetUp]
        public void InitScript()
        {
            _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.youtube.com");
        }

        [TearDown]
        public void Cleanup()
        {
            try {
                _driver.Dispose();
            }catch (Exception ex){
                throw ex;
            }
}
}
}
