using System;

namespace ConsoleApp.Logger
{
    internal class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Log(params string[] messages)
        {
            foreach(var logger in loggers)
            {
                logger.Log(messages);
            }
        }

        public void Dispose()
        {
            foreach (var logger in loggers)
            {
                logger.Dispose();
            }

            GC.SuppressFinalize(this);
        }


    }
}
