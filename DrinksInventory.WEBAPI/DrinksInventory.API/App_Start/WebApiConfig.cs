using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using DrinksInventory.API.Authorization;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace DrinksInventory.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
           // config.Filters.Add(new AuthorizeD  DrinksApiAuthorize());
            // Web API routes
            config.MapHttpAttributeRoutes();

          
            config.Routes.MapHttpRoute(
             name: "UpdateApi",
             routeTemplate: "api/{controller}/{id}/{quantity}",
             defaults: new { quantity=RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "AddApi",
            routeTemplate: "api/{controller}/{name}",
            defaults: new { name=RouteParameter.Optional}
              );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
