using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtraövningarPandor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Första med fyra pandor
            /* List<int> talen = ReturnListOfDigits(2342);
             Console.WriteLine($"{string.Join(", ", talen)}");
             */

            //SEX PANDOR
            // 1
            //EnglishToMorseCode();
            //2
            //FindTheLongestCommonSubseqeunce("hejsan", "pppsan");
            SortOnlyOddNumbersInArray(new int[] { 100, 95, 20, 30, 77 });

        }

        private static void SortOnlyOddNumbersInArray(int[] array)
        {
            List<int> newShit = new List<int>();
            List<int> omvandling = array.ToList();
            List<int> result = new List<int>();

            foreach (var item in omvandling)
            {
                if(item % 2 != 0)
                {
                    newShit.Add(item);
                }
            }
            newShit.Sort();
            foreach (var nummer in omvandling)
            {
                if (nummer % 2 != 0)
                {
                    result.Add(newShit.First());
                    newShit.RemoveAt(0);
                }
                else
                {
                    result.Add(nummer);
                }
            }
            Console.WriteLine($"{string.Join(", ", result)}");

        }

        private static void FindTheLongestCommonSubseqeunce(string one, string two)
        {
            List<string> listan = new List<string>();

            for (int nrOfChars = 1; nrOfChars < one.Length +1; nrOfChars++)
            {
                for (int index = 0; index <= one.Length-nrOfChars; index++)
                {
                    string s = one.Substring(index, nrOfChars);
                    listan.Add(s);
                }
            }

            foreach (var due in listan.OrderByDescending(x => x))
            {
                if (two.Contains(due))
                {
                    Console.WriteLine("The longest subsequence is " + due);
                    break;
                }

            }

            //foreach (var items in listan)
            //{
            //    Console.WriteLine(items);
            //}
            // aaaaaapandaaaaaaaa
            // panda
            // 1 tecken
            // p
            // a
            // n
            // ..
            // pa
            // an
            // nd
            // ...



        }
        static Dictionary<char, string> EnglishToMorse;
        private static void EnglishToMorseCode()
        {
            EnglishToMorse = new Dictionary<char, string>
            {
                { 'a', ".-" },
                { 'b', "-..." },
                { 'c', "-.-." },
                { 'd', "-.." },
                { 'e', "." },
                { 'f', "..-." },
                { 'g', "--." },
                { 'h', "...." },
                { 'i', ".." },
                { 'j', ".---" },
                { 'k', "-.-" },
                { 'l', ".-.." },
                { 'm', "--" },
                { 'n', "-." },
                { 'o', "---" },
                { 'p', ".--." },
                { 'q', "--.-" },
                { 'r', ".-." },
                { 's', "..." },
                { 't', "-" },
                { 'u', "..-" },
                { 'v', "...-" },
                { 'w', "-.." },
                { 'x', "-..-" },
                { 'y', "-.--" },
                { 'z', "--.." }
            };
            Console.WriteLine("Write something that you want translate to morse code");
            string str = Console.ReadLine().ToLower();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var item in str)
            {
                if(EnglishToMorse.ContainsKey(item))
                {
                    sb.Append(EnglishToMorse[item] + " ");
                } else if (item == ' ')
                {
                    sb.Append("/ ");
                } 
            }
            Console.WriteLine(sb);

            
        }

        private static List<int> ReturnListOfDigits(int a)
        {
            string Sträng = a.ToString();
            List<int> result = new List<int>();
            foreach (var item in Sträng)
            {
                string aa = item.ToString();
                int aaa = int.Parse(aa);
                result.Add(aaa);
            }

           
            return result;
        }
    }
}
