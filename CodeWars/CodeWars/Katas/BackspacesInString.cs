using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class BackspacesInString
    {
        public static string CleanString(string s)
        {
            var result = "";
            foreach (char item in s)
            {
                if(item != '#') { result += item; }
                else
                {
                    if(result.Length > 0)
                    {
                        result = result.Remove(result.Length - 1);
                    }
                }
            }
            return result;
        }
    }
}
