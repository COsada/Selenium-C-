using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Exceptions
{
    public class BrowserTypeNotSupported : System.Exception
    {
        public BrowserTypeNotSupported(string browserType)
            : base(String.Format("The following browser type is not supported by this framework. browserType: {0}", browserType)) { }
    }

}
