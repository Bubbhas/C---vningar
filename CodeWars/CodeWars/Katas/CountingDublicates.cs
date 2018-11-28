using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class CountingDublicates
    {
        public static int DuplicateCount(string str)
        {
            var firstList2 = new List<char>();
            var lista = str.ToUpper().ToList();
            int tal = 0;
            foreach (var item in str.ToUpper())
            {
                
                lista.RemoveAt(0);
                if (lista.Contains(item) && !firstList2.Contains(item))
                {
                    tal++;
                }
                firstList2.Add(item);
            }
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
            //return tal;
        }
    }
}
