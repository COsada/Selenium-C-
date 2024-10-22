using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Source.Heroku.Pages
{
    public class AddRemovePage
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
        //private IWebDriver _driver = new EdgeDriver();

        private IWebElement _pageTitle => _driver.FindElement(By.XPath("//*[@id='content']/h3"));
        private IWebElement _addEleButton => _driver.FindElement(By.CssSelector("#content > div > button"));
        private IWebElement _deleteEleButton => _driver.FindElement(By.XPath("//*[@id='elements']/button"));
        private ReadOnlyCollection<IWebElement> _deleteEleButtonList => _driver.FindElements(By.XPath("//*[@id='elements']/button"));

        public bool CheckForTitle()
        {
            if (_pageTitle.Displayed && _pageTitle.Enabled && _pageTitle.Text.Equals("Add/Remove Elements") && _pageTitle.Size.Width > 10 && _pageTitle.Size.Height > 10)
            {
                return true;
            }
            return false;
        }
        public bool CheckForAddEleButton()
        {
            if (_addEleButton.Displayed && _addEleButton.Enabled && _addEleButton.Text.Equals("Add Element") && _addEleButton.Size.Width > 10 && _addEleButton.Size.Height > 10)
            {
                return true;
            }
            return false;
        }
        public void ClickAddEleButton()
        {
            _addEleButton.Click();
        }
        public void ClickDeleteEleButtons()
        {
            for(int i = 0; i < _deleteEleButtonList.Count() + 1; i++)
            {
                _deleteEleButtonList[0].Click();
            }
        }
        public bool CheckForDeleteEleButton()
        {
            if (_deleteEleButton.Displayed && _deleteEleButton.Enabled && _deleteEleButton.Text.Equals("Delete") && _deleteEleButton.Size.Width > 10 && _deleteEleButton.Size.Height > 10)
            {
                return true;
            }
            return false;
        }
        public bool CheckForNoDeleteEleButton()
        {
            try
            {
                if (!_deleteEleButton.Displayed && !_deleteEleButton.Enabled && !_deleteEleButton.Text.Equals("Delete") && !(_deleteEleButton.Size.Width > 10) && !(_deleteEleButton.Size.Height > 10))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return true;
            }

        }
        public int CountDeleteEleButtons()
        {
           return _deleteEleButtonList.Count();
        }
    }
}
