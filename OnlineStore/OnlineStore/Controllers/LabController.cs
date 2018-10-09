using Common.Services;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class LabController : Controller
    {
        public IActionResult lab1()
        {
            var vm = new LabViewModel();
            string newtext ="jaaaaaaaaaaaaaaaaaaaaaaaaa";
            var stringService = new StringService();
            vm.CuttingExample = stringService.CutString(newtext, 5);
                
            return View(vm);
        }
    }
}
