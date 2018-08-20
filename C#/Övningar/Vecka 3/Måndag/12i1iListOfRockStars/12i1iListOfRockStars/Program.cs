using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12i1iListOfRockStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "Jesper Eriksson"};
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "Jesper Eriksson" };

            DisplayArrayOfRockStars(rockstarsArray);
            Console.WriteLine();
            DisplayListOfRockStars(rockstarsList);
            Console.WriteLine();
            DisplayRockStars(rockstarsArray);
            Console.WriteLine();
            DisplayRockStars(rockstarsList);
            Console.WriteLine();
            DisplayRockStarsList(rockstarsArray);
            Console.WriteLine();
            RemoveFirstRockStar(rockstarsList);

        }

        static void DisplayArrayOfRockStars(string[] rockstars)
        {
            
            foreach (var item in rockstars)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayListOfRockStars(List<string> rockstars)
        {
            foreach (var item in rockstars)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayRockStars(IEnumerable<string> rockstars)
        {
            foreach (var item in rockstars)
            {
                Console.WriteLine(item);

            }
        }
        static void DisplayRockStarsList(IEnumerable<object> rockstars)
        {

            foreach (var item in rockstars)
            {
                Console.WriteLine(item);

            }
        }
        static void RemoveFirstRockStar(IEnumerable<string> rockstars)
        {

            List<string> rockare = rockstars.ToList();
            rockare.RemoveAt(0);

            foreach (var item in rockare)
            {
                Console.WriteLine(item);
            }
        }
    }
}
