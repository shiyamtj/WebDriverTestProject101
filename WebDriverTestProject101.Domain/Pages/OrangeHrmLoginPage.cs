using DesignPatternLearn101.Core.Page;

namespace WebDriverTestProject101.Domain.Pages
{
    public class OrangeHrmLoginPage : BasePage<OrangeHrmLoginPageMap>
    {
        public OrangeHrmLoginPage() : base(@"")
        {
        }

        public void Login(string username, string password)
        {
            Map.UsernameField.Clear();
            Map.UsernameField.SendKeys(username);
            Map.PasswordField.Clear();
            Map.PasswordField.SendKeys(password);
            Map.LoginButton.Click();
        }
    }
}