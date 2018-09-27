using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("WebApi3")]
    public class Test3Controllers : Controller
    {
        [HttpGet("Hello")]
        public string Hello()
        {
            Random random = new Random();
            int randomNr = random.Next(1, 4);
            string fras = "";
            if (randomNr == 1)
            {
                fras = "Bonjour le monde";
            }
            else if (randomNr == 2)
            {
                fras = "Hei maailma";
            }
            else if (randomNr == 3)
            {
                fras = "Hello";
            }
            return fras;
        }

        [HttpGet("Dag")]
        public string Dag()
        {
            //return DateTime.Today.DayOfWeek.ToString();
            // return DateTime.Today.ToString("dddd", new CultureInfo("sv-SE"));
            return DateTime.Today.AddYears(-10).ToString("dddd", new CultureInfo("sv-SE"));
        }


        [HttpGet("Floskel")]
        public string Floskel()
        {
            string texten = "";
            if (DateTime.Today.DayOfWeek.ToString() == "Monday")
            {
                texten = "Uh-oh. Sounds like somebody’s got a case of the mondays";
            }
            else texten = "bääää";
            return texten;
        }

        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {
            return Ok("Hello World");
        }
    }
}
