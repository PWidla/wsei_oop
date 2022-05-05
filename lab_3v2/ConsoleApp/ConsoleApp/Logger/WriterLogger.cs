using System;
using System.IO;

namespace ConsoleApp.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            foreach (string message in messages)
            {
                var formattedMessage = FormatMessage(message);
                writer.WriteLine(formattedMessage);
            }
        }

        protected virtual string FormatMessage(string message)
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            return String.Format("{0}: {1}", timestamp, message);
        }

        public virtual void Dispose()
        {
            this.writer.Close();
            GC.SuppressFinalize(this);
        }
    }
}