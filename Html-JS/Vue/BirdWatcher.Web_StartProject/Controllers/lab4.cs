using BirdWatcher.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher.Web.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new List<Product>
        {
            new Product {Name = "Skiftnyckel", Quantity = 5},
            new Product {Name = "Hammare", Quantity = 10},
            new Product {Name = "Såg", Quantity = 0}

        });
        }

    }
}
