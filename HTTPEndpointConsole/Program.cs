using PocketMusic.Endpoint.HTTPEndpoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Endpoint.HTTPEndpointConsole
{
    class Program
    {
        static void Main()
        {
            //string baseAddress = "http://*:8081/";
            Console.WriteLine("Please enter host address: ");
            string baseAddress = Console.ReadLine();

            OwinStartup.Start(baseAddress);

            Console.WriteLine("Running. Press any key to exit.");
            Console.ReadKey();

            OwinStartup.Stop();
        }
    }
}
