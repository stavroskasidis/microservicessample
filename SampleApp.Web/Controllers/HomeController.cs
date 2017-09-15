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

#if DEBUG
        const string Service1URL = "http://sampleapp.service1/api/customers";
        const string Service2URL = "http://sampleapp.service2/api/suppliers";
#else 
        const string Service1URL = "http://sampleapp.service1/api/customers";
        const string Service2URL = "http://sampleapp.service2/api/suppliers";
#endif

        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Service1URL);
                var customersJson = await response.Content.ReadAsStringAsync();
                model.Customers= JsonConvert.DeserializeObject<Customer[]>(customersJson);


                response = await httpClient.GetAsync(Service2URL);
                var suppliersJson = await response.Content.ReadAsStringAsync();
                model.Suppliers = JsonConvert.DeserializeObject<Supplier[]>(customersJson);

                return View(model);
            }
        }
        
    }
}
