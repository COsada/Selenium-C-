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
    public class AddRemovePage: ElementInteractivity
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());
        //private IWebDriver _driver = new EdgeDriver();

        private IWebElement _pageTitle => _driver.FindElement(By.XPath("//*[@id='content']/h3"));
        private IWebElement _addEleButton => _driver.FindElement(By.CssSelector("#content > div > button"));
        private IWebElement _deleteEleButton => _driver.FindElement(By.XPath("//*[@id='elements']/button"));
        private ReadOnlyCollection<IWebElement> _deleteEleButtonList => _driver.FindElements(By.XPath("//*[@id='elements']/button"));

        public bool CheckForTitle()
        {
            return CheckForElement(_pageTitle);
        }
        public bool CheckForAddEleButton()
        {
            return CheckForElement(_addEleButton);
        }
        public void ClickAddEleButton()
        {
            ClickElement(_addEleButton);
        }
        public void ClickDeleteEleButtons()
        {
            for(int i = 0; i < _deleteEleButtonList.Count() + 1; i++)
            {
                ClickElement(_deleteEleButtonList[0]);
            }
        }
        public bool CheckForDeleteEleButton()
        {
            return CheckForElement(_deleteEleButton);
        }
        public bool CheckForNoDeleteEleButton()
        {
            try {return CheckForElement(_deleteEleButton);} 
            catch{return true;}
        }
        public int CountDeleteEleButtons()
        {
           return _deleteEleButtonList.Count();
        }
    }
}
