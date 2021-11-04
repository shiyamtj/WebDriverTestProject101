using DesignPatternLearn101.Core.Web;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DesignPatternLearn101.Core.Page
{
    public class BasePageElementMap
    {
        protected IWebDriver browser;
        protected WebDriverWait wait;
        public BasePageElementMap()
        {
            browser = Driver.Browser;
            wait = Driver.BrowserWait;
        }
    }
}
