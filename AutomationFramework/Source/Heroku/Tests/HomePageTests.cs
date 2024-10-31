using OpenQA.Selenium;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Runtime;
using AutomationFramework.Utilities;
using AutomationFramework.Source.Heroku.Pages;

namespace AutomationFramework.Source.Heroku.Tests
{
    public class HomePageTests : BaseTest
    {
        HomePage hp = new();

        [Test]
        public void HomePageTest()
        {
            Assert.That(hp.CheckForTitle());
            Assert.That(hp.CheckForSubTitle());
            Assert.That(hp.CheckForListOfLinks);
            Assert.That(_driver.Url.Equals(TestData.GetHerokuInformation("Urls:HomePage")));
        }
    }
}
