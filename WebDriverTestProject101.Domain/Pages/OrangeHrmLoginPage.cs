using WebDriverTestProject101.Core.Page;

namespace WebDriverTestProject101.Domain.Pages
{
    public class OrangeHrmLoginPage :
        BasePageSingletonDerived<
            OrangeHrmLoginPage,
            OrangeHrmLoginPageMap>
    {
        public OrangeHrmLoginPage() { }

        public override void Navigate(string url)
        {
            base.Navigate(url);
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