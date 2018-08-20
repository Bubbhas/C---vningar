using System;
using System.Collections.Generic;
using System.Text;

namespace TesstSjälb
{
    class Methods
    {
        public static string AskForInput()
        {
            Console.WriteLine("Vad för typ av produkt vill du lägga till?");
            string str = Console.ReadLine();
            return str;
        }
       public static void CheckWhatProduct(string response)
        {
           if (response.Equals("food"))
            {
              string[]  matSträngLista = MakeResponseToList(response);
               
            }
           else if (response.Equals("car"))
            {
                string[] carSträngLista = MakeResponseToList(response);
            }
        }

        private static string[] MakeResponseToList(string response)
        {
            Console.WriteLine("Skriv in Id, namn och typ av mat");
            string str = Console.ReadLine();
            string[] SträngLista = str.Trim().Split(",");
            return SträngLista;
        }
    }
}
