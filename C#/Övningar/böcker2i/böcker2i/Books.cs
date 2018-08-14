using System;
using System.Collections.Generic;
using System.Text;

namespace böcker2i
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
    class ElectronicBook : Books
    {
        public void SendBookTo(string emailAdress)
        {
            Console.WriteLine("Boken skickas till" + emailAdress);
        }
    }
    class Books : Produkter
    {
      

        string Isbn;
        string Author;
        int Pages;

        public void SetIsbn(string v)
        {
            Isbn = v;
        }
        public string GetIsbn()
        {
            return Isbn;
        }
        public void SetAuthor(string v)
        {
            Author = v;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public void SetPages(int value)
        {
            if (value > 0 && value < 1000)
            {
                Pages = value;
            }
            else
            {
                Pages = 300;
            }
        }
        public int GetPages()
        {
            return Pages;
        }
        public double WeightInGram()
        {
            double Weight = Pages * 0.8;
            return Weight;
        }
        public string SetSize()
        {
            if (Pages < 100)
            {

                return "Tunn";
            }
            else if (Pages < 299 && Pages > 100)
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
