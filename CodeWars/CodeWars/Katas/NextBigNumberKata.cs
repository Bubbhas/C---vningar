using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class NextBigNumberKata
    {
        public static long NextBiggerNumber(long n)
        {
            var stringOfNumber = n.ToString();
            var listOfNumbers = new List<int>();
            for (int i = 0; i < stringOfNumber.Length; i++)
            {
                listOfNumbers.Add(int.Parse(stringOfNumber[i].ToString()));
            }
            bool work = false;
            int tal = listOfNumbers[listOfNumbers.Count - 1];
            for (int i = n.ToString().Length -1; i>= 0; i--)
            {
                if (listOfNumbers[i] < tal)
                {
                    int talet = listOfNumbers[i];
                    int talet2 = listOfNumbers[i+1];
                    listOfNumbers[i] = talet2;
                    listOfNumbers[i +1] = talet;
                    work = true;
                    break;
                }
                else tal = listOfNumbers[i];
            }
            if (work)
                return long.Parse(string.Join("", listOfNumbers));
            else return -1;
        }
    }
}
