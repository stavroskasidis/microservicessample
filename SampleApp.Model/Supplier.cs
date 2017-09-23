using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Model
{
    public class SupplierGetResponse
    {
        public string MachineName { get; set; }
        public IEnumerable<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }

    public class Supplier
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
