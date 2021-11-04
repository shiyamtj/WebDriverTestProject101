using NUnit.Framework;
using WebDriverTestProject101.Core.Page;

namespace WebDriverTestProject101.Domain.Pages
{
    public class SearchEngineMainPageValidator : BasePageValidator<SearchEngineMainPageElementMap>
    {
        public void ResultsCount(string expectedCount)
        {
            Assert.IsTrue(Map.ResultsCountDiv.Text.Contains(expectedCount), "The results DIV doesn't contains the specified text.");
        }
    }
}
