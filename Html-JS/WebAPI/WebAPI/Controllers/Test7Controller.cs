using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("WebApi7")]
    public class Test7Controller : Controller
    {
        [HttpGet("Dokument")]
        public IActionResult AddDocument(Document document)
        {
            return Ok(document);
        }
    }

    public class Document
    {
        public string Titel { get; set; }
        public int Sidor{ get; set; }
        public bool Sammanfattning { get; set; }
        public DateTime Tid { get; set; }
        public decimal Pris { get; set; }
        public int Typ { get; set; }
        public List<string> Taggar { get; set; }
        public int Betyg { get; set; }

    }
}
