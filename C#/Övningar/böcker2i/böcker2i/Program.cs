using System;

namespace böcker2i
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Books();

            b1.SetIsbn("978-3-16-148410-0");
            b1.SetAuthor("Kalle");
            b1.SetPages(400);
            b1.SetProductId(1234);

            var e1 = new ElectronicBook();
            e1.SetProductId(5678);

            
            bool isBook = b1 is Books;
            bool isEbook = b1 is ElectronicBook;
            bool isProduct = b1 is Produkter;

            bool isBooke = e1 is Books;
            bool isEbooke = e1 is ElectronicBook;
            bool isProducte = e1 is Produkter;


            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:          {b1.GetIsbn()}");
            Console.WriteLine($"   Författare:    {b1.GetAuthor()}");
            Console.WriteLine($"   Antal sidor:   {b1.GetPages()}");
            Console.WriteLine($"   Vikt:          {b1.WeightInGram()} gram");
            Console.WriteLine($"   Storlek:       {b1.SetSize()}");
            Console.WriteLine($"   Produktens Id: {b1.GetProductId()}");
            Console.WriteLine();
            Console.WriteLine("Är b1 en bok?     " + isBook);
            Console.WriteLine("Är b1 en ebok?    " + isEbook);
            Console.WriteLine("Är b1 en bok?     " + isProduct);
            Console.WriteLine();
            Console.WriteLine("Är e1 en bok?     " + isBooke);
            Console.WriteLine("Är e1 en ebok?    " + isEbooke);
            Console.WriteLine("Är e1 en bok?     " + isProducte);
            Console.WriteLine();


            e1.SendBookTo(" jesper");
        }
    }
}
