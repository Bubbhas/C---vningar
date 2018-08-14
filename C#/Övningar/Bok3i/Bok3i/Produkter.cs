using System;
using System.Collections.Generic;
using System.Text;

namespace Bok3i
{
    class Produkter
    {
        int ProductId;

        public void SetProductId(int v)
        {
            ProductId = v;
        }
        public int GetProductId()
        {
            return ProductId;
        }
    }

    class ElectronicBook : Book
    {
        public ElectronicBook(string value, string value2) : base(value, value2)
        {
            Author = value;
            Isbn = value2;
        }
        public void SendBookTo(string emailAdress)
        {
            Console.WriteLine("Boken skickas till" + emailAdress);
        }
    }

    class Book : Produkter
    {
        public Book(string value, string value2)
        {
            Author = value;
            Isbn = value2;
        }

        public string Isbn { get; set; }
        public string Author { get; set; }
        public int NrOfPages { get; set; }
        public int ProductId { get; set; }

        public double WeightInGram()
        {
            double Weight = NrOfPages * 0.8;
            return Weight;
        }
        public string Size()
        {
            if (NrOfPages < 100)
            {

                return "Tunn";
            }
            else if (NrOfPages < 299 && NrOfPages > 100)
            {

                return "Normal";
            }
            else
            {

                return "Tjock";
            }
        }

    }
}
