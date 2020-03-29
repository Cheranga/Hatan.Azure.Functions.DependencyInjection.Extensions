using System;
using System.Collections.Generic;
using System.Text;
using Hatan.Azure.Functions.DependencyInjection.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Sample.Serverless.Api.Bootstrap;
using Sample.Serverless.Api.Sales.Configurations;

[assembly:FunctionsStartup(typeof(Startup))]
namespace Sample.Serverless.Api.Bootstrap
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var services = builder.Services;

            services.RegisterConfiguration<CustomerApiSettings>(ServiceLifetime.Scoped);
            services.RegisterConfiguration<OrdersApiSettings>("OrdersApi", ServiceLifetime.Scoped);
        }
    }
}
