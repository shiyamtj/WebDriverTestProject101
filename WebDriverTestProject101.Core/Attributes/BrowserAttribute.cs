using System;
using WebDriverTestProject101.Core.Web;

namespace WebDriverTestProject101.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Struct)]
    public class BrowserAttribute : Attribute
    {
        private BrowserType browserType;
        private string name;

        public BrowserAttribute(string name, BrowserType browserType)
        {
            this.browserType = browserType;
            this.name = name;
        }
    }
}
