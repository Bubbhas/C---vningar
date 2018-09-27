
using System;

namespace NewsApp.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Intro { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }

}
