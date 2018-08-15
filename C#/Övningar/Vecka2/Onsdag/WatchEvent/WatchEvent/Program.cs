using System;
using System.IO;

namespace WatchEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new FileSystemWatcher();

            x.Path = @"c:\TMP";
            x.EnableRaisingEvents = true;

            x.Created += EnFilharLagtsTill;
            x.Changed += EnFilHarÄndrats;
            x.Deleted += EnFilHarTagitsBort;
            x.Renamed += EnFilHarByttNamn;
           
            
            

            Console.ReadKey();
        }

  

        private static void EnFilHarByttNamn(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("File " + e.Name + " renamed");
        }

        private static void EnFilHarTagitsBort(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File " + e.Name + " removed");
        }

        private static void EnFilHarÄndrats(object sender, FileSystemEventArgs e)
        {
            StreamWriter sr = new StreamWriter(@"c:\TMP\statistics.txt");

            sr.WriteLine();
            sr.Close();

            Console.WriteLine("File " + e.Name + " changed");
        }

        private static void EnFilharLagtsTill(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File " + e.Name + " created");
        }
    }
}
