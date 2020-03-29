using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Sample.Serverless.Api.Bootstrap;

[assembly:FunctionsStartup(typeof(Startup))]
namespace Sample.Serverless.Api.Bootstrap
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            
        }
    }
}
