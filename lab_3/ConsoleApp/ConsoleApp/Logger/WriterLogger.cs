using System;
using System.IO;
using System.Text;
using ConsoleApp.Logger;

namespace ConsoleApp.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public void Log(params string[] messages)
        {
            writer = new StreamWriter("D:\\Patryk c#\\dupa.txt");
            writer.WriteLine("gówno");
            writer.Flush();
            writer.Close();
        }

        public abstract void Dispose();
    }
}

