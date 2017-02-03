using PocketMusic.Endpoint.HTTPEndpoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Endpoint.HTTPEndpointService
{
    public partial class CapstoneEndpointService : ServiceBase
    {
        public const string BaseAddress = "http://*:8081/";

        public CapstoneEndpointService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            OwinStartup.Start(BaseAddress);
        }

        protected override void OnStop()
        {
            OwinStartup.Stop();
        }
    }
}
