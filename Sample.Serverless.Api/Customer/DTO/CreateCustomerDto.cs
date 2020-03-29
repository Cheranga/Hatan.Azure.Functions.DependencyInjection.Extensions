using System;

namespace Sample.Serverless.Api.Customer.DTO
{
    public class CreateCustomerDto
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; } = DateTime.Now;
    }
}