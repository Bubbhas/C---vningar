using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CheckPoint6
{
    public class DataAccess
    {
        private readonly SpaceshipContext context;

        public DataAccess()
        {
            context = new SpaceshipContext();
        }

        private void RecreateDatabase()
        {
            using (var context = new SpaceshipContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }   
        }

        internal void AddRavioliForSpaceship(string nameOfSpaceShip, int cans, string v3)
        {
            using (var context = new SpaceshipContext())
            {
                Spaceship space = GetSpaceShipByName(nameOfSpaceShip);
                if(space != null)
                {
                   
                    space.food.Add(new Food
                    {
                        Name = "Ravioli",
                        Quantity = cans,
                        Made = v3
                    });
                    context.SaveChanges();
                }

            }

        }

        private Spaceship GetSpaceShipByName(string nameOfSpaceShip)
        {
            return context.Spaceships.Where(z => z.Name == nameOfSpaceShip).FirstOrDefault();
        }

        public void AddSpaceship(string name)
        {
            using (var context = new SpaceshipContext())
            {
                var Spaceship = new Spaceship
                {
                    Name = name,

                  
            };
                context.Spaceships.Add(Spaceship);
                context.SaveChanges();
            }
        }
        internal List<Spaceship> GetAllSpaceships()
        {
            //return context.Spaceships.OrderBy(x => x.Name).ToList();
            return context.Spaceships.Include(x => x.food).ToList();
        }
    }
}
