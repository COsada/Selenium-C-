using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Exceptions
{
    public class InvalidNumberException : System.Exception
    {
        public InvalidNumberException(string browserType)
            : base(String.Format("Some custom error message. browserType: {0}", browserType)) { }
    }

}
