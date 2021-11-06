using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTestProject101.Core.Attributes;
using WebDriverTestProject101.Core.Utilities;
using WebDriverTestProject101.Core.Web;

namespace WebDriverTestProject101.Tests
{
    public class UtilitiesTest
    {

        [Test]
        public void Test_FileLogger()
        {
            var fileLogger = new FileLogger("TestName_Sample", "");
            fileLogger.Info("Testing message for Info");
        }

        [Test]
        [Browser(name: "Test_CustomAttributes", browserType: BrowserType.Chrome)]
        public void Test_CustomAttributes()
        {
            Console.WriteLine("Testing Test_CustomAttributes ...");
        }
    }
}
