using System;
using System.Collections.Generic;
using System.Text;

namespace shapes7k1
{
    public abstract class Shapes
    {
        public string Name { get; set; }
        abstract public double CalculateArea();
    }

    public class Triangle : Shapes
    {
        public double Bas { get; set; }
        public  double Höjd { get; set; }
        public override double CalculateArea()
        {
            double area = Bas * Höjd;
            return area;
        }
    }
   public class Circle : Shapes
    {
        public double Radie { get; set; }
        public override double CalculateArea()
        {
            return Radie * Radie * Math.PI;
        }
    }

    public class Recangle : Shapes
    {
        public double Bas { get; set; }
        public double Höjd { get; set; }
        public override double CalculateArea()
        {
            double area = Bas * Höjd;
            return area;
        }
    }

}
