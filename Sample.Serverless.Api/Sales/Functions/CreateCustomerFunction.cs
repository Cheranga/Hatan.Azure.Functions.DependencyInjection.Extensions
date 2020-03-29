using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Sample.Serverless.Api.Sales.Configurations;

namespace Sample.Serverless.Api.Sales.Functions
{
    public class CreateCustomerFunction
    {
        private readonly CustomerApiSettings _customerApiSettings;
        private readonly ILogger<CreateCustomerFunction> _logger;

        public CreateCustomerFunction(CustomerApiSettings customerApiSettings, ILogger<CreateCustomerFunction> logger)
        {
            _customerApiSettings = customerApiSettings;
            _logger = logger;
        }

        [FunctionName(nameof(CreateCustomerFunction))]
        public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function, "post", Route = "customers/create")]
            HttpRequest request)
        {
            await Task.Delay(1000);

            return new OkResult();
        }
    }
}