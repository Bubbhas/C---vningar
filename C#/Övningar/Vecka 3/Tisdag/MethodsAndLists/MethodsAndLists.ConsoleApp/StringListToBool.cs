using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToBool
    {
        public void Run()
        {
            // Demo: Returerna "true" om längen på alla ord tillsammans är större än 10

            /*
                Returnera "true" om alla ord har fem eller fler tecken
             
                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "friday", "ooooooooo" });
                ==> true

                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "fri", "ooooooooo" });
                ==> false
            */
            //bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "fri", "ooooooooo" });
            //Console.WriteLine(result);

            bool result2 = AllWordsTogetherAreLongerThan10(new List<string> { "essssssssssssf", "fri", "o" });
            Console.WriteLine(result2);
        }
        private bool AllWordsTogetherAreLongerThan10(List<string> list)
        {
            bool result2 = true;
            string text = "";
            foreach (var item in list)
            {
                text = text + item;
            }
            if (text.Length < 10)
                result2 = false;
            return result2;
        }

        private bool AllWordsAreFiveLettersOrLonger(List<string> list)
        {
            bool result = true;
            if (result)
            {
                foreach (var item in list)
                {
                    if (item.Length <= 5)
                        result = false;
                }
            }
            return result;
        }
    }
}
