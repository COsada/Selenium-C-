using AutomationFramework.Exceptions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Runtime.CompilerServices;
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
            /*This is extremely janky, but without this tests will fail when running more then one at a time as
             once one test closes the browser, the next test will try to use this method, fail, and get hit by an ObjectDisposedException when it tries to interact with the browser.*/
            bool hasDriverBeenClosed = false;
            try
            {
                if (_driver != null)
                {
                    _driver.Manage().Window.Maximize();
                    hasDriverBeenClosed = false;
                }
            }
            catch (Exception ex)
            {
                hasDriverBeenClosed = true;
            }

            /*Makes changes to below if-statement to get ride of the whole 'hasDriverBeenClosed' mess. Figure out a better check then '_driver == null' as that only 
             * checks if a driver HAS existed, not if one exists right now. As in, it gets confused if the driver has been made and then disposed, and treats it as if it's still open.*/
            if (hasDriverBeenClosed || _driver == null)
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
