using DesignPatternLearn101.Core.Page;
using OpenQA.Selenium;

namespace WebDriverTestProject101.Domain.Pages
{
    public class OrangeHrmLoginPageMap : BasePageElementMap
    {
        public IWebElement UsernameField => browser.FindElement(By.Id("txtUsername"));
        public IWebElement PasswordField => browser.FindElement(By.Id("txtPassword"));
        public IWebElement LoginButton => browser.FindElement(By.Id("btnLogin"));
    }
}