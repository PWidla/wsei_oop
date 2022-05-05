using ConsoleApp.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;
            writer.WriteLine();
            writer.Flush();
        }

        public override void Dispose()
        {
            //todo
        }

    }
}
