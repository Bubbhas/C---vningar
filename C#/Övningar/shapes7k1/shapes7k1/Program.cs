using System;

namespace shapes7k1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                
                string answer = Methods.AskUserForInput();
                if (Methods.CheckAnswer(answer))
                    {
                    
                    }
                else
                {
                    break;
                }                  
            }
            Methods.PrintArea();
        }


       
    }
}
