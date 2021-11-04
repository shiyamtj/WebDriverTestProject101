using WebDriverTestProject101.Core.Page;

namespace WebDriverTestProject101.Domain.Pages
{
    public class OrangeHrmDashboardPage :
        BasePageSingletonDerived<
            OrangeHrmDashboardPage,
            OrangeHrmDashboardPageMap>
    {
        public OrangeHrmDashboardPage() { }


        public void Logout()
        {
            Map.WelcomeSection.Click();
            Map.LinkLogout.Click();
        }
    }
}