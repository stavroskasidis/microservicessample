using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Web.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using SampleApp.Model;

namespace SampleApp.Web.Controllers
{
    public class HomeController : Controller
    {

        const string Service1URL = "http://sampleapp.service1/api/customers";

        public async Task<IActionResult> Index()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Service1URL);
                var customersJson = await response.Content.ReadAsStringAsync();

                var customers = JsonConvert.DeserializeObject<Customer[]>(customersJson);
                return View(customers);
            }
        }
        
    }
}
