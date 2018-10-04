using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Data;
using OnlineStore.Models;

namespace OnlineStore.Services
{
    public class ViewService
    {
        private readonly ApplicationDbContext _context;
        public ViewService(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public Category GetSelectItem(int id)
        {
                return _context.Category.Where(x => x.Id == id).First();
        }
        public List<SelectListItem> GetSelectListImtesforCategories()
        {
            var Categories = _context.Category.ToList();
            var myList = new List<SelectListItem>();

            foreach (var item in Categories)
            {
                return _context.Category.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
                //myList.Add(new SelectListItem
                //{
                //    Text = item.Name,
                //    Value = item.Id.ToString()
                //});
            }
            return myList;
            //return new List<SelectListItem>
            //  {
            //      new SelectListItem
            //      {
            //          Text = "Aaaaaaa",
            //          Value = "111111"
            //      },
            //       new SelectListItem
            //      {
            //          Text = "bbbbbbbbb",
            //          Value = "222222"
            //      },
            //           new SelectListItem
            //      {
            //          Text = "ccccccccccc",
            //          Value = "333333333333"
            //      },
            //  };
        }
    }
}
