using System;
using System.Collections.Generic;

namespace ManipulateAList10i4i
{
    class Program
    {
        static void Main(string[] args)
        {

            //Namnen();
            Nummer();
        }


        public static void Nummer()
        {
            List<double> list = new List<double>();
            double nr;
            string str;
            do
            {
                Console.Write("Enter a number: ");
                Console.ForegroundColor = ConsoleColor.Green;
                str = Console.ReadLine();
                
                bool testastring = double.TryParse(str, out nr);
                if (testastring)
                {
                    nr = double.Parse(str);
                    list.Add(nr);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                
            } while (str != "quit");
            Console.WriteLine();
            int check = Convert.ToInt32(list.Count) % 2;
            if (check == 1)
            {
                list.Sort();
                Console.WriteLine();
                double antal = list.Count;
                double halva = antal / 2 + 0.5;
                int talet2 = Convert.ToInt32(halva);
                Console.WriteLine("Medianen är " + list[talet2 - 1]);
            }
            else
            {
                list.Sort();
                Console.WriteLine();
                double antal = list.Count;
                double halva = antal / 2;
                
                int talet2 = Convert.ToInt32(halva);
                double median = (list[talet2] + list[talet2 - 1]) / 2;
                Console.WriteLine("Medianen är " + median);
            }
            Console.WriteLine();
            double helaTalet = 0;

            foreach (var item in list)
            {
                helaTalet = helaTalet + item;
            }

            Console.WriteLine();
            Console.WriteLine("Summan är " + helaTalet);
            Console.WriteLine("Medelvärde är " + helaTalet / list.Count);

        }







            public static void Namnen()
        {
            List<string> list = new List<string>();
            string str;
            do
            {
                Console.Write("Enter a name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                str = Console.ReadLine().ToLower().Trim();
                Console.ForegroundColor = ConsoleColor.Gray;
                list.Add(str);
            } while (str != "quit");

            list.RemoveAt(0);
            list.RemoveAt(list.Count - 1);
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine("Name: " + item);
            }
        }



    }
}
