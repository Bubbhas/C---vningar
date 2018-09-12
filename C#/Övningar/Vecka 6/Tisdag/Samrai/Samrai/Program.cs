using System;
using System.Collections.Generic;
using System.Linq;

namespace Samrai
{
    class Program
    {
        static void Main(string[] args)
        {
            new App().Run();
            Console.ReadKey();
            //List<string> list = new List<string> { "kalle", "list" };

            //List<string> newlist = list.Select(x => x.ToUpper()).ToList();
            //List<int> newlist2 = list.Select(x => x.Length).ToList();
            //List<Samurai> newlist3 = list.Select(x => new Samurai()).ToList();
            //List<Samurai> newlist4 = list.Select(x => new Samurai { Name = x }).ToList();
        }
    }
}
