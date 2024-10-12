using OpenQA.Selenium;
using AutomationFramework.Source.Pages;
using AutomationFramework.Utilities;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Runtime;

namespace AutomationFramework.Test
{
    public class HomePageTest : BaseTest
    {
        [Test]
        public void SearchVideo()
        {
            HomePage hp = new HomePage();
            
            hp.UseSearchBox("funny cat videos");
            hp.WaitForChips(5);

            Assert.That(_driver.Title.Contains("funny") && _driver.Title.Contains("cat") && _driver.Title.Contains("videos"));
        }
    }
}
