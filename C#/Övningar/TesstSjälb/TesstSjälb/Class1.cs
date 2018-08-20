using System;
using System.Collections.Generic;
using System.Text;

namespace TesstSjälb
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    class Food : Product
    {
        public string Typ { get; set; }
    }

    class Cars : Product
    {
        public string Märke { get; set; }
    }

}
