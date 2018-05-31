using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

using Autofac;
using Autofac.Integration.WebApi;

using BusinessLayer.Contracts;
using BusinessLayer.Services;

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApplication.Startup))]

namespace WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductsService>().As<IProductsService>().InstancePerLifetimeScope();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            var httpConfiguration = GlobalConfiguration.Configuration;

            var dependencyResolver = new AutofacWebApiDependencyResolver(container);
            httpConfiguration.DependencyResolver = dependencyResolver;
        }
    }
}
