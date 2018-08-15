using System;

namespace Böcker1i
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book();
            
            b1.SetIsbn("978-3-16-148410-0");
            b1.SetName("Kalle");
            b1.SetPages(400);

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {b1.Isbn}");
            Console.WriteLine($"   Författare:  {b1.Name}");
            Console.WriteLine($"   Antal sidor: {b1.Pages}");
            Console.WriteLine($"   Vikt:        {b1.WeightInGram()} gram");
            Console.WriteLine($"   Storlek:     {b1.SetSize()}");
            Console.WriteLine();
        }
    }
}
