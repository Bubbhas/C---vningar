using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using OnlineStore.Models.Smhi;
using OnlineStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index(WeatherViewModels vm)
        {

            vm.Latitude = 59.1M;
            vm.Longitude = 17.9M;



            return View(vm);
        }

        public IActionResult GetWeather(WeatherViewModels vm)
        {
            try { 
            var smhiService = new SmhiService();
            Rootobject result = smhiService.GetMeteorologicalForecast(vm.Longitude, vm.Latitude);

            vm.TimeTemps = smhiService.FilterTemperature(result, DateTime.Now);
           
            }
            catch (Exception ex)
            {
                vm.ErrorMessage = ex.Message;
            }
             return View("Index", vm);
            }

    }
}
