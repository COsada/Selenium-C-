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
        public static string GetUsername()
        {
            return configuration["Credentials:Username"];
        }
        public static string GetPassword()
        {
            return configuration["Credentials:Password"];
        }
    }
}
