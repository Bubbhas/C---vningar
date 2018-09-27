using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("WebApi4")]
    public class Test4Controllers : Controller
    {
        [HttpGet("Food")]
        public IActionResult Food(string food)
        {
            if (food == "Melon")
            {

                return Ok("bra käk");
            }
            else
                return Ok("Not så bra käk");
            
        }

        [HttpGet("Tal")]
        public IActionResult Tal(int talet)
        {

            return Ok(talet.ToString() + " * " + talet.ToString() + " = " + (talet * talet).ToString());


        }

        [HttpGet("Siffror")]
        public IActionResult Siffror(int siffra1, int siffra2)
        {
            string listan = "";
            for (int i = siffra1; i <= siffra2; i++)
            {
                if (i == siffra1)
                    listan = siffra1.ToString();
                else
                    listan = listan + ", " + i.ToString();
            };
            return Ok(listan);
        }


        [HttpGet("Color")]
        public IActionResult Color(string color)
        {
            return Content($"<body bgcolor='{color}'>", "text/html");

        }
    }
}
