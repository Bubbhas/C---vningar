using System;
using System.Collections.Generic;
using System.Text;

namespace shapes7k1
{
    class Methods
    {
        public static string AskUserForInput()
        {
            Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
            String answer = Console.ReadLine().ToLower();
            return answer;
        }

        //static int AskUserForCM()
        //{

        //}

        public static bool CheckAnswer(string answer)
        {
            if (answer.Equals("t"))
            {
                Console.Write("Enter a base of triangle: ");
                int bas = int.Parse(Console.ReadLine());
                Console.Write("Enter a height of triangle: ");
                int höjd = int.Parse(Console.ReadLine());
                var nytriangle = new Triangle();
                nytriangle.Bas = bas;
                nytriangle.Höjd = höjd;

            }
            else if (answer.Equals("r"))
            {
                Console.Write("Enter a base of triangle: ");
                int bas = int.Parse(Console.ReadLine());
                Console.Write("Enter a height of triangle: ");
                int höjd = int.Parse(Console.ReadLine());
                var nyrectangle = new Recangle();
                nyrectangle.Bas = bas;
                nyrectangle.Höjd = höjd;

            }
            else if (answer.Equals("c"))
            {
                Console.Write("Enter radius of cirle: ");
                int raduis = int.Parse(Console.ReadLine());
                var nycircle = new Circle();
                nycircle.Radie = raduis;

                Console.WriteLine(nycircle.Radie);
            }
            else if (answer.Equals("d"))
            {

                return false;
            }
            return true;
        }


        public static void PrintArea()
        {

            Console.WriteLine();

        }
    }
}
