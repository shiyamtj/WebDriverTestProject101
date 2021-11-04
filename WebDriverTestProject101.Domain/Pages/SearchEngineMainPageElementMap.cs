using OpenQA.Selenium;
using WebDriverTestProject101.Core.Page;

namespace WebDriverTestProject101.Domain.Pages
{
    public class SearchEngineMainPageElementMap : BasePageElementMap
    {
        public IWebElement SearchBox => browser.FindElement(By.Id("sb_form_q"));
        public IWebElement GoButton => browser.FindElement(By.Id("sb_form_go"));
        public IWebElement ResultsCountDiv
        {
            get
            {
                return browser.FindElement(By.Id("b_tween"));
            }
        }
    }
}
