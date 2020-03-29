using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Sample.Serverless.Api.Sales.Configurations;
using Sample.Serverless.Api.Sales.DTO;

namespace Sample.Serverless.Api.Sales.Functions
{
    public class GetOrdersFunction
    {
        private readonly OrdersApiSettings _ordersApiSettings;
        private readonly ILogger<GetOrdersFunction> _logger;

        public GetOrdersFunction(OrdersApiSettings ordersApiSettings, ILogger<GetOrdersFunction> logger)
        {
            _ordersApiSettings = ordersApiSettings;
            _logger = logger;
        }

        [FunctionName(nameof(GetOrdersFunction))]
        public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function, "get", Route = "orders")]
            HttpRequest request)
        {
            await Task.Delay(1000);

            return new OkObjectResult(new GetOrderDto[]{});
        }
    }
}