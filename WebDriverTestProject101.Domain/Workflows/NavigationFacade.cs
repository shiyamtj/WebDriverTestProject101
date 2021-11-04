using WebDriverTestProject101.Domain.Contexts;
using WebDriverTestProject101.Domain.Pages;

namespace WebDriverTestProject101.Domain.Workflows
{
    public class NavigationFacade
    {
        private OrangeHrmLoginPage orangeHrmLoginPage;
        private OrangeHrmDashboardPage orangeHrmDashboardPage;

        public OrangeHrmLoginPage OrangeHrmLoginPage
        {
            get
            {
                if (orangeHrmLoginPage == null)
                {
                    orangeHrmLoginPage = new OrangeHrmLoginPage();
                }
                return orangeHrmLoginPage;
            }
        }

        public OrangeHrmDashboardPage OrangeHrmDashboardPage
        {
            get
            {
                if (orangeHrmDashboardPage == null)
                {
                    orangeHrmDashboardPage = new OrangeHrmDashboardPage();
                }
                return orangeHrmDashboardPage;
            }
        }

        public void LoginLogout(LoginContextInfo info)
        {
            OrangeHrmLoginPage.Navigate(info.Url);
            OrangeHrmLoginPage.Login(info.Username, info.Password);
            OrangeHrmDashboardPage.Logout();
        }
    }
}
