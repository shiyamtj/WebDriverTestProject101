namespace WebDriverTestProject101.Core.Page
{
    public class BasePageValidator<T> where T : BasePageElementMap, new()
    {
        protected T Map
        {
            get
            {
                return new T();
            }
        }
    }
}
