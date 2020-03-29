using System;
using System.Collections.Generic;
using System.Text;
using Hatan.Azure.Functions.DependencyInjection.Extensions;

namespace Sample.Serverless.Api.Customer.Configurations
{
    public class CustomerApiSettings : ICustomApplicationSetting
    {
        public string Url { get; set; }
        public string ApiKey { get; set; }
    }
}
