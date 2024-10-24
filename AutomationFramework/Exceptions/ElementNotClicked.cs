using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Exceptions
    {
        public class ElementNotClicked : System.Exception
        {
            public ElementNotClicked(IWebElement element)
                : base(String.Format("The click on the following element has failed: {0}", element)) { }
        }
    }
