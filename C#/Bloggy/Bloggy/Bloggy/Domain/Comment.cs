using System;
using System.Collections.Generic;
using System.Text;

namespace Bloggy.Domain
{
    class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }
        public string PostTitle { get; set; }

    }
}
