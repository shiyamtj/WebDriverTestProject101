using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebDriverTestProject101.Core.Web;

namespace WebDriverTestProject101.Core
{
    public sealed class ConfigurationService
    {
        private static ConfigurationService _instance;
        public static ConfigurationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationService();
                }
                return _instance;
            }
        }

        public IConfigurationRoot Root { get; }
        public ConfigurationService() => Root = InitializeConfiguration();

        private IConfigurationRoot InitializeConfiguration()
        {
            var filesInExecutionDir = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            var settingsFile =
            filesInExecutionDir.FirstOrDefault(x => x.Contains("testFrameworkSettings") && x.EndsWith(".json"));
            var builder = new ConfigurationBuilder();
            if (settingsFile != null)
            {
                builder.AddJsonFile(settingsFile, optional: true, reloadOnChange: true);
            }
            return builder.Build();
        }

        public WebSettings GetWebSettings() => Instance.Root.GetSection("webSettings").Get<WebSettings>();

        public UrlSettings GetUrlSettings()
        {
            var result = Instance.Root.GetSection("UrlSettings").Get<UrlSettings>();
            if (result == null)
            {
                throw new KeyNotFoundException(typeof(UrlSettings).ToString());
            }
            return result;
        }
    }
}
