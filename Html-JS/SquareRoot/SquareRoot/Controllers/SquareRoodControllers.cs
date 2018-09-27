using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot.Controllers
{
    
    public class SquareRoodControllers : Controller
    {
        [HttpGet("api/squareroot")]
        public IActionResult SquareRoot(int? number, int number2)
        {
            if(number == null)
            {
                return BadRequest("Ange ett tal");
            }

            if(number < 0)
            {
                return BadRequest("Får inte a roten ur negativa tal");
            }
            double talet = Math.Sqrt((int)number);

            return Ok(Math.Round(talet, number2));
        }

    }
}
