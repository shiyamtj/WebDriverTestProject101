using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTestProject101.Core.Utilities
{
    public interface ILogger
    {
        void CreateLogEntry(string errorMessage);
    }
}
