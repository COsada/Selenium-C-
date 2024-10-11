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
        public static string GetSetting(string setting)
        {
            string browserType;
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("config.json", optional: true).Build();

                switch (setting)
                {
                    case "BrowserType":
                    browserType = configuration["Settings:BrowserType"];
                    return browserType;
                    default:
                        return null;
                }
        }
    }
}
