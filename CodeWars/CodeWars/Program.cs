using CodeWars.Katas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[]  aa= SplitStringIntoTwo("abcdef");
            //foreach (var item in aa)
            //{
            //    Console.WriteLine(item+" ");
            //}
            //GetSumBetweenNumbers(0, -1);
            //BuildTowers(4);
            //SortTheOdd(new int[] { 5, 3, 2, 8, 1, 4 });
            //ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 });
            //EnoughIsEnough(new int[] { 20, 37, 20, 21, 20, 20, 20 }, 3);
            //FindTheMissingTerm( new List<int> { 0, 5, 10, 20, 25 });
            //ValidParentheses("()");
            //NarcissisticNumber(555);
            //PigLatin.SimplePigLatin("Pig latin is cool");
            //Scramblies.Scramblie("katas", "steak");
            //firstNonRepeatingLetters.FirstNonRepeatingLetter("abba");
            //RPSLP1.RPSLP("rock", "scissor");
            //AlphabetWars.AlphabetWar("zdqmwpbs");
            //MultiplesOf3And5.MultiplesOfThreeAndFive(10);
            //SpinTheWords.SpinsWord("Hey fellow warriors");
            //YourOrderPlease.Order("is2 Thi1s T4est 3a");
            //BackspacesInString.CleanString("a#bc#d#c");
            //CountingDublicates.DuplicateCount("aabbcde");
            NextBigNumberKata.NextBiggerNumber(1234567890);
            

        }

        //private static void NarcissisticNumber(int value)
        //{
        //    string tal = value.ToString();
        //    double sum = 0;
        //    List<string>list = new List<string>();
            
        //    foreach (var item in tal)
        //    {
        //        list.Add(item.ToString());
        //    }
        //    foreach (var item in list)
        //    {
        //        sum += Math.Pow(int.Parse(item), list.Count());
        //    }

        //    if (sum == value)
        //    {
        //        Console.WriteLine(true);
        //    }
        //    else Console.WriteLine(false);
        //}

        private static void ValidParentheses(string input)
        {
            int first = 0;
            int second = 0;
            foreach (var char1 in input)
            {
                if(char1.ToString() == "(")
                {
                    first++;
                }
                else if (char1.ToString() == ")")
                {
                    second++;
                }
            }
            if(input.StartsWith(")") || input.EndsWith("("))
                Console.WriteLine(false);
            if(first == second)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }

        private static void FindTheMissingTerm(List<int> list)
        {
            int first = list[0];
            int sum = list[1] - list[0];
            int tal = list[0];
            foreach (var item in list)
            {
                int tal2 = item - tal;
                if(tal2 != sum && item != first)
                {
                    Console.WriteLine(item - sum);
                    break;
                }
                tal = item;
                
            }


        }

        private static void EnoughIsEnough(int[] arr, int x)
        {
            List<int> ints = new List<int>();
            foreach (var item in arr)
            {
                if( ints.Where(v => v == item).Count() < x)
                {
                    ints.Add(item);
                }
            }

            

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

        }

        private static void ArrayDiff(int[] a, int[] b)
        {
            List<int> newlist = new List<int>();
            
            foreach (var tal in a)
            {
                bool add = true;
                foreach (var item in b)
                {
                    if(item == tal)
                    {
                        add = false;
                    }
                }
                if (add)
                    newlist.Add(tal);
            }


            foreach (var item in newlist)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortTheOdd(int[] v)
        {
            List<int> newlist = new List<int>();
            List<int> result = new List<int>();
            foreach (var item in v)
            {

                if (item % 2 != 0)
                {
                    newlist.Add(item);
                }
            }
            newlist.Sort();
            foreach (var item in v)
            {
                if (item % 2 != 0)
                {
                    result.Add(newlist.First());
                    newlist.RemoveAt(0);
                }
                else
                {
                    result.Add(item);
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void BuildTowers(int v)
        {
            string[] testarray = new string[v];
            int tal = 0;
            for (int i = 0; i < v; i++)
            {
                
                string star = "*";
                string space = "";
                for (int u = v; u > i+1; u--)
                {
                    space += " ";   
                }
              
                for (int j = 0; j < i; j++)
                {
                    star += "**";
                }
                testarray[tal] = space + star + space;
                tal += 1;
            }

            
            foreach (var item in testarray)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetSumBetweenNumbers(int a, int b)
        {
            int tal = a - b;
            int sum = 0;
            if (a > b)
            {
                for (int i = b; i < a+1; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            else
            {
                for (int i = a; i < b+1; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }

        }

        private static string[] SplitStringIntoTwo(string v)
        {
            string[] aa = null;
            aa = v.Split(""[1]);

                return aa;
        }
    }
}
