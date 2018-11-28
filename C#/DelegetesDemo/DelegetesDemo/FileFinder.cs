using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegetesDemo
{
    public class FileFinder
    {
        public void FindFiles(string dirPath, Func<string, bool> filter)
        {
            var filePaths = Directory.GetFiles(dirPath);
            foreach (var path in filePaths)
            {
                if(filter(path))
                {
                    Console.WriteLine(path);
                }
            }
        }

    }
}
