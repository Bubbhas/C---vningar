using System;
using System.Text;

namespace WorkWithObjects_5i1i
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateString("Tennis anyone?", 5);
            
        }
        static void GenerateString(string repeatme, int cycles)
        {
            var response = new StringBuilder();

  
            for (int i = 0; i < cycles; i++)
            {
               response.Append(repeatme + " ");
            }
            Console.WriteLine(response);
        }
    }
}
