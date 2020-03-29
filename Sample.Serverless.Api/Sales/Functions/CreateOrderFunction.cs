using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Sample.Serverless.Api.Sales.Configurations;

namespace Sample.Serverless.Api.Sales.Functions
{
    public class CreateOrderFunction
    {
        private readonly OrdersApiSettings _ordersApiSettings;
        private readonly ILogger<CreateOrderFunction> _logger;

        public CreateOrderFunction(OrdersApiSettings ordersApiSettings, ILogger<CreateOrderFunction> logger)
        {
            _ordersApiSettings = ordersApiSettings;
            _logger = logger;
        }

        [FunctionName(nameof(CreateOrderFunction))]
        public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function, "post", Route = "orders/create")]
            HttpRequest request)
        {
            await Task.Delay(1000);

            return new OkResult();
        }
    }
}