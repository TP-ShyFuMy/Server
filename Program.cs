using System;
<<<<<<< Updated upstream
=======
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SockNet.ServerSocket;
using static TPShyFuMyServer.Program.Arbitre;
>>>>>>> Stashed changes


using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SockNet.ServerSocket;


namespace TPShyFuMyServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Server!");
            var server = new SocketServer();
            server.InitializeSocketServer("0.0.0.0", 80);
            server.SetReaderBufferBytes(2048);
            server.StartListening();
            bool openServer = true;
            while (openServer)
            {
                if (server.IsNewData())
                {
                    var data = server.GetData();
                    Task.Run(() => PrintRequest(data, server));
                }
            }
        }

        private static void PrintRequest(KeyValuePair<TcpClient, byte[]> data, SocketServer server)
        {
            Console.WriteLine(((IPEndPoint) data.Key.Client.RemoteEndPoint).Address +
                              ": " + Encoding.UTF8.GetString(data.Value));
            server.ResponseToClient(data.Key, "received");
        }


        

       

    }
<<<<<<< HEAD

=======
<<<<<<< Updated upstream
}
=======
>>>>>>> 26c86971c400a51e26a7b394853f684dd816dc2d
}
>>>>>>> Stashed changes
