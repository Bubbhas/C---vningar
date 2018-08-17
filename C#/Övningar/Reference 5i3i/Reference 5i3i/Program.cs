using System;
using System.Text;

namespace Reference_5i3i
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

           var p = new Point();
            p.X = 3;
            p.Y = 4;
            Console.WriteLine("Before           Point:(" + p.X + ")");
            Console.WriteLine("Before           Point:(" + p.Y + ")");
            Console.WriteLine();
            Point point = ChangePoint(p);
            Console.WriteLine("Before           Point:(" + point.X + ")");
            Console.WriteLine("Before           Point:(" + point.Y + ")");
            Console.WriteLine();

            
            StringBuilder sb = new StringBuilder();
            sb.Append("Let's go dancing!");
            Console.WriteLine("Before           sb=" + sb);
            ChangeStringBuilder(sb);
            Console.WriteLine("After            sb=" + sb);
            ChangeStringBuilderReplace(sb);
            Console.WriteLine("After            sb=" + sb);

        }
        static Point ChangePoint(Point point)
        {
            point.X = 9999;
            point.Y = 88888;
            return point;
        }
        static void ChangeStringBuilder(StringBuilder sb)
        {
            sb.Append(" Yeah lets go!!!");
        }
        private static void ChangeStringBuilderReplace(StringBuilder sb)
        {
            sb = new StringBuilder("Hoooooooo!");
        }
    }
}
