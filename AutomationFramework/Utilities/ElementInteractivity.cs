using AutomationFramework.Exceptions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities
{
    public class ElementInteractivity
    {
        public void ClickElement(IWebElement clickableElement)
        {
            if (clickableElement.Displayed && clickableElement.Enabled && clickableElement.Size.Width > 10 && clickableElement.Size.Height > 10)
            {
                clickableElement.Click();
            } else
            {
                throw new ElementNotClicked(clickableElement);
            }
        }
        //public void ClickThroughListOfElements(ReadOnlyCollection<IWebElement> clickableElements)
        //{
        //    for (int i = 0; i < clickableElements.Count() + 1; i++)
        //    {
        //        ClickElement(clickableElements[0]);
        //    }
        //}
        public bool CheckForElement(IWebElement findableElement)
        {
            if (findableElement.Displayed && findableElement.Enabled && findableElement.Size.Width > 10 && findableElement.Size.Height > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
    }
}
