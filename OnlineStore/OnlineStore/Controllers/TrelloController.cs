using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models.ProductVm;
using OnlineStore.Models.RequestAllBoards;
using OnlineStore.Models.RequestLists;
using OnlineStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class TrelloController : Controller
    {
        private readonly TrelloService _trelloService;

        public TrelloController()
        {
            _trelloService = new TrelloService("bfa542d72e51f090e1a19550929730e3", "d8487e483ce4edd5b5a88002b543ccfcd81661b3a9fcb3ca9619531186b593be");
        }

        public async Task<IActionResult> Index()
        {
            List<TrelloRoot> result = await _trelloService.GetAllBoards();
            return View(result);
        }
       public async Task<IActionResult> Board(string id)
        {
            List<TrelloList> result = await _trelloService.GetAllListsForBorad(id);
            return View(result);
            //return Ok("Du vill se listor för doarden " + id);
        }   

        public IActionResult AddCardForm(string id)
        {
            var vm = new AddTrelloPost
            {
                TrelloListId = id
            };

            return View("AddCardForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddCardForm(AddTrelloPost post)
        {
            await _trelloService.CreateAcardOnAlist(post.TrelloListId, post.Name, post.Description);

            return View("AddCardFormResponse", post);
        }
    }
}
