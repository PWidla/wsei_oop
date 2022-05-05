using ConsoleApp.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
           

        }

        ~FileLogger()
        {
            this.Dispose();
        }

        public override void Dispose()
        {
           //todo
        }

        

    }
}
