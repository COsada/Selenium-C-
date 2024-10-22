using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Utilities;
using AutomationFramework.Source.Heroku.Pages;

namespace AutomationFramework.Source.Heroku.Tests
{
    public class AddRemovePageTests : BaseTest
    {
        HomePage hp = new();
        AddRemovePage ar = new();

        [Test]
        public void AddRemovePageTest()
        {
            
            hp.ClickAddRemoveLink();

            //Make sure that initial webelements that should be present are, and that those that shoyuldn't be are not.
            Assert.That(ar.CheckForTitle());
            Assert.That(ar.CheckForNoDeleteEleButton());
            Assert.That(ar.CheckForAddEleButton());
            Assert.That(_driver.Url.Equals(TestVariables.GetHerokuAddRemovePageUrl()));

            //Check that the 'Add Element' can add at least two elements to the page, then check to make sure both of the 'Delete' buttons that were added are deleted when pressed.
            ar.ClickAddEleButton();
            Assert.That(ar.CheckForDeleteEleButton());
            ar.ClickAddEleButton();
            Assert.That(ar.CountDeleteEleButtons() == 2);
            ar.ClickDeleteEleButtons();
            Assert.That(ar.CheckForNoDeleteEleButton());
        }
    }
}
