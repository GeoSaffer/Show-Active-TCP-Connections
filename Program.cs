using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ActiveTCP_Connections
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowActiveTcpConnections();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(".........................................Done.");
            Console.ReadLine();
        }

        public static void ShowActiveTcpConnections()
        {
            Console.WriteLine("Active TCP Connections");
            
            var properties = IPGlobalProperties.GetIPGlobalProperties();
            var connections = properties.GetActiveTcpConnections();
            foreach (var c in connections)
            {
                if (c.State == TcpState.Established)
                {
                    Console.WriteLine($"{c.LocalEndPoint} <==> {c.RemoteEndPoint}");
                }
            }
        }
    }
}
