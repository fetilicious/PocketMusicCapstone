using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Endpoint.HTTPEndpoint
{
    public static class OwinStartup
    {
        private static IDisposable _server = null;
        //static string baseAddress = "http://*:8081/";

        public static void Start(string baseAddress)
        {
            // Start OWIN host 
            _server = WebApp.Start<Startup>(url: baseAddress);
        }

        public static void Stop()
        {
            if (_server != null)
            {
                _server.Dispose();
            }
        }

    }
}
