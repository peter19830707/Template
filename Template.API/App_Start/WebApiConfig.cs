using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Template.API.Filter;

namespace Template.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new ElmahErrorAttribute());
            config.Filters.Add(new ApiResultAttribute());
            // Web API 設定和服務

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
