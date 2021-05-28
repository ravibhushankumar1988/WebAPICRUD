using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiTest.App_Start;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace WebApiTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");

            /// How to return only JSON/XML from API ?
            // config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.Remove(config.Formatters.JsonFormatter);

            //Register custom formatter
            //config.Formatters.Add(new CustomJsonFormatter());
        }
    }
}
