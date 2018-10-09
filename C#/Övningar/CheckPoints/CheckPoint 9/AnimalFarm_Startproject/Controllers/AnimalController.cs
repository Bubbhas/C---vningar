using System.Linq;
using AnimalFarm.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalFarm.Controllers
{
    [Route("animals")]
    public class AnimalController : Controller
    {
        private readonly DatabaseContext _context;

        public AnimalController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Add([FromBody]Animal animal)
        {
            _context.Add(animal);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_context.Animals);
        }

        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok("Number of animals: " + _context.Animals.Count());
        }
    }
}
