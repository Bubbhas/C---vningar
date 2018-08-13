using System;
using System.Collections.Generic;

namespace shapes7k1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
            String svar = Console.ReadLine().ToLower();

            while (!svar.Equals("D"))
            {
                
                string answer = Methods.AskUserForInput();
                Methods.CheckAnswer(answer);
                              
            }
            Methods.PrintArea();
        }


       
    }
}
