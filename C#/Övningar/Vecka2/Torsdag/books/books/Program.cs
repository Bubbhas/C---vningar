using System;
using System.Collections.Generic;

namespace books
{
    public class Product
    {
        public string name { get; set; }
        public string bla { get; set; }
        public string[] store { get; set; }
        public Product(string n, string t)
        {
            name = n;
            bla = t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Product> products = BuildProductDictionary();
            DisplayProductDictionary(products);
        }

        private static void DisplayProductDictionary(Dictionary<int, Product> products)
        {
            foreach (var item in products)
            {

                // var x = string.Join(", ", item.Value.store);

                Console.WriteLine("Product id=" + item.Key + " name=" + item.Value.name + " and bla=" + item.Value.bla /*+ " och säljs i affär " + x*/);
            }
        }
        private static Dictionary<int, Product> BuildProductDictionary()
        {
            var dic = new Dictionary<int, Product>();
            while (true)
            {

                Console.Write("Enter product id, name and bla: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string str = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (String.IsNullOrWhiteSpace(str))
                {
                    break;
                }

                //Console.Write("Enter Stores: ");
                //Console.ForegroundColor = ConsoleColor.Green;
                //string str2 = Console.ReadLine();
                //Console.ForegroundColor = ConsoleColor.Gray;


                string id = "h";
                int ids = 0;
                string productss = "h";
                string products2 = "h";

                //string[] list = str2.Split(',');
                var a = new Product(productss, products2);
                //a.store = list;

                string id4 = str.Split(',')[0];
                int ids4 = int.Parse(id4);

                string products3 = str.Split(',')[2];

                if (products3.Contains(":Replace"))
                {
                    dic.Remove(ids4);
                    productss = str.Split(',')[1];
                    products2 = str.Split(',')[2];
                    dic.Add(ids, a);
                }
                else
                {
                    try
                    {
                        id = str.Split(',')[0];
                        ids = int.Parse(id);
                        productss = str.Split(',')[1];
                        products2 = str.Split(',')[2];
                        dic.Add(ids, a);


                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The product list already contains the id " + ids);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }

            }
            return dic;
        }
    }
}
