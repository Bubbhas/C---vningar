using System;
using System.Collections.Generic;
using System.Linq;

namespace FyraPandor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrome();
            //CombineTwoLists();
            //RotateList();
            //Fiboncacci();
            //ListWithStars();
            //SexPandor();
        }

        private static void SexPandor()
        {  
            Console.WriteLine("skriv något");
            string str = Console.ReadLine();
            List<string> ordet = new List<string>();
            foreach (var item in str.Split(' '))
            {
                string firstLetter = item.Substring(0, 1);
                string restOfWord = item.Substring(1, item.Length - 1);
                ordet.Add(restOfWord + firstLetter + "ay");
            } 
            Console.WriteLine("{0}", string.Join(" ", ordet));
        }

        private static void ListWithStars()
        {
            Console.WriteLine("skriv något");
            string str = Console.ReadLine();
            string[] list = str.Split(",");
            int längd = list[0].Length;
            for (int i = 0; i < längd + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine("* " + item.PadRight(6) + "*");
            }

            for (int i = 0; i < längd + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        private static void Fiboncacci()
        {
            int tal = 0;
            int tal2 = 1;
            int fibonacci = 1;
            for (int i = 0; i < 100; i++)
            { 
                Console.WriteLine(tal + "+" + tal2 + " = " + fibonacci);
                fibonacci = tal2 + tal;
                tal = fibonacci - tal;
                tal2 = fibonacci;  
            }
        }

        private static void RotateList()
        {

            Console.WriteLine("skriv något");
            List<string> listan = new List<string>();
            string str = Console.ReadLine();
            string[] list = str.Split(",");
            listan = list.ToList();

            string first = listan[0];
            listan.RemoveAt(0);
            string second = listan[0];
            listan.RemoveAt(0);
            listan.Add(first);
            listan.Add(second);

            string delimitedList = string.Join(",", listan);

            foreach (var i in delimitedList)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        private static void CombineTwoLists()
        {
            List<string> list5 = new List<string>();
            Console.WriteLine("Create first list");
            string str = Console.ReadLine();
            string[] list = str.Split(",");
            Console.WriteLine("Create second list");
            string str2 = Console.ReadLine();
            string[] list2 = str2.Split(",");
            list5 = list2.ToList();
            List<string> list3 = new List<string>();

            foreach (var item in list)
            {
                list3.Add(item);
                foreach (var item2 in list5)
                {
                    list3.Add(item2);
                    list5.Remove(item2);
                    break;
                }
            }
            foreach (var item in list3)
            {
                Console.Write(item + ",");
            }  
        }

        private static void Palindrome()
        {
            Console.WriteLine("Write a word? ");
            string str = Console.ReadLine();
            
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            Console.WriteLine(charArray);


            if (str == reversed)
            {
                Console.WriteLine("Your string is a palindrome");
            }
            else
                Console.WriteLine("Your string is not a palindrome");
        }
    }
}
