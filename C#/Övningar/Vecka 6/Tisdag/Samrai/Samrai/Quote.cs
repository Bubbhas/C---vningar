using System;
using System.Collections.Generic;
using System.Text;

namespace Samrai
{
    public class Quote
    {
        public int Id { get; set; }
        public string SamuraiQuote { get; set; }
        public Samurai Samurai { get; set; }
        public TypeOfQuote TypeOfQuote { get; set; }
    }
    public enum TypeOfQuote
    {
        Lame,
        Cheesy,
        Awesome
    }
}
