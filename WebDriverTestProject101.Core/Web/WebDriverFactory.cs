using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTestProject101.Core.Web
{
    public static class WebDriverFactory
    {
        private static readonly string AssemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static IWebDriver CreateDriver(BrowserType browserType)
        {
            string proxyUrl = ProxyService.GetProxyIp();
            var proxy = new Proxy
            {
                HttpProxy = proxyUrl,
                SslProxy = proxyUrl,
                FtpProxy = proxyUrl,
            };

            IWebDriver webDriver;
            switch (browserType)
            {
                case BrowserType.Chrome:
                    var chromeOptions = new ChromeOptions
                    {
                        Proxy = proxy
                    };
                    var chromeDriverService = ChromeDriverService.CreateDefaultService(AssemblyFolder);
                    webDriver = new ChromeDriver(chromeDriverService, chromeOptions);
                    webDriver.Manage().Timeouts().PageLoad =
                    TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().Chrome.PageLoadTimeout);
                    webDriver.Manage().Timeouts().AsynchronousJavaScript =
                    TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().Chrome.ScriptTimeout);
                    break;
                case BrowserType.Firefox:
                    var firefoxOptions = new FirefoxOptions()
                    {
                        Proxy = proxy
                    };
                    webDriver = new FirefoxDriver(Environment.CurrentDirectory, firefoxOptions);
                    webDriver.Manage().Timeouts().PageLoad =
                    TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().Firefox.PageLoadTimeout);
                    webDriver.Manage().Timeouts().AsynchronousJavaScript =
                    TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().Firefox.ScriptTimeout);
                    break;
                case BrowserType.Edge:
                    var edgeOptions = new EdgeOptions()
                    {
                        Proxy = proxy
                    };
                    webDriver = new EdgeDriver(Environment.CurrentDirectory, edgeOptions);
                    webDriver.Manage().Timeouts().PageLoad =
                    TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().Edge.PageLoadTimeout);
                    webDriver.Manage().Timeouts().AsynchronousJavaScript =
                    TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().Edge.ScriptTimeout);
                    break;
                case BrowserType.IE:
                    var ieOptions = new InternetExplorerOptions()
                    {
                        Proxy = proxy
                    };
                    webDriver = new InternetExplorerDriver(Environment.CurrentDirectory, ieOptions);
                    webDriver.Manage().Timeouts().PageLoad =
                    TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().InternetExplorer.PageLoadTimeout);
                    webDriver.Manage().Timeouts().AsynchronousJavaScript =
                    TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().InternetExplorer.ScriptTimeout);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
            }
            return webDriver;
        }
    }
}
