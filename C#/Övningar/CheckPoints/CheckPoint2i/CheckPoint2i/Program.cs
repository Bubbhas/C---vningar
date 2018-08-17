using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CheckPoint2i
{
    class Room
    {
        public string RumsTyp { get; set; }
        public string StorlekPåRum { get; set; }
        public int StorlekPåRum2 { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var allRooms = new List<Room>();


            Console.WriteLine("Ange namn på rum: ");
            string str = Console.ReadLine();
            Console.WriteLine();

            string[] roomList = str.Split("|");

            foreach (var item in roomList)
            {
                string orginal = item;
                if (orginal.StartsWith(" "))
                {
                    orginal = orginal.Substring(1);
                }
                string[] rum = orginal.Split(" ");
                var roomType = rum[0];
                var roomSize = rum[1];

                

                var room = new Room();

                room.RumsTyp = roomType;
                room.StorlekPåRum = roomSize;
     
                allRooms.Add(room);
            }
            var stora = new List<int>();
            foreach (var room in allRooms)
            {
                var storlek = room.StorlekPåRum.Split("m");
                var stor = storlek[0];
                int storleken = int.Parse(stor);
                stora.Add(storleken);

                room.StorlekPåRum2 = storleken;
            }
            var max = stora.Max();

            int rumsNr = 1;
            foreach (var room in allRooms)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("* Rumnamn " + rumsNr + ": " + room.RumsTyp);
                rumsNr++;
                Console.ResetColor();
            }

            foreach (var room in allRooms.Where(x => x.StorlekPåRum2 == max))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("* Det största rummet är " + room.RumsTyp + " på " + room.StorlekPåRum);
                Console.ResetColor();
            }



        }

        
    }
}
