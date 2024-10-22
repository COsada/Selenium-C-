using OpenQA.Selenium;
using AutomationFramework.Utilities;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Runtime;
using AutomationFramework.Source.Youtube.Pages;

namespace AutomationFramework.Source.Youtube.Test
{
    public class HomePageTest : BaseTest
    {
        HomePage hp = new();

        [Test]
        public void SearchVideo()
        {
            hp.UseSearchBox(TestVariables.GetHerokuHomePageUrl());
            hp.WaitForChips(5);
            Assert.That(_driver.Title, Does.Contain(TestVariables.GetHerokuHomePageUrl()));
        }
    }
}
