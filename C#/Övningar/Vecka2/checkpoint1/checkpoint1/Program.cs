using System;

namespace checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string[] NameList;

            Console.WriteLine("Ange kommando: ");
            string response = Console.ReadLine();

            string[] list = response.Split("-");
            // NameList = NameArray(response);


            foreach (var item in list)
            {
               
                int tal = int.Parse(item);
                //int rows = 1;
                string str = "";
                for (int j = 0; j < tal; j++)
                {
                    Console.WriteLine(str += "*");
                    //    Console.WriteLine();
                    //    for (int i = 0; i < rows; i++)
                    //    {

                    //        Console.Write("*");
                    //    }
                    //rows++;
                    //Console.WriteLine();
                }
            }

        }

        //static string[] NameArray(string response)
        //{
        //    string[] list = response.Split("-");
        //    return list;
        //}
    }
}
