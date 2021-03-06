﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ReshServer
{    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var xmlFormatter = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            GlobalConfiguration.Configuration.Formatters.Remove(xmlFormatter);
        }
    }
}
