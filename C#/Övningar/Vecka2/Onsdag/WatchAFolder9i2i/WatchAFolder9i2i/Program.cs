using System;
using System.IO;
namespace WatchAFolder9i2i
{
    class Program
    {
        void Main(string[] args)
        {
            var x = new FileSystemWatcher();

            x.Path = @"c:\TMP";
            x.EnableRaisingEvents = true;

            x.Created += EnFilharLagtsTill;

            Console.ReadKey();
        }

        private void EnFilharLagtsTill(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("I'm watching this folder: " + e.Name);
        }

    }
}
