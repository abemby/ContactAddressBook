using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB.Interface;

namespace CAB.ConsoleLogger
{
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// A simple write-to-console ILogger implementation.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        public void WriteLog(LogLevels level, string message)
        {
            Console.WriteLine(string.Format("{0}{1}{2}", level, Environment.NewLine, message));
        }
    }
}
