using WebDriverTestProject101.Core.Web;

namespace WebDriverTestProject101.Core.Page
{
    public class BasePage<T> where T : BasePageElementMap, new()
    {
        private static BasePage<T> instance;
        protected readonly string url;

        public BasePage(string url)
        {
            this.url = url;
        }

        public BasePage()
        {
            url = null;
        }

        public static BasePage<T> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BasePage<T>();
                }
                return instance;
            }
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
