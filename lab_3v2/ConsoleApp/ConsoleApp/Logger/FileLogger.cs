using System;
using System.IO;

namespace ConsoleApp.Logger
{
    public class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string filename)
        {
            this.writer = GetWriter(filename);
        }

        private TextWriter GetWriter(string path)
        {
            var fileExists = File.Exists(path);
            if (!fileExists)
            {
                return File.CreateText(path);
            }

            return File.AppendText(path);
        }

        public override void Dispose()
        {
            if (disposed)
            {
                stream.Dispose();
            }
        }
    }
}