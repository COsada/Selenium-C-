using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities
{
    public class ElementInteractives
    {
        private static IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());

        //Element click element option
        public static void ClickElement(IWebElement clickableElement)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(d => clickableElement.Displayed && clickableElement.Enabled);
                clickableElement.Click();
            }
            catch
            {
                clickableElement.Click();
            }
        }
        //Click element option with additional check for expected text
        public static void ClickElement(IWebElement clickableElement, string expectedText)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(d => clickableElement.Displayed && clickableElement.Enabled && clickableElement.Text.Equals(expectedText));
                clickableElement.Click();
            }
            catch
            {
                clickableElement.Click();
            }
        }
        //Click element but with customizable explicit wait
        public static void ClickElement(IWebElement clickableElement, int time)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
            wait.Until(d => clickableElement.Displayed && clickableElement.Enabled);
            clickableElement.Click();
        }
        //Click element but with customizable explicit wait and additional check for expected text
        public static void ClickElement(IWebElement clickableElement, string expectedText, int time)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
            wait.Until(d => clickableElement.Displayed && clickableElement.Enabled && clickableElement.Text.Equals(expectedText));
            clickableElement.Click();
        }
        /*Depending on what the clicked element does to the page, the rest may count as stale after the first click. Too finicky to use as is*/
        //public void ClickThroughListOfElements(ReadOnlyCollection<IWebElement> clickableElements)
        //{
        //    for (int i = 0; i < clickableElements.Count() + 1; i++)
        //    {
        //        ClickElement(clickableElements[0]);
        //    }
        //}

        //Element check for element option
        public static bool SearchElement(IWebElement findableElement)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(d => findableElement.Displayed && findableElement.Enabled);
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        //Click element option with additional check for expected text
        public static bool SearchElement(IWebElement findableElement, string expectedText)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(d => findableElement.Displayed && findableElement.Enabled && findableElement.Text.Equals(expectedText));
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        //Click element but with customizable explicit wait
        public static bool SearchElement(IWebElement findableElement, int time)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
            try
            {
                wait.Until(d => findableElement.Displayed && findableElement.Enabled);
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        //Click element but with customizable explicit wait and additional check for expected text
        public static bool SearchElement(IWebElement findableElement, string expectedText, int time)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
            try
            {
                wait.Until(d => findableElement.Displayed && findableElement.Enabled && findableElement.Text.Equals(expectedText));
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        /* If the element doesn't exist, then errors are thrown as soon as you try to pass it into this method. 
         * Figure out a way to maybe deal with that later? or accept that this can't work as a method*/
        //public bool CheckForNoElement(IWebElement nonFindableElement)
        //{
        //    try
        //    {
        //        if (!nonFindableElement.Displayed && !nonFindableElement.Enabled && !(nonFindableElement.Size.Width > 10) && !(nonFindableElement.Size.Height > 10))
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return true;
        //    }
        //}
        /*Consistently fails to find element when used. Unsure if its because the wait isn't working or something weird with how wait interacts with passed in elements is interfering.*/
        //public void WaitForElements(IWebElement element, int time)
        //{
        //    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
        //    wait.Until(d => element.Displayed && element.Enabled);
        //}
    }
}
