using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.LogHandlers
{
    internal class FileLogger
    {
        public void HandleLog(string message) {

            Console.WriteLine($"File Logger : {message}");

        }
    }
}
