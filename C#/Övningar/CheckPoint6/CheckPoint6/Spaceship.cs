using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint6
{
    public class Spaceship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Food> food { get; set; } = new List<Food>();

    }
}
