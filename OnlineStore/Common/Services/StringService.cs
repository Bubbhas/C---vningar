using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services
{
    public class StringService
    {

        public string CutString(string newtext, int cutLength)
        {
            if (newtext == null)
                return "";
            else if (newtext != null || cutLength < newtext.Length)
                return newtext.Substring(0, cutLength) + "...";
            else if (cutLength > newtext.Length)
                return newtext;
            else return newtext;
        }
    }
}
