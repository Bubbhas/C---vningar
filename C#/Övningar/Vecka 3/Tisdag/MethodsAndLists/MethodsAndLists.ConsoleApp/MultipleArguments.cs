using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class MultipleArguments
    {
        public void Run()
        {
            /*
                Returnera närliggande elementen i listan. Den första parametern avser index för "mittenelementet".

                List<string> result = NearbyElements(3, new List<string> {"a", "b", "c", "d", "e"});
                ==> c,d,e
            
                List<string> result = NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" });
                ==> a,b

                List<string> result = NearbyElements(4, new List<string> { "a", "b", "c", "d", "e" });
                ==> d,e

            */
            //List<string> result = NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" });
            /*
                Multiplicera alla tal i listan med den första parametern

                List<double> result = MultiplyAllBy(100, new List<double> { 12, 3.14, 50, 99 });
                ==> 1200, 314, 5000, 9900
             */
            //List<double> result = MultiplyAllBy(100, new List<double> { 12, 3.14, 50, 99 });

            /*
                Returnera en ny lista där vissa ord är med stora bokstäver. 
                Den andra parmetern är en lista av "bool" som anger vilka som ska vara stora.

                List<string> result = SomeToUpper(new List<string> {"what", "does", "the", "fox", "says"}, new List<bool> {true, false, false, true, true});
                ==> WHAT, DOES, the, fox, SAYS
             */
            List<string> result = SomeToUpper(new List<string> { "what", "does", "the", "fox", "says" }, new List<bool> { true, false, false, true, true });

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine($"{string.Join(", ", result)}");
        }

        private List<string> SomeToUpper(List<string> list1, List<bool> list2)
        {
            var result = new List<string>();
            
            foreach (var stringen in list1)
            {
                result.Add(stringen);
            }
            int plats = 0;
            foreach (var item in list2)
            {
                if(item == true)
                {
                    result[plats] = result[plats].ToUpper();
                }
                plats++;
            }
            return result;
        }

        private List<double> MultiplyAllBy(int v, List<double> list)
        {
            var result = new List<double>();

            foreach (var item in list)
            {
                result.Add(item * 100);
            }

            return result;
        }

        private List<string> NearbyElements(int v, List<string> list)
        {
            var result = new List<string>();
            if (v > 0 )
            {
                result.Add(list[v - 1]);
            }
            result.Add(list[v]);
            if (list.Count > v + 1)
            {
                result.Add(list[v + 1]);
            }
            return result;
        }
    }
}

