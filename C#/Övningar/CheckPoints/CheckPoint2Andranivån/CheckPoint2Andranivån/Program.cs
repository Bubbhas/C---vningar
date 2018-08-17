using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace CheckPoint2Andranivån
{
    public class Room
    {
        public string RumsTyp { get; set; }
        public string StorlekPåRum { get; set; }
        public int StorlekPåRum2 { get; set; }
        public string Ljus { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var allRooms = new List<Room>();
            while (true)
            {
                Console.WriteLine("Ange namn på rum: ");
                string str = Console.ReadLine();
                Console.WriteLine();

                string[] roomList = str.Split(" | ");

                foreach (var item in roomList)
                {
                    Regex rgx = new Regex(@"^\s*[a-zA-Z]+ \d+m2 (ON|OFF)$");

                    string orginal = item;
                    if (orginal.StartsWith(" "))
                    {
                        orginal = orginal.Substring(1);
                    }
                    if (!rgx.IsMatch(orginal))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ogiltliga tecken");
                        Console.ResetColor();
                    }
                    else
                    {
                        string[] rum = orginal.Split(" ");
                        var roomType = rum[0];
                        var roomSize = rum[1];
                        var roomLjus = rum[2];
                        roomLjus.ToUpper();
                       

                        var room = new Room();

                        room.RumsTyp = roomType;
                        room.StorlekPåRum = roomSize;
                        room.Ljus = roomLjus;

                        allRooms.Add(room);

                        var stora = new List<int>();

                        foreach (var room2 in allRooms)
                        {
                            var storlek = room.StorlekPåRum.Split("m");
                            var stor = storlek[0];
                            int storleken = int.Parse(stor);
                            stora.Add(storleken);

                            room.StorlekPåRum2 = storleken;
                        }
                        var max = stora.Max();

                        var lampJävel = new StringBuilder();
                        foreach (var room2 in allRooms.Where(x => x.Ljus == "ON"))
                        {
                            lampJävel.Append(room.RumsTyp);
                            lampJävel.Append(" och ");
                        }
                        lampJävel.Length -= 5;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ljuset är tänt i " + lampJävel);

                        foreach (var room2 in allRooms.Where(x => x.StorlekPåRum2 == max))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Det största rummet är " + room.RumsTyp + " på " + room.StorlekPåRum);
                            Console.ResetColor();
                        }

                        var antalRum = 0;
                        antalRum = allRooms.Count();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lägenheten består av " + antalRum + " rum");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                  
                }

            }
        }
    }
}

