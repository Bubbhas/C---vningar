namespace OnlineStore.Models.RequestLists

{
    public class TrelloList
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool closed { get; set; }
        public string idBoard { get; set; }
        public decimal pos { get; set; }
        public bool subscribed { get; set; }
    }
}
