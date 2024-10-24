using OpenQA.Selenium;
using AutomationFramework.Utilities;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Runtime;
using AutomationFramework.Source.Youtube.Pages;

namespace AutomationFramework.Source.Youtube.Test
{
    public class VideoPageTest : BaseTest
    {
        HomePage hp = new();
        SearchPage sp = new();

        [Test]
        public void CheckVideoOpens()
        {
            string searchText = TestVariables.GetYoutubeVideoName();

            hp.UseSearchBox(searchText);
            sp.WaitForChips(5);
        }
    }
}
