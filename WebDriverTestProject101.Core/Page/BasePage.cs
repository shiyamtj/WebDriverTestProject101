using DesignPatternLearn101.Core.Web;

namespace DesignPatternLearn101.Core.Page
{
    public class BasePage<T> where T : BasePageElementMap, new()
    {
        protected readonly string url;

        public BasePage(string url)
        {
            this.url = url;
        }

        public BasePage()
        {
            this.url = string.Empty;
        }

        protected T Map => new();

        public void Navigate(string url)
        {
            Driver.Browser.Navigate().GoToUrl($"{url}/{this.url}");
        }
    }

    public class BasePage<T, V> : BasePage<T>
        where T : BasePageElementMap, new()
        where V : BasePageValidator<T>, new()
    {
        public BasePage(string url) : base(url)
        {
        }

        public V Validate()
        {
            return new V();
        }
    }
}
