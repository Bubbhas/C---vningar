using System;

namespace Pandor
{
    class Program
    {
        static void Main(string[] args)
        {
            //GreetPerson();
            //AskForNumber();
            //AskForNumberAndChoose();
            PrintsMultiplication();

        }

        private static void PrintsMultiplication()
        {
            Console.WriteLine("Write a number up to 12");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(number * i);
            }
        }

        private static void AskForNumberAndChoose()
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want the sum or product? S/C");
            string str = Console.ReadLine();
            if (str == "C")
            {
                int tal = 0;
                for (int i = 1; i < number + 1; i++)
                {
                    Console.Write(i + " ");
                    tal = tal + i;
                }
                Console.WriteLine("= " + tal);
            }
            else if (str == "S")
            {
                int tal = 1;
                for (int i = 1; i < number + 1; i++)
                {
                    Console.Write(i + " ");
                    tal = tal * i;
                }
                Console.WriteLine("= " + tal);
            }
        }

        private static void AskForNumber()
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i < number + 1; i++)
            {
               bool CheckForValidation = i % 3 == 0 || i % 5 == 0;
               if (CheckForValidation)
                {
                    sum = sum + i;
                    Console.Write(i);
                    if (i != number)
                    {
                        Console.Write(" + ");
                    }

                }
            }
            Console.Write(" = " + sum);
            Console.WriteLine();

        }

        private static void GreetPerson()
        {
            Console.WriteLine("What's your name? ");
            string str = Console.ReadLine();
            if (str == "Alice" || str == "Bob")
                Console.WriteLine("Hello there " + str + "!");
        }
    }
}
