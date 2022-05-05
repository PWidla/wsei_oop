using ConsoleApp.Logger;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp
{
    class SocketLogger : ILogger
    {
        private ClientSocket clientSocket; 


        public SocketLogger(string host, int port)
        {
            clientSocket = new ClientSocket(host, port);
        }

        ~SocketLogger()
        {
            this.Dispose();
        }

        public virtual void Log(params string[] messages)
        {
           
        }

       
        public void Dispose()
        {
            //
        }

    }
}
