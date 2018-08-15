using System;
using System.IO;

namespace exceptions8i2i
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a file name: ");
                string line;
                try
                {
                    var filename = Console.ReadLine();
                    File.CreateText(filename);
                    Console.WriteLine("The file '" + filename + "' is now created");
                    StreamWriter sr = new StreamWriter(@"c:\TMP\bird.txt");
                    line = "Hejsan";

                    sr.WriteLine(line);
                    sr.Close();
                    break;
                }

                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The File name is not valid");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're not authorized to create this file");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (DirectoryNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input output exception");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception x)
                {
                    Console.WriteLine(x);
                }

            }
        }
    }
}

