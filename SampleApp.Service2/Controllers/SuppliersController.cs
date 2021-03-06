﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Model;

namespace SampleApp.Service2.Controllers
{
    [Route("api/[controller]")]
    public class SuppliersController : Controller
    {
        // GET api/values
        [HttpGet]
        public SupplierGetResponse Get()
        {
            return new SupplierGetResponse
            {
                MachineName = Environment.MachineName,
                Suppliers = new Supplier[] {
                new Supplier
                {
                    Code = "001",
                    Name = "Apostolis"
                },
                new Supplier
                {
                    Code = "002",
                    Name = "Theodoris"
                }
            }
            };
        }
    }
}
