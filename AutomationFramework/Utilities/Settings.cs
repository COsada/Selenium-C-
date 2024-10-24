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
    public class TestVariables
    {
        static IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("config.json", optional: true).Build();
        public static string GetYoutubeHomePageUrl()
        {
            return configuration["TestVariables:Youtube:HomePageUrl"];
        }
        public static string GetYoutubeVideoName()
        {
            return configuration["TestVariables:Youtube:SearchedVideo"];
        }
        public static string GetHerokuHomePageUrl()
        {
            return configuration["TestVariables:Heroku:HomePageUrl"];
        }

        public static string GetHerokuAddRemovePageUrl()
        {
            return configuration["TestVariables:Heroku:AddRemovePageUrl"];
        }
    }
}
