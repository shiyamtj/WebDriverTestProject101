using DesignPatternLearn101.Core.Page;

namespace WebDriverTestProject101.Domain.Pages
{
    public class OrangeHrmDashboardPage : BasePage<OrangeHrmDashboardPageMap>
    {
        public OrangeHrmDashboardPage() : base(@"/index.php/dashboard")
        {
        }

        public void Logout()
        {
            Map.WelcomeSection.Click();
            Map.LinkLogout.Click();
        }
    }
}