using CheckPoint5.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint5
{
    class App
    {
        DataAccess dataAccess = new DataAccess();
        public void Run()
        {

            AddGnome();
            List<Gnome> gnomes = dataAccess.GetGnomesFromDatabase();
            DisplayGnomes(gnomes);
        }

        private void AddGnome()
        {
            Console.WriteLine("Lägg till en tomtejävel!");
            dataAccess.AddGnome(Console.ReadLine());
        }

        private void DisplayGnomes(List<Gnome> gnomes)
        {
            Console.WriteLine("NAMN".PadRight(20)+ "HAR SKÄGG".PadRight(20)+ "ÄR OND".PadRight(20)+ "TEMPERAMENT".PadRight(20)+ "RAS".PadRight(20));
            foreach (var gnome in gnomes)
            {
                Console.WriteLine(gnome.Name.PadRight(20) + gnome.Beard.ToString().PadRight(20) + gnome.Nice.ToString().PadRight(20) + gnome.Temper.ToString().PadRight(20) + gnome.Race.PadRight(20));
            }
        }
    }
}
