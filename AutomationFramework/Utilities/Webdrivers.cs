using AutomationFramework.Exceptions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationFramework.Utilities
{
    public class Webdrivers
    {
        public static IWebDriver _driver;
        /*
        * Factory to instantiate a WebDriver object. It returns an instance of the driver (local invocation).
        */
        public static IWebDriver GetDriver(string browserType)
        {
            if (_driver == null)
            {
                switch (browserType)
                {
                    case "Edge":
                    case "edge":
                        //new DriverManager().SetUpDriver(new EdgeConfig(), version: "Latest");
                        _driver = new EdgeDriver();
                        return _driver;
                    case "Chrome":
                    case "chrome":
                        //new DriverManager().SetUpDriver(new ChromeConfig(), version: "Latest");
                        _driver = new ChromeDriver();
                        return _driver;
                    case "Firefox":
                    case "firefox":
                        //new DriverManager().SetUpDriver(new FirefoxConfig(), version: "Latest");
                        _driver = new FirefoxDriver();
                        return _driver;
                    default:
                        throw new BrowserTypeNotSupported(browserType);
                }
            }
            else
            {
                return _driver;
            }


        }
    }
}
