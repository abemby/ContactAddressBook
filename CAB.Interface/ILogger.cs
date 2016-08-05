using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB.Interface
{
    public enum LogLevels
    {
        TRACE,
        DEBUG,
        INFO,
        WARN,
        ERROR
    }

    public interface ILogger
    {
        void WriteLog(LogLevels level, string message);

    }
}
