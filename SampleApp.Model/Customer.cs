using System;
using System.Collections;
using System.Collections.Generic;

namespace SampleApp.Model
{
    public class CustomerGetResponse
    {
        public string MachineName { get; set; }
        public IEnumerable<Customer> Customers { get; set; } = new List<Customer>();
    }

    public class Customer
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
