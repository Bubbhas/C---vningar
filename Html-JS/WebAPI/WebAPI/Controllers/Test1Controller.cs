using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("test1")]
    public class Test1Controller : Controller
    {
        [Route("hej")]

        public string Hej()
        {
            return "Hej!";
        }
        [Route("pingvin")]
        public string Pingvin()
        {
            return "Pingvin";
        }
    }
}
