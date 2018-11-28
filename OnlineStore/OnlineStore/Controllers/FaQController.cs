using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class FaQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pow()
        {
            return View();
        }
        public IActionResult TopFive()
        {

            return View();
        }

        public IActionResult Age()
        {
            return Ok(17);
        }

     
    }
}
