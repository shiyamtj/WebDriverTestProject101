using NUnit.Framework;
using WebDriverTestProject101.Core.Utilities;

namespace WebDriverTestProject101.Tests
{
    public class UtilitiesTests
    {

        [Test]
        public void Test_UniqueEmailGenerator()
        {
            var result = UniqueEmailGenerator.GenerateUniqueEmailGuid();
        }
    }
}