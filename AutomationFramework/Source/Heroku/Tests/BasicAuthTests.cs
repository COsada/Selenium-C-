using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Utilities;
using AutomationFramework.Source.Heroku.Pages;

namespace AutomationFramework.Source.Heroku.Tests
{
    public class ElementAuthPageTests : BaseTest
    {
        HomePage hp = new();
        BasicAuthPage bp = new();

        [Test]
        public void LoginTest()
        {
            
            hp.ClickHomePageLinkByGivenIndex(3);
            Assert.That(_driver.Url.Equals(TestData.GetHerokuInformation("Urls:BasicAuthPage")));
            bp.EnterCredentials();
            Assert.That(bp.CheckForTitle());
            Assert.That(bp.CheckForContent());
        }
    }
}
