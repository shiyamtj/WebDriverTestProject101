﻿using DesignPatternLearn101.Core.Page;
using DesignPatternLearn101.Core.Web;

namespace WebDriverTestProject101.Core.Page
{
    public abstract class BasePageSingletonDerived<S, M> : ThreadSafeNestedContructorsBaseSingleton<S>
         where M : BasePageElementMap, new()
         where S : BasePageSingletonDerived<S, M>
    {
        protected M Map
        {
            get
            {
                return new M();
            }
        }
        public virtual void Navigate(string url = "")
        {
            Driver.Browser.Navigate().GoToUrl(string.Concat(url));
        }
    }
    public abstract class BasePageSingletonDerived<S, M, V> : BasePageSingletonDerived<S, M>
         where M : BasePageElementMap, new()
         where V : BasePageValidator<M>, new()
         where S : BasePageSingletonDerived<S, M, V>
    {
        public V Validate()
        {
            return new V();
        }
    }
}
