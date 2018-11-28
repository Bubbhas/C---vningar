using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class Scramblies
    {
        public static bool Scramblie(string str1, string str2)
        {
            int tal = 0;
            var secondWord = str1.ToCharArray();
            foreach (var item in secondWord)
            {
                if (str2.Contains(item.ToString()))
                {
                    tal++;
                }
            }
            if(tal == str2.Length)
            {
                return true;
            }
            return false;
        }
    }
}
