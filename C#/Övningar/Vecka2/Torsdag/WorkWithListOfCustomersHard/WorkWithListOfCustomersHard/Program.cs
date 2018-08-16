using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkWithListOfCustomersHard
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Tennis { get; set; }
        public bool Fruit { get; set; }
        public double IPNumber { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("TextFile1.txt");

            var allPersons = new List<Person>();

            foreach (var item in allLines)
            {
                var splittedLine = item.Split(',');
                var Id = splittedLine[0];
                var FirstName = splittedLine[1];
                var LastName = splittedLine[2];
                var Email = splittedLine[3];
                var Gender = splittedLine[4];
                var Age = splittedLine[5];
                var Tennis = splittedLine[6];
                var Fruit = splittedLine[7];
                var IPNumber = splittedLine[8];

                var person = new Person();

                person.Id = int.Parse(Id);
                person.FirstName = FirstName;
                person.LastName = LastName;
                person.Email = Email;
                person.Gender = Gender;
                person.Age = int.Parse(Age);

                allPersons.Add(person);
            }

            Header("Manipulated: ");

            foreach (var person in allPersons.Where(x => x.Gender == "Male" && x.Age >= 30 && (x.Fruit = true)))
            {
                WriteAllPersons(person);
            }
        }

        private static void WriteAllPersons(Person person)
        {
            Console.WriteLine(person.FirstName.PadRight(12) + " " + person.Age.ToString().PadRight(12) + " " + person.Gender.PadRight(12) + " " + person.IPNumber);
        }

        public static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + v.ToUpper() + "\n");
            Console.ResetColor();
        }
    }

}
