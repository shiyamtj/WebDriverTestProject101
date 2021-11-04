namespace WebDriverTestProject101.Core.Page
{
    public abstract class ThreadSafeBaseSingleton<S> where S : new()
    {
        private static S instance;
        private static readonly object lockObject = new();

        private ThreadSafeBaseSingleton() { }
        public static S Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new S();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
