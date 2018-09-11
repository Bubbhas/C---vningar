using System;
using System.Collections.Generic;
using System.Text;

namespace Samrai
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sword { get; set; }
        public string Clan { get; set; }
        public List<Quote> Quotes { get; set; }
        public HairCut HairCut { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
        public List<SamuraiBattle> SamuraiBattle { get; set; }

    }
    public enum HairCut
    {
        Chonmage,
        Oicho,
        Western
    }
}
