using Newtonsoft.Json;
using OnlineStore.Models.ProductVm;
using OnlineStore.Models.RequestAllBoards;
using OnlineStore.Models.RequestLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Services
{
    public class TrelloService
    {
        string _devkey;
        string _token;
        HttpServices _httpService = new HttpServices();

        public TrelloService(string devkey, string token)
        {
            _devkey = devkey;
            _token = token;
        }

        public async Task<List<TrelloRoot>> GetAllBoards()
        {
            string url = $"https://api.trello.com/1/members/me/boards?key={_devkey}&token={_token}";
            string result = await _httpService.Get(url);
            return JsonConvert.DeserializeObject<List<TrelloRoot>>(result);
        }

        public async Task<List<TrelloList>> GetAllListsForBorad(string id)
        {
            string url = $"https://api.trello.com/1/boards/{id}/lists?key={_devkey}&token={_token}";
            string result = await _httpService.Get(url);
            return JsonConvert.DeserializeObject<List<TrelloList>>(result);
        }

        public async Task CreateAcardOnAlist(string trelloListId, string name, string description)
        {
            string url = $"https://api.trello.com/1/cards?name={name}&desc={description}&idList={trelloListId}&keepFromSource=all&key={_devkey}&token={_token}";
            string result = await _httpService.Post(url);
        }
    }
}   
