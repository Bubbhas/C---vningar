using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkWithListOfCustumers11i3
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

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

                var person = new Person();

                person.Id = int.Parse(Id);
                person.FirstName = FirstName;
                person.LastName = LastName;
                person.Email = Email;
                person.Gender = Gender;
                person.Age = int.Parse(Age);

                allPersons.Add(person);
            }

            Header("Sorted list by age: ");

            foreach (var person in allPersons.OrderBy(x=> x.Age))
            {
                WriteAllPersons(person);
            }

            Header("Sorted list by first name: ");

            foreach (var person in allPersons.OrderBy(x => x.FirstName))
            {
                WriteAllPersons(person);
            }

            Header("Men older than 35: ");

            foreach (var person in allPersons.OrderBy(x => x.Age))
            {
                if(person.Age >= 35 && person.Gender == "Male")
                {
                    WriteAllPersons(person);
                }               
            }

            Header("Manipulated: ");



            foreach (var person in allPersons.Where(x => x.Gender == "Male" && x.Age >= 35).Select(x => new Person
            {
                Age = x.Age + 1000,
                FirstName = x.FirstName.ToUpper(),
                Gender = x.Gender     
            }
               ))
            {
                
                WriteAllPersons(person);
              
            }
        }

        private static void WriteAllPersons(Person person)
        {
            Console.WriteLine(person.FirstName.PadRight(8) + " " + person.Age.ToString().PadRight(8) + " " + person.Gender.PadRight(8));
        }

        public static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + v.ToUpper() + "\n");
            Console.ResetColor();
        }
    }

}
