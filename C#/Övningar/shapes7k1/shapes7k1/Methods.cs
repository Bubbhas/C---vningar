using System;
using System.Collections.Generic;
using System.Text;

namespace shapes7k1
{
    class Methods
    {

        private static double AskForNumber()
        {
            double question = double.Parse(Console.ReadLine());
            return question;
        }

        public static Triangle AskForTriangle()
        {
            var triangle = new Triangle();
            triangle.Name = "triangle";
            Console.Write("Enter a base of triangle: ");
            triangle.Bas = AskForNumber();

            Console.Write("Enter a height of triangle: ");
            triangle.Höjd = AskForNumber();
            

            return triangle;
        }
        public static Recangle AskForRectangle()
        {
            var rectangle = new Recangle();
            rectangle.Name = "rectangle";
            Console.Write("Enter a base of rectangle: ");
            rectangle.Bas = AskForNumber();

            Console.Write("Enter a height of rectangle: ");
            rectangle.Höjd = AskForNumber();


            return rectangle;
        }
        public static Circle AskForCircle()
        {
            var circle = new Circle();
            circle.Name = "circle";
            Console.Write("Enter the radie of the circle: ");
            circle.Radie = AskForNumber();

            return circle;
        }


        public static void PrintAllShapes(List<Shapes> ShapeList)
        {
            Console.WriteLine();

            foreach (var item in ShapeList)
            {
                Console.WriteLine($"I have an " + item.Name + " with an area of " +  item.CalculateArea() + " of cm");
            }
        }

        public static List<Shapes> AskUserForInput()
        {
            List<Shapes> ShapeList = new List<Shapes>();
            bool repeat = true;

            do
            {
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
                String answer = Console.ReadLine().ToLower();

                if (answer.Equals("t"))
                {
                    var triangle = AskForTriangle();
                    ShapeList.Add(triangle);
                }
                else if (answer.Equals("r"))
                {
                    var rectangle = AskForRectangle();
                    ShapeList.Add(rectangle);
                }
                else if (answer.Equals("c"))
                {
                    var circle = AskForCircle();
                    ShapeList.Add(circle);
                }
                else if (answer.Equals("d"))
                {
                    break;
                }

            } while (repeat);
            return ShapeList;
        }
    }
}
