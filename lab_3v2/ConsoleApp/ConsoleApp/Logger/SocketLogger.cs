using System;
using System.Text;

namespace ConsoleApp.Logger
{
    internal class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port)
        {
            this.clientSocket = new ClientSocket(host, port);
        }

        ~SocketLogger()
        {
            Console.WriteLine("Destructor was called");
        }

        public void Log(params string[] messages)
        {
            foreach (string message in messages)
            {
                var time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
                var MsgAndDate = string.Join(time, message);
                byte[] convertedMsg = Encoding.ASCII.GetBytes(MsgAndDate);
                clientSocket.Send(convertedMsg);
            }
        }


        public void Dispose()
        {
            clientSocket.Close();
        }
    }
}
