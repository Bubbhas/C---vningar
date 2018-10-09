using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class AdminController : Controller
    {


        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = "nyRoll2" });
            await _userManager.CreateAsync(new IdentityUser { Email = "jeppe@hotmail.com", UserName = "jeppe@hotmail.com" });
            

           

            return View();
        }


        public async Task<IActionResult> AddRole(Admin admin)
        {
            IdentityUser user =  await _userManager.FindByNameAsync(admin.Email);
            await _userManager.AddToRoleAsync(user, admin.RoleName);
            //user.Email = "hejsanpejsan";
            //await _userManager.
            //    SetEmailAsync(user, "a@b.se");
            
            return Ok("jadå det funkade");

            //if (admin == null)
            //{
            //    return NotFound();
            //}

            //var Admin = await _userManager.FindByNameAsync("kalle@gmail.com");
            //await _roleManager.CreateAsync(new IdentityRole { Name = "NyRoll" });

            //if (Admin == null)
            //{
            //    return NotFound();
            //}
            //return View(Admin);
        }


    }
}
