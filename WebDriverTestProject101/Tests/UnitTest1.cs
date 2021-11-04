using DesignPatternLearn101.Core.Web;
using NUnit.Framework;
using WebDriverTestProject101.Domain.Contexts;
using WebDriverTestProject101.Domain.Pages;
using WebDriverTestProject101.Domain.Workflows;

namespace WebDriverTestProject101.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Driver.StartBrowser();
        }

        [TearDown]
        public void Teardown()
        {
            Driver.StopBrowser();
        }

        [Test]
        [Ignore("Test_Sample")]
        public void Test_Sample()
        {
            SearchEngineMainPage searchEngineMainPage = new();
            searchEngineMainPage.Navigate("https://opensource-demo.orangehrmlive.com");
            searchEngineMainPage.Search("Automate The Planet");
            searchEngineMainPage.Validate().ResultsCount("264,000 RESULTS");
        }

        [Test]
        public void Test_OrangeHrm_PageObject()
        {
            OrangeHrmLoginPage orangeHrmLoginPage = new();
            orangeHrmLoginPage.Navigate("https://opensource-demo.orangehrmlive.com/");
            orangeHrmLoginPage.Login("Admin", "admin123");

            OrangeHrmDashboardPage orangeHrmDashboardPage = new();
            orangeHrmDashboardPage.Logout();
        }

        [Test]
        public void Test_OrangeHrm_FacadePattern()
        {
            NavigationFacade navigationFacade = new();

            var loginContextInfo = new LoginContextInfo()
            {
                Url = "https://opensource-demo.orangehrmlive.com/",
                Username = "Admin",
                Password = "admin123"
            };
            navigationFacade.LoginLogout(loginContextInfo);
        }
    }
}