using System;

namespace Override_ToString_6i3i
{
    class Program
    {

        class Circle
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int radius { get; set; }

        }
        class Rectangle
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        class Trinagle
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {
            var c = new Circle();
            var r = new Rectangle();
            var t = new Trinagle();
        }
    }
}
