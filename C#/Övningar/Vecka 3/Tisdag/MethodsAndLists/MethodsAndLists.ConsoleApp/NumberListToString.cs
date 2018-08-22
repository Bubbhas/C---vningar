using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToString
    {

        public void Run()
        {

            /*
            
                Returnera en text som talar om vilket det första och sista numret är i listan

                string result = ReportFirstAndLastValue(new List<int> {5, 1000, 2000, 3000, 6});

                ==>    Första siffran är 5 och sista siffran är 6
             */
            //string result = ReportFirstAndLastValue(new List<int> { 5, 1000, 2000, 3000, 6 });

            /*
             
                Returnera en text som säger om alla nummer är högre än 100 eller inte.

                string result = ReportIfAllValuesAreHigherThan100(new List<int> {200, 105, 150});
                ==>    Alla nummer är högre än 100

                string result = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 98, 150 });
                ==>    Något nummer är lägre än 100

             */
            //string result = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 105, 150 });

            /*
                Returnera en text hur många negativa tal som finns i listan

                string result = ReportNumberOfNegativeValues(new List<int> {5, 7, -2, 100, -4});
                ==>     Det finns 2 st negativa tal i listan

                string result = ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 });
                ==>     Jippi! Det finns inga negativa tal i listan
             */
            string result = ReportNumberOfNegativeValues(new List<int> { 5, 7, 2, 100, 4 });


            Console.WriteLine("result");
            Console.WriteLine(result);

        }

        private string ReportNumberOfNegativeValues(List<int> list)
        {
            int negativaTal = 0;
            string texter = "";
            foreach (var item in list)
            {
                if (item <=0)
                {
                    negativaTal++;
                }      
            }
            if (negativaTal == 0)
            {
                texter = "Det finns inga negativa tal!";
            }
            else
            {
                texter = "Det finns " + negativaTal + " negativa tal i listan";
            }
            return texter;
        }

        private string ReportIfAllValuesAreHigherThan100(List<int> list)
        {
            string texter = "Alla nummer är högre än 100";
            foreach (var item in list)
            {
                if (item < 100)
                {
                    texter = "Något nummer är lägre än 100";
                }
            }
            return texter;
        }

        private string ReportFirstAndLastValue(List<int> list)
        {
            
            var first = list[list.Count - list.Count];
            var last = list[list.Count - 1];

            return "Första siffran är " + first + " och sista siffran är " + last;
        }
    }
}