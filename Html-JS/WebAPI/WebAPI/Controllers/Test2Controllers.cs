using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("WebApi1")]
    public class Test2Controllers : Controller
    {
        [Route("AddPlanet")]
        public IActionResult AddPlanet(Planet planet)
        {
            return Ok($"{planet.Name}  {planet.Size}");
            //var nyPlanet = new Planet();
            //var replacements = new[]
            //{
            //    new{Find="Planet=", Replace=""},
            //    new{Find="Size=", Replace=""}
            //};

            //string formContent = "";
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            //{
                
            //    formContent = reader.ReadToEndAsync().Result;

            //    foreach (var set in replacements)
            //    {
            //        formContent = formContent.Replace(set.Find, set.Replace);
            //    }
            //    string[] words = formContent.Split('&');

            //    nyPlanet.Name = words[0];
            //    nyPlanet.Size = int.Parse(words[1]);
            //}
            //return Ok("Ny planet " + nyPlanet.Name + " skapad med storleken " + nyPlanet.Size);

        }
        [Route("SearchPlanet")]
        public IActionResult SearchPlanet()
        {
            //string formContent = "";
            var formContent = Request.QueryString.ToString().Split('=', '&');

            var nyPlanet = new Planet();
            nyPlanet.Name = formContent[1];
            nyPlanet.Size = int.Parse(formContent[3]);


            return Ok($"Söker i databasen efter planeter med namn {nyPlanet.Name} och storlek {nyPlanet.Size} ");

        }
    }
}
