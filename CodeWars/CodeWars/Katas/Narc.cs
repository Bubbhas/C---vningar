using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class Narc
    {
        public static void NarcissisticNumber(int value)
        {
            string tal = value.ToString();
            double sum = 0;
            List<string> list = new List<string>();

            foreach (var item in tal)
            {
                list.Add(item.ToString());
            }
            foreach (var item in list)
            {
                sum += Math.Pow(int.Parse(item), list.Count());
            }

            if (sum == value)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
    }
}
