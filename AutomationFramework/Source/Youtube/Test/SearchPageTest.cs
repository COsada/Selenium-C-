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
            string searchText = TestVariables.GetYoutubeVideoName();

            Assert.That(_driver.Url, Does.StartWith(TestVariables.GetYoutubeHomePageUrl()));
            hp.UseSearchBox(searchText);
            sp.WaitForChips(5);
            Assert.That(_driver.Title, Does.Contain(searchText));
        }
    }
}
