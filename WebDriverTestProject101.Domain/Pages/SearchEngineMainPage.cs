using DesignPatternLearn101.Core.Page;

namespace WebDriverTestProject101.Domain.Pages
{
    public class SearchEngineMainPage : BasePage<SearchEngineMainPageElementMap, SearchEngineMainPageValidator>
    {
        public SearchEngineMainPage() : base(@"searchEngineUrl")
        {
        }

        public void Search(string textToType)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(textToType);
            Map.GoButton.Click();
        }
    }
}
