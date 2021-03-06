﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            if (Regex.IsMatch(v, @"^[0-9]{3}-[0-9]{1}-[0-9]{2}-[0-9]{6}-[0-9]{1}$"))
            {
                Isbn = v;
            }
             else
            {
                Isbn = "Felaktigt Isbn-Nummer";
            }
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
