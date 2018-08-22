using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToNumberList
    {
        public void Run()
        {

            //List<int> result = Add100ToEachNumber(new List<int> { 5, 15, 23, 200 });
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            //List<int> result = GetNumbersHigherThan1000(new List<int> { 1005, 6, 77, 200000, 666 });
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            //List<int> result = GetNumbersDividableByFive(new List<int> { 20, 5, 6, 7, 10 });
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            //List<int> result = DivideEachNumberBy100(new List<int> { 300, 200, -500, 1000 });
            //    foreach (var item in result)
            //     {
            //    Console.Write(item + " ");
            //    }

            //List<int> result = NegateEachNumber(new List<int> { 10, 20, -30, 40 });
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            //List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200, 300 });
            //List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16 });
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}


            List<int> result = Add70ToEverySecondElement(new List<int> { 1000, 2000, 3000, 4000, 5000 });
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            //List<int> result = DivideEachNumberBy100(NegateEachNumber(new List<int> { 300, 200, -500, 1000 }));
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

        }

        private List<int> Add70ToEverySecondElement(List<int> list)
        {
            var result = new List<int>();
            int tal = 1;
            foreach (var item in list)
            {
                if (tal++ % 2 == 0)
                {
                    result.Add(item + 70);
                }
                else
                {
                    result.Add(item);
                }
            }
            return result;
        }

        private List<int> Add50ToFirstThreeElements(List<int> list)
        {
            int tal = 0;
            var result = new List<int>();
            foreach (var item in list)
            {
                if (tal != 3)
                {
                    result.Add(item + 50);
                    tal++;
                }
                    

                else
                    result.Add(item);
            }
                
          
            
            return result;
        }

        private List<int> NegateEachNumber(List<int> list)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                if (item >= 0)
                    result.Add(item * -1);
                else
                    result.Add(item);
            }
            return result;
        }

        private List<int> DivideEachNumberBy100(List<int> list)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                
                    result.Add(item / 100);
                
            }
            return result;
        }

        private List<int> GetNumbersDividableByFive(List<int> list)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                if (item % 5 == 0)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        private List<int> GetNumbersHigherThan1000(List<int> list)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                if (item > 1000)
                {
                    result.Add(item);
                }                
            }
            return result;
        }

        private List<int> Add100ToEachNumber(List<int> list)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                result.Add(item + 100);
            }
            return result;
        }
    }
}