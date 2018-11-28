using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tolly.Models;
using System.IO;
using System.Net;

namespace Tolly.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DirectWayForToll(string tal)
        {
            if (tal == "2")
            {
                return Tollfile2();
            }
            else if (tal == "1")
                return Tollfile1();
            else return TollWebPage();
        }

            public IActionResult TollWebPage()
        {
            WebClient client = new WebClient();
            string fil1 = client.DownloadString("http://happybits-001-site6.ftempurl.com/tolly");
            CarToll car = GetCarToll(fil1);
            var finalCalc = CalcCarToll(car);

            return Ok($"Avgiften för bilen med typ {car.CarType} och vikten {car.Weight} vid tiden {car.Time} blir totalt: {finalCalc}kr");
        }
        public IActionResult Tollfile1()
        {
    
            string fil1 = System.IO.File.ReadAllText(@"C:\Users\Administrator\Desktop\GIT-Övningar\Html-JS\Tolly\Tolly\Data\file1.txt");
            CarToll car = GetCarToll(fil1);
            var finalCalc = CalcCarToll(car);

            return Ok($"Avgiften för bilen med typ {car.CarType} och vikten {car.Weight} vid tiden {car.Time} blir totalt: {finalCalc}kr");
        }
        public IActionResult Tollfile2()
        {
            string fil1 = System.IO.File.ReadAllText(@"C:\Users\Administrator\Desktop\GIT-Övningar\Html-JS\Tolly\Tolly\Data\file2.txt");
            CarToll car = GetCarToll(fil1);
            var finalCalc = CalcCarToll(car);

            return Ok($"Avgiften för bilen med typ {car.CarType} och vikten {car.Weight} vid tiden {car.Time} blir totalt: {finalCalc}");
        }

        private object CalcCarToll(CarToll car)
        {
            decimal tollPrice = 10;
            decimal typeAffect = CheckCarType(car.CarType);
            decimal weightAffect = CheckCarweight(car.Weight);
            decimal timeAffect = CheckTollTime(car.Time);

            return tollPrice * timeAffect * weightAffect * typeAffect;
        }

        private decimal CheckCarweight(int weight)
        {
            decimal weightAffect = 1;
            if (weight > 1000)
                weightAffect = 1.5m;

            return weightAffect;
        }

        private decimal CheckTollTime(int time)
        {
            decimal timeAffect = 1;
            if (time > 8 && time < 17)
            {
                timeAffect = 1.2m;
            }
            return timeAffect;
        }

        private decimal CheckCarType(string carType)
        {
            decimal priceAffect = 1;
            switch (carType)
            {
                case "Miljöbil":
                    priceAffect = 0;
                    break;
                case "Lastbil":
                    priceAffect = 2;
                    break;
            }
            return priceAffect;
        }

        private CarToll GetCarToll(string fil1)
        {
            string[] words= fil1.Split(";");
            CarToll car = new CarToll
            {
                CarType = words[0],
                Weight = Int32.Parse(words[1]),
                Time = Int32.Parse(words[2]),
            };
            return car;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
