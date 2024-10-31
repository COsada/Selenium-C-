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
        VideoPage vp = new();

        [Test]
        public void CheckVideoOpens()
        {
            string searchText = TestData.GetYoutubeInformation("SearchedVideo");

            hp.UseSearchBox(searchText);
            //sp.WaitForChips(5);
            string topVideoName = sp.GetTopVideoName();
            sp.ClickTopVideo();
            Assert.That(vp.CheckVideoTitle(topVideoName));
            Assert.That(vp.CheckForLikeDislikeButtons());
            Assert.That(vp.CheckForSubscribeButton());
            Assert.That(vp.CheckForVideoDescription());
            Assert.That(vp.CheckForVideoDescription());
            Assert.That(vp.CheckForCommentSection());
            Assert.That(vp.CheckForNewVideoSidebar());
        }
    }
}
