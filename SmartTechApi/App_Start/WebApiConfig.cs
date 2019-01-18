using SmartTech.Repo.Implementation;
using SmartTech.Repo.Interfaces;
using SmartTech.Services.Faculties;
using SmartTech.Services.Implementations.Faculties;
using SmartTech.Services.Implementations.Students;
using SmartTech.Services.Students;
using SmartTechApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace SmartTechApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType(typeof(IRepository<>), typeof(EfRepository<>));
            container.RegisterType<IFacultyService, FacultyService>();
            container.RegisterType<IStudentService, StudentService>();

            config.DependencyResolver = new UnityResolver(container);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
