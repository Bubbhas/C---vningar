using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samrai
{
    class DataAccess
    {
        private readonly SamuraiContext context;

        public DataAccess()
        {
            context = new SamuraiContext();
        }

        internal List<Samurai> GetAllSamurais()
        {
            //SORTERAR PÅ NAMN
            //return context.Samurais.OrderBy(x => x.Name).ToList();
            //Sorterar omvänd ordning på id
            return context.Samurais.OrderByDescending(x => x.Id).ToList();


        }
        internal bool GetSamuraiIdentity(string v)
        {
            bool sant = false;
            foreach (var item in context.SecretIdentities)
            {
                if (item.Name == v)
                    sant = true;
            }

            return sant;
        }

        internal List<Battle> ListAllBattles(DateTime now, DateTime dateTime, bool? brutal)
        {
           return context.Battles.Where(x => x.StartTime > now && x.EndTime < dateTime && x.Brutal == brutal).ToList();

        }

        internal List<Quote> ListAllQuotesOfTypes(TypeOfQuote typeOfQuote)
        {

            var zz = context.Quotes.Where(x => x.TypeOfQuote == typeOfQuote);

            if (zz == null) return new List<Quote>();
            else return zz.ToList();
        }
        internal List<Quote> ListAllQuotesOfTypesAndSamurai(TypeOfQuote typeOfQuote)
        {

            var zz = context.Quotes.Include(x=>x.Samurai).
                Where(x => x.TypeOfQuote == typeOfQuote);

            if (zz == null) return new List<Quote>();
            else return zz.ToList();
        }
    }
}
