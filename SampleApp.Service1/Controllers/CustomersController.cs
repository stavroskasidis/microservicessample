using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Model;

namespace SampleApp.Service1.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        // GET api/values
        [HttpGet]
        public CustomerGetResponse Get()
        {
            return new CustomerGetResponse
            {
                MachineName = Environment.MachineName,
                Customers = new Customer[] {
                    new Customer
                    {
                        Code = "001",
                        Name = "Takis"
                    },
                    new Customer
                    {
                        Code = "002",
                        Name = "Mpampis"
                    }
                }
            };
        }
    }
}
