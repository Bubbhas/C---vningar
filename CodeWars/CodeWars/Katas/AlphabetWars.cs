using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class AlphabetWars
    {
        
        public static string AlphabetWar(string fight)
        {
            int leftPoints = 0;
            var fightLetter = fight.ToCharArray();
            Dictionary<string, int> left = new Dictionary<string, int>
        {
            { "w", 4 },{ "p", 3 },{ "b", 2 },{ "s", 1 },
        };
            Dictionary<string, int> right = new Dictionary<string, int>
        {
            { "m", 4 },{ "q", 3 },{ "d", 2 },{ "z", 1 },
        };

            foreach (var item in left.Keys)
            {

            }


            return "";
        }
    }
}
