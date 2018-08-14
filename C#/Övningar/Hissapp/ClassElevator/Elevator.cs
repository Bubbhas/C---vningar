using System;
using System.Collections.Generic;
using System.Text;

namespace Hissapp
{
   public  class Elevator
    {

        public Elevator(string namn1, int low, int high, int start, int life)
        {
            namn = namn1;
            lägstaVåning = low;
            högstaVåning = high;
            startVåning = start;
            tidTillUnderhåll = life;
            livPåHiss = "på";
        }
        public Elevator(string namn1, int low, int high)
        {
            namn = namn1;
            lägstaVåning = low;
            högstaVåning = high;
            startVåning = 5;
            tidTillUnderhåll = 10;
            livPåHiss = "på";
        }

        public string namn { get; set; }
        public int lägstaVåning { get; set; }
        public int högstaVåning { get; set; }
        public int startVåning { get; set; }
        public int tidTillUnderhåll { get; set; }
        public string livPåHiss { get; set; }

        public void LivPåHiss()
        {
            if (tidTillUnderhåll <= 0)
            {
                livPåHiss = "av";
            }
        }

        public void GoUp()
        {
            if (startVåning < högstaVåning)
            {
                if (tidTillUnderhåll > 0)
                {
                    startVåning++;
                    tidTillUnderhåll--;
                }
            }
        }
        public void GoDown()
        {
            if (startVåning > lägstaVåning)
            {
                if (tidTillUnderhåll > 0)
                {
                    startVåning--;
                    tidTillUnderhåll--;
                }
            }
        }
        public string Report()
        {
            LivPåHiss();
            return ("Hissen " + namn + " är på våning " + startVåning
                + ". Hissen är " + livPåHiss + ". Tid tills underhåll: " + tidTillUnderhåll);
        }


    }
}
