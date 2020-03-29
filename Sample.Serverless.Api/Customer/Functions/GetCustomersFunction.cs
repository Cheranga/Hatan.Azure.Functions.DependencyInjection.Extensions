using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Sample.Serverless.Api.Customer.Configurations;
using Sample.Serverless.Api.Customer.DTO;

namespace Sample.Serverless.Api.Customer.Functions
{
    public class GetCustomersFunction
    {
        private readonly CustomerApiSettings _customerApiSettings;
        private readonly ILogger<GetCustomersFunction> _logger;

        public GetCustomersFunction(CustomerApiSettings customerApiSettings, ILogger<GetCustomersFunction> logger)
        {
            _customerApiSettings = customerApiSettings;
            _logger = logger;
        }

        [FunctionName(nameof(GetCustomersFunction))]
        public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function, "get", Route = "customers")]
            HttpRequest request)
        {
            await Task.Delay(1000);

            var customers = Enumerable.Range(1, 10).Select(x => new GetCustomerDto
            {
                CustomerId = Guid.NewGuid().ToString("N"),
                Name = $"Name {x}",
                Address = $"Address {x}"
            }).ToList();

            return new OkObjectResult(customers);
        }
    }
}