using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Animalsinalist8i3i
{
    public class Program
    {
 
         static string[] CreateListOfAnimals(string animals)
        {
            string[] list = animals.Split(",");
            return list;
        }

        public static void CheckForValidAnimals(string[] AnimalList)
        {
           
            foreach (var item in AnimalList)
            {
                Regex rgx = new Regex(@"^\w+$");
                if (item.Length > 10)
                    throw new ArgumentException(item + " är för långt");
                if (item.Length == 0)
                {
                    throw new ArgumentException("One of the animals didn't contain any letters");
                }
                if (!rgx.IsMatch(item))
                    {
                    throw new ArgumentException(item + " innehåller ogiltliga tecken");
                    }
            }
        }

        public static void CheckForValidString(string svar)
        {
            if (svar.Length == 0)
            {
                throw new ArgumentException("Animal string don't contain any letters");
            }
        }

        static void Main(string[] args)
        {
           
            string[] AnimalList;
            while (true)
            {
                Console.Write("Enter a list of animals");
                Console.WriteLine();
                

                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string svar = Console.ReadLine();
                    CheckForValidString(svar);
                    AnimalList = CreateListOfAnimals(svar);
                    CheckForValidAnimals(AnimalList);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("There are " + AnimalList.Length + " in the list");
                    break;

                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
              
            }
        }
    }
}
