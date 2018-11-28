using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class SpinTheWords
    {
        public static string SpinsWord(string sentence)
        {
            var lista = sentence.Split();
            var newList = new List<string>();

            foreach (var item in lista)
            {
                if(item.Length >= 5)
                {
                    char[] array = item.ToCharArray();
                    Array.Reverse(array);
                    newList.Add(new string(array));
                }
                else
                newList.Add(item);
            }
            return string.Join(" ", newList);
        }
    }
}
