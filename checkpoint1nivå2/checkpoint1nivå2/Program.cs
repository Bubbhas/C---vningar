using System;

namespace checkpoint1nivå2
{
    class Program
    {



        public static void Stars(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.Write("*");
            }
        }
       public static void Skrivutsaker(int tal, int rows)
        {
            Console.WriteLine();
            Stars(rows);
            Console.WriteLine();
        }

        public static void DrawtriangleUp(string item)
        {
            string afterTrim = item.Trim('a');
            int tal = int.Parse(afterTrim);
            int rows = 1;
            for (int j = 0; j < tal; j++)
            {
                Skrivutsaker(tal, rows);
                rows++;
            }
        }

        public static void DrawtriangleDown(string item)
        {
            string afterTrim = item.Trim('b');
            int tal = int.Parse(afterTrim);
            int rows = tal;
            for (int j = 0; j < tal; j++)
            {
                Skrivutsaker(tal, rows);
                rows--;
            }
        }
        public static void VarjeSake(string[] StarList)
        {
            foreach (var item in StarList)
            {
                if (item.StartsWith("a"))
                {
                    DrawtriangleUp(item);
                }
                else if (item.StartsWith("b"))
                {
                    DrawtriangleDown(item);
                }
            }
        }


        static string[] StarArray(string response)
        {
            string[] list = response.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            return list;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Ange kommando: ");
            string inputFromUser = Console.ReadLine();
            string response = inputFromUser.ToLower();
            string[] StarList = StarArray(response);
            VarjeSake(StarList);

        }

   
    }
}
