using System;
using System.IO;

namespace DelegetesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = @"C:\Users\Administrator\Desktop";
            var fileFinder = new FileFinder();

            // Named method
            fileFinder.FindFiles(dirPath, MyTextFilter);
            Console.WriteLine();

            // Lambda method
            fileFinder.FindFiles(dirPath, p=>Path.GetExtension(p)==".txt");
            Console.WriteLine();
        }

        static bool MyTextFilter(string path)
        {
            return Path.GetExtension(path) == ".txt";
        }

    }
}
