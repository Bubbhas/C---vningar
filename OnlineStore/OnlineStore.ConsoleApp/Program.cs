using Common.Services;
using System;

namespace OnlineStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string newtext = "jaaaaaaaaaaaaaaaaaaaaaaaaa";
            var stringService = new StringService();
            Console.WriteLine(stringService.CutString(newtext, 5) ); 
        }

    }
}
