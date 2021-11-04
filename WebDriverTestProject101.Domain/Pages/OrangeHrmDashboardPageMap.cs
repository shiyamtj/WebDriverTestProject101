using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using WebDriverTestProject101.Core.Page;

namespace WebDriverTestProject101.Domain.Pages
{
    public class OrangeHrmDashboardPageMap : BasePageElementMap
    {
        public IWebElement WelcomeSection => browser.FindElement(By.Id("welcome"));
        public IWebElement LinkLogout
        {
            get
            {
                var locator = By.LinkText("Logout");
                wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                return browser.FindElement(locator);
            }
        }
    }
}