using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("WebApi5")]
    public class Test5Controller : Controller
    {
        [HttpGet("Choklad")]
        public IActionResult Choklad(int choklad)
        {
            if (choklad > 0)
            {
                return Ok(25/choklad);
            }
            else
                return BadRequest("Vem fan ska käka då?");
        }

        [HttpGet("Order")]
        public IActionResult Order(string order)
        {
            Regex rx = new Regex(@"^\w{2}-\d{4}$");
            if (rx.IsMatch(order))
            {
                Regex rgx = new Regex(@"^\w{2}-([0-2]\d{3}|3000)$");  
                if (rgx.IsMatch(order))
                {
                    return Ok($"{order} finns i systemet");
                }
                else return NotFound($"{order} finns inte i systemet");
            }
            else return BadRequest("Fel format");
        }

        [HttpGet("Användare")]
        public IActionResult Användare(string användare)
        {
            switch (användare)
            {
                case "Stewie":
                    throw new ArgumentException("DATA ERROR");
                case "Peter":
                    return Content("<img src='/messi.jpg'>", "text/html");
                case "Lois": case "Meg":
                case "Brian":
                    return Content("<img src='/upp.jpg'>", "text/html");
                default:
                    return Content("<img src='/ner.png'>", "text/html");
            }
        }


    }
}
