using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToNumber
    {
        public void Run()
        {
            /*
                Hissen börjar på våning 0. 
                För varje "UPP" åker den upp en våning
                För varje "NER" åker den ner en våning

                int result = ElevatorGoUpAndDown(new List<string>{"UPP", "NER", "UPP", "UPP" });            
                ==> 2
             */
            int result = ElevatorGoUpAndDown(new List<string> { "UPP", "NER", "UPP", "UPP" });
            Console.WriteLine(result);
        }

        private int ElevatorGoUpAndDown(List<string> list)
        {
            int våning = 0;

            foreach (var item in list)
            {
                if (item == "UPP")
                {
                    våning++;
                }
                else if (item == "NER")
                {
                    våning--;
                }
            }

            return våning;
        }
    }
}
