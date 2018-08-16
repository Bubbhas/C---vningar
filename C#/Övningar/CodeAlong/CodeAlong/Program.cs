using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeAlong
{
    class Show
    {
        public string Channel { get; set; }
        public TimeSpan StartAt { get; set; }
        public string Title { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var allLines = File.ReadAllLines("TextFile1.txt");

            var allShows = new List<Show>();


            foreach (var item in allLines)
            {
                var splittedLine = item.Split('*');
                var channel = splittedLine[0];
                var time = splittedLine[1];
                var title = splittedLine[2];


                var show = new Show();

                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);
            }

            Header("alla program");

            foreach (var item in allShows)
            {
                Console.WriteLine(item.Title);
            }

            Header("Alla kanaler");

            foreach (var item in allShows)
            {
                Console.WriteLine(item.Channel);
            }
            Console.WriteLine();

            var laterThan21 = new List<Show>();
            foreach (var item in allShows)
            {
                if (item.StartAt.Hours >= 21)
                {
                    laterThan21.Add(item);
                }
            }

            Header("program som börjar efter kl 21");

            foreach (var show in laterThan21)
            {
                WriteInfoAboutShow(show);

            }
            Header("program som börjar efter kl 21");

            foreach (var show in allShows.Where(x => x.StartAt.Hours >= 21))
            {
                WriteInfoAboutShow(show);
            }
            Header("svt i ordning efter starttid");
            foreach (var show in allShows.Where(x => x.Channel == "SVT1").OrderBy(x => x.StartAt))
            {
                WriteInfoAboutShow(show);
            }
            Header("program som börjar efter kl 21");
            NewMethod(allShows);

            Header("shitttttt");
            allShows.Sort((a, b) => String.CompareOrdinal(a.Title, b.Title));

        }

        private static void NewMethod(List<Show> allShows)
        {
            foreach (var show in allShows.Where(x => x.Channel == "SVT1").OrderBy(x => x.StartAt))
            {
                WriteInfoAboutShow(show);
            }
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + v.ToUpper() + "\n");
            Console.ResetColor();
        }

        private static void WriteInfoAboutShow(Show show)
        {
            Console.WriteLine(show.Channel.PadRight(4) + " " + show.StartAt + " " + show.Title);
        }
    }
}
