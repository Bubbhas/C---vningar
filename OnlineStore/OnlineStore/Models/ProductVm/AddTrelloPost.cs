using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.ProductVm
{
    public class AddTrelloPost
    {
        public string TrelloListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
