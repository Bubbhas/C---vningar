using System;

namespace TesstSjälb
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string response = Methods.AskForInput();
                Methods.CheckWhatProduct(response);
            }

            
            
        }

        
    }
}
