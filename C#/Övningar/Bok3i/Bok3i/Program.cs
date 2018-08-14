using System;

namespace Bok3i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Isbn number: " );
            Console.WriteLine("Enter a Author name: ");

            var b1 = new Book(Console.ReadLine(), Console.ReadLine());

            //b1.Isbn = "978-3-16-148410-0";
            //b1.Author = "Kalle";
            b1.NrOfPages = 400;
            b1.ProductId = 1234;

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:             {b1.Isbn}");
            Console.WriteLine($"   Författare:       {b1.Author}");
            Console.WriteLine($"   Antal sidor:      {b1.NrOfPages}");
            Console.WriteLine($"   Vikt:             {b1.WeightInGram()} gram");
            Console.WriteLine($"   Storlek:          {b1.Size()}");
            Console.WriteLine($"   Produktens id:    {b1.ProductId}");

            Console.WriteLine();

            var e1 = new ElectronicBook("978-9-17-639279-9", "Röda rummet");
            e1.SendBookTo("oo@happybits.se");

        }
    }
}
