using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace AutomationFramework.Utilities
{
    public class AppSettings
    {

        static IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("config.json", optional: true).Build();
        public static string GetBrowserType()
        {
            return configuration["Settings:BrowserType"];
        }
    }
    public class TestData
    {
        static IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("test-data.json", optional: true).Build();
        public static string GetYoutubeInformation(string expectedInfo)
        {
            return configuration["Youtube:" + expectedInfo];
        }
        public static string GetHerokuInformation(string expectedInfo)
        {
            return configuration["Heroku:" + expectedInfo];
        }
    }
}
