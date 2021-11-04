using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriverTestProject101.Core.Web;

namespace WebDriverTestProject101.Core.Page
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
