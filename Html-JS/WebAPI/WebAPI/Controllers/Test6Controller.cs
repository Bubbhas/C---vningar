using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("WebApi6")]

    public class Test6Controller : Controller
    {
        
        //!modelstate.Isvalid
        [HttpGet("Person")]
        public IActionResult AddPerson(SimplePerson person)
        {
            return Ok($"{person.Name} som är {person.Age}år lades till i databasen");
        }

        [HttpGet("Persona")]
        public IActionResult AddPersona(SimplePerson persona)
        {
            if (string.IsNullOrEmpty(persona.Name) && persona.Age <= 0)
            {
                return BadRequest("Du måste ange ett namn och en ålder");
            }
            else if (string.IsNullOrEmpty(persona.Name) || persona.Name.Length > 20)
            {
                return BadRequest("Du måste ange ett namn");
            }
            else if (persona.Age <= 0 || persona.Age > 120)
            {
                return BadRequest("Du måste ange en ålder");
            }
            else
                return Ok($"{persona.Name} som är {persona.Age}år lades till i databasen");
        }


        [HttpGet("PersonaVal")]
        public IActionResult AddPersonaVal(SimplePersonWithAttributes persona)
        {
            if (ModelState.IsValid)
                return Ok($"{persona.Name} som är {persona.Age}år lades till i databasen");
            else return BadRequest(ModelState);

        }

    }
    public class SimplePerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class SimplePersonWithAttributes
    {
        [Required(ErrorMessage = "fel fel fel")]
        [StringLength(20, ErrorMessage = "Inte över 20 tecken")]
        public string Name { get; set; }
        [Required(ErrorMessage = "fel fel fel på åldern")]
        [Range (0, 120, ErrorMessage = "Fel ålder, 0-120 bara")]
        public int? Age { get; set; }
    }
}
