using OpenQA.Selenium;
using AutomationFramework.Utilities;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Runtime;
using AutomationFramework.Source.Youtube.Pages;

namespace AutomationFramework.Source.Youtube.Test
{
    public class SearchPageTest : BaseTest
    {
        HomePage hp = new();
        SearchPage sp = new();

        [Test]
        public void CheckSearchFunction()
        {
            string searchText = TestData.GetYoutubeInformation("HomePageUrl");

            Assert.That(_driver.Url, Does.StartWith(TestData.GetYoutubeInformation("HomePageUrl")));
            hp.UseSearchBox(searchText);
            sp = new();
            Assert.That(_driver.Title, Does.Contain(searchText));
        }
    }
}
