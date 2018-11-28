using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class YourOrderPlease
    {
       
        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words)) return "";
            var lista = words.Split();  
            var newList = words.Split();
            foreach (var item in lista)
            {
                string resultString = Regex.Match(item, @"\d+").Value;
                int place = Int32.Parse(resultString);
                newList[place -1] = item;
            }
            //return string.Join(" ", newList);


            return string.Join(" ", words.Split().OrderBy(x => x.ToList().Find(z => char.IsDigit(z))));
        }
    }
}
