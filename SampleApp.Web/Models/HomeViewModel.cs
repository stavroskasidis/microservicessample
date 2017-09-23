using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Web.Models
{
    public class HomeViewModel
    {
        public CustomerGetResponse CustomersResponse { get; set; } = new CustomerGetResponse();
        public SupplierGetResponse SuppliersResponse { get; set; } = new SupplierGetResponse();
        public string Error { get; set; }
        
    }
}
