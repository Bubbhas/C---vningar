using System;
using System.Collections.Generic;

namespace CheckPoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            // NIVÅ 2
            List<string> result1 = ReorderList(new List<string> { "a", "b", "c", "d", "e" }, new List<int> { 1, 2, 3, 5, 4 });
            List<string> result2 = ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 3, 1, 4, 2 });
            List<string> result3 = ReorderList(new List<string> { "a", "b" }, new List<int> { 2, 2 });
          


            // NIVÅ 1
            List<int> result = MultipleBy100AndAdd3(new List<int> { 2, 8, 3, 11 });



            //foreach (var item in result3)
            //{
            //    Console.Write(item + " ");
            //}
        }

        private static List<string> ReorderList(List<string> list1, List<int> list2)
        {
            var listan = new List<string>();

            foreach (var item in list2)
            {
                listan.Add(list1[item - 1]);        
            }
            
            return listan;
        }

        private static List<int> MultipleBy100AndAdd3(List<int> listan)
        {
            var lista = new List<int>();
            foreach (var item in listan)
            {
                lista.Add(item * 100 + 3);
            }
           

            return lista;
        }
    }
}
