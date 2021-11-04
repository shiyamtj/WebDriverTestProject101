using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace DesignPatternLearn101.Core.Web
{
    public static class Driver
    {
        [ThreadStatic]
        private static WebDriverWait browserWait;

        [ThreadStatic]
        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 30)
        {
            switch (browserType)
            {
                case BrowserTypes.Firefox:
                    {
                        new DriverManager().SetUpDriver(new FirefoxConfig(), "Latest");
                        Browser = new FirefoxDriver();
                    }
                    Browser = new FirefoxDriver();
                    break;
                case BrowserTypes.IE:
                    break;
                case BrowserTypes.Chrome:
                    {
                        new DriverManager().SetUpDriver(new ChromeConfig(), "Latest");
                        Browser = new ChromeDriver();
                    }
                    break;
                default:
                    break;
            }
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultTimeOut));
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
