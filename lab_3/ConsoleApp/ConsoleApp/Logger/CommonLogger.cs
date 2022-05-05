using ConsoleApp.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp.Logger.ILogger;

namespace ConsoleApp
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }


        public void Log(params string[] messages)
        {
            for (int i = 0; i < loggers.Length; i++)
            {
                for (int j = 0; j < messages.Length; j++)
                {
                    loggers[i].Log(messages[j]);
                }
            }
        }

        public void Dispose()
        {
            //todo
        }
    }
}
