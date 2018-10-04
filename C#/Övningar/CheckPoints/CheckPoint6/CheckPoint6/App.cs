using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint6
{
    class App
    {
        DataAccess dataAccess = new DataAccess();
        public void Run()
        {
            RecreateDatabase();

            dataAccess.AddSpaceship("USS Enterprise");
            dataAccess.AddSpaceship("Millennium Falcon");
            dataAccess.AddSpaceship("Cylon Raider");

            dataAccess.AddRavioliForSpaceship("Cylon Raider", 1, "2018-04-19");
            dataAccess.AddRavioliForSpaceship("Millennium Falcon", 1, "2017-01-01");
            dataAccess.AddRavioliForSpaceship("Millennium Falcon", 2, "2018-01-01");
            //dataAccess.AddRavioliForSpaceship("Nalle Puh", 99, "1950-01-01");

            List<Spaceship> list = dataAccess.GetAllSpaceships();
            DisplaySpaceships(list);


        }

        private void DisplaySpaceships(List<Spaceship> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
                foreach (var food in item.food)
                {
                    Console.WriteLine($"{food.Name} Packdatum:{food.Made} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        private void RecreateDatabase()
        {
            using (var context = new SpaceshipContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
