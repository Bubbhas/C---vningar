using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToStringList
    {

        public void Run()
        {
            /*
                Lägg till tre stjärnor innan och efter siffran
                
                List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });

                ==>  ***1003***, ***20***, ***-130***, ***2040***
            */
            //List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });


            /*
                Samma men lägg bara till stjärnor runt de som är större än 1000
             
                List<string> result = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });

                ==>   ***1003***, 20, -130, ***2040***
            */
            //List<string> result = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });

            /*
                Negativa tal => "ZIP"
                Positiva tal => "ZAP"
                Noll         => "BOING"
            
                List<string> result = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });
 
                =>    ZAP, ZAP, ZIP, BOING, ZAP
            */
            //List<string> result = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });

            /*
              
                Skapa en lista av strängar som meddelar om personen är kort eller lång (över 160cm). Hoppa över orimliga värden

                List<string> result = LongOrShort(new List<int> {170, 130, 205, -10, 600, 180});

                ==>    LÅNG, KORT, LÅNG, LÅNG

             */
            List<string> result = LongOrShort(new List<int> { 170, 130, 205, -10, 600, 180 });

            Console.WriteLine($"{string.Join(", ", result)}");
        }

        private List<string> LongOrShort(List<int> list)
        {
            var result = new List<string>();
            foreach (var item in list)
            {
                if (item > 160 && item < 250)
                {
                    result.Add("Lång");
                }
                else if (item < 160 && item > 100)
                {
                    result.Add("Kort");
                }
            }
            return result;
        }

        private List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> list)
        {
            var result = new List<string>();
            foreach (var item in list)
            {
                if (item > 0)
                {
                    result.Add("ZAP");
                }
                else if (item == 0)
                {
                    result.Add("BOING");
                }
                else
                    result.Add("ZIP");
            }
            return result;
        }

        private List<string> AddStarsToNumbersHigherThan1000(List<int> list)
        {
            var result = new List<string>();
            foreach (var item in list)
            {
                if (item >= 1000)
                    result.Add("***" + item.ToString() + "***");
                else
                    result.Add(item.ToString());
            }
            return result;
        }

        private List<string> AddStars(List<int> list)
        {
            var result = new List<string>();
            foreach (var item in list)
            {
                result.Add("***" + item.ToString() + "***");
            }
            return result;
        }
    }
}