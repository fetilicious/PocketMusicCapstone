using System;
using System.Collections.Generic;
using System.Linq;
using Owin;
using System.Web.Http;
using Microsoft.Practices.Unity;
using PocketMusic.Music.MusicManager;
using PocketMusic.Playlist.PlaylistManager;

namespace PocketMusic.Endpoint.HTTPEndpoint
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.EnableCors();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Dependency Injection
            var container = new UnityContainer();
            container.RegisterType<IMusicManager, MusicManager>(new HierarchicalLifetimeManager());
            container.RegisterType<IPlaylistManager, PlaylistManager>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            appBuilder.UseWebApi(config);
            appBuilder.MapSignalR();
        }
    }
}
