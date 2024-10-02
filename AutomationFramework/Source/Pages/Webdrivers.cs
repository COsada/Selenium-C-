using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationFramework.Source.Pages
{
    public class Webdrivers
    {

        public IWebDriver _driver;

        /*
        * Factory to instantiate a WebDriver object. It returns an instance of the driver (local invocation).
        */
        public IWebDriver getWebDriver(string browserType)
        {
            switch (browserType)
            {
                case "Edge": case "edge":
                    if (_driver == null)
                    {
                        new DriverManager().SetUpDriver(
                        new EdgeConfig(), version: "Latest"
                        );
                        _driver = new EdgeDriver();
                        return _driver;
                    }
                    else
                    {
                        return _driver;
                    }
                case "Chrome": case "chrome":
                    if (_driver == null)
                    {
                        new DriverManager().SetUpDriver(
                        new ChromeConfig(), version: "Latest"
                        );
                        _driver = new ChromeDriver();
                        return _driver;
                    }
                    else
                    {
                        return _driver;
                    }
                case "Firefox": case "firefox":
                    if (_driver == null)
                    {
                        new DriverManager().SetUpDriver(
                        new FirefoxConfig(), version: "Latest"
                        );
                        _driver = new FirefoxDriver();
                        return _driver;
                    }
                    else
                    {
                        return _driver;
                    }
                default:
                    return _driver;
            }
        }
    }
}
