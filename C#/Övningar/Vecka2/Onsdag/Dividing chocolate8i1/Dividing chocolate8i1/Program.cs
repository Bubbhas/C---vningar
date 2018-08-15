using System;

namespace Dividing_chocolate8i1
{
    class Program
    {

        public class Devil : Exception
        {
            public Devil(string d) : base(d)
            {
                
              
            }
        }
        static void Main(string[] args)
        {
           
            while(true)
            {
                Console.Write("The chocolate contains 24 pieces");
                Console.WriteLine();
                Console.Write("How many want to share? ");
            
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    decimal share = decimal.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    decimal pieces = 24 / share;
                    Console.WriteLine($"Everyone get {pieces:.##} pieces");
                    Console.WriteLine();
                    break;

                }
                catch (DivideByZeroException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zero people can't divide a chocolate");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("inga bokstäver");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } 


        }
    }
}
