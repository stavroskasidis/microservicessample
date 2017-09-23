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

        const string Service1URL = "http://service1/api/customers";
        const string Service2URL = "http://service2/api/suppliers";

        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel();
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(Service1URL);
                    var customersJson = await response.Content.ReadAsStringAsync();
                    model.CustomersResponse = JsonConvert.DeserializeObject<CustomerGetResponse>(customersJson);

                    response = await httpClient.GetAsync(Service2URL);
                    var suppliersJson = await response.Content.ReadAsStringAsync();
                    model.SuppliersResponse = JsonConvert.DeserializeObject<SupplierGetResponse>(suppliersJson);

                   
                }
            }
            catch(Exception ex)
            {
                model.Error = ex.ToString();
            }

            return View(model);
        }
        
    }
}
