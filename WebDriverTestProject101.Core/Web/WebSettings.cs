using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTestProject101.Core.Web
{
    public class WebSettings
    {
        public string ElementRetry { get; set; }
        public string ElementWaitTimeout { get; set; }
        public Browser Chrome { get; set; }
        public Browser FireFox { get; set; }
    }

    public class Browser
    {
        public string PageLoadTimeout { get; set; }
        public string ScriptTimeout { get; set; }
        public string ArtificialDelayBeforeAction { get; set; }
    }
}
