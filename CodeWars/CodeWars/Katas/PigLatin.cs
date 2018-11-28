using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class PigLatin
    {
        public static string SimplePigLatin(string str)
        {
            var listan = str.Split(" ").ToList();
            var newList = new List<string>();
            foreach (var word in listan)
            {
               string aa = word[0].ToString() + "ay";
                string newWord = word.Substring(1) + aa;
                newList.Add(newWord);
            }

            return string.Join(" ", newList);
        }
    }
}
