using System;

namespace ConsoleApp.Logger
{
    internal class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            this.writer = Console.Out;

        }

        public override void Dispose()
        {
            this.writer.Close();
            GC.SuppressFinalize(this);
        }
    }
}
