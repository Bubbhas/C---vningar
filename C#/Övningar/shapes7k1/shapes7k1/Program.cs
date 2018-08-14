using System;
using System.Collections.Generic;

namespace shapes7k1
{
 
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> ShapeList = Methods.AskUserForInput();
            Methods.PrintAllShapes(ShapeList);

        }


       
    }
}
