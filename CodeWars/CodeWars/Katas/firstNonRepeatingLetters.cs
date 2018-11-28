using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class firstNonRepeatingLetters
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            string b = s;
            string a = s.ToUpper();
            foreach (var item in b.ToUpper())
            {
                a = a.Substring(1);
                if(a.Contains(item))
                {
                    b = b.Replace(item.ToString(), "");
                    b = b.Replace(item.ToString().ToLower(), "");
                }
              
            }
            if (string.IsNullOrEmpty(b)) return "";
            Console.WriteLine(b.First().ToString());
           
            return b.First().ToString();
        }
    }
}
