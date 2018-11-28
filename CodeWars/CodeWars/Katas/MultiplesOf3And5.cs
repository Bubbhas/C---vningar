using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class MultiplesOf3And5
    {
        public static int MultiplesOfThreeAndFive(int value)
        {
            int tal = 0;

            for (int i = 0; i < value; i++)
            {
                if(i%3 == 0 || i % 5 == 0)
                {
                    tal += i;
                }
            }
            return tal;
        }
    }
}
