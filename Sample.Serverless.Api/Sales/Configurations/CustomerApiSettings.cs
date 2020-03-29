using Hatan.Azure.Functions.DependencyInjection.Extensions;

namespace Sample.Serverless.Api.Sales.Configurations
{
    public class CustomerApiSettings : ICustomApplicationSetting
    {
        public string Url { get; set; }
        public string ApiKey { get; set; }
    }
}
