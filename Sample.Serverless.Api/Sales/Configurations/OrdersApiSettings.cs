using Hatan.Azure.Functions.DependencyInjection.Extensions;

namespace Sample.Serverless.Api.Sales.Configurations
{
    public class OrdersApiSettings : ICustomApplicationSetting
    {
        public string Url { get; set; }
        public string ApiKey { get; set; }
        public int ItemCount { get; set; }
        public bool IsTrial { get; set; }
    }
}