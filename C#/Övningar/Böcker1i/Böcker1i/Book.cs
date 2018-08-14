using System;
using System.Collections.Generic;
using System.Text;

namespace Böcker1i
{
    public class Book
    {

        public string Isbn { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public double Weight { get; set; }
        
      

        public void SetIsbn(string v)
        {
            Isbn = v;
        }
        public void SetName(string v)
        {
            Name = v;
        }

        public void SetPages(int v)
        {
            Pages = v;
        }

        public double WeightInGram()
        {
            Weight = Pages * 0.8;
            return Weight;
        }
        public string SetSize()
        {
            if (Pages < 100)
            {
               
                return "Tunn";
            }
            else if (Pages < 299 && Pages > 100)
            {
                
                return "Normal";
            }
            else
            {
                
                return "Tjock";
            }

        }

    }



}
