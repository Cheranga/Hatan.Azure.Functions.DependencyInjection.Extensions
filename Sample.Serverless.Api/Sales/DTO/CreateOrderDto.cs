using System;

namespace Sample.Serverless.Api.Sales.DTO
{
    public class CreateOrderDto
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}