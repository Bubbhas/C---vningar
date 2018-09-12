using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Samrai.Trams;

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

        internal List<SamuraiInfo> GetSamuraiInfo()
        {
           
            return context.Samurais.Select(x => new SamuraiInfo
            {
                Name = x.Name,
                RealName = x.SecretIdentity.Name,
                BattleNames = string.Join(",", x.SamuraiBattle.Select(y => y.Battle.Name))
            }).ToList();
     
        }

        internal Samurai GetBattlesForSamurai(string name)
        {
            context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());
            return context.Samurais.Where(y => y.Name == name).Include(x => x.SamuraiBattle).ThenInclude(o => o.Battle).FirstOrDefault();
            //return context.Samurais.Where(y => y.Name == name).Select(o=>o.SamuraiBattle.Select(p=>p.Battle)).FirstOrDefault();
            //return context.Battles.Select(o=>o.SamuraiBattles.Select(p=>p.Samurai).Where(y => y.Name == name)).FirstOrDefault();
        }

        internal List<Battle> AllBattlesWithLog(DateTime from, DateTime to, bool isBrutal)
        {

            return context.Battles.Include(x => x.BattleLogs).Include(x => x.BattleLogs.BattleEvents).Where(x => x.StartTime > from && x.EndTime < to && x.Brutal == isBrutal).ToList();
        }

        //List<string> list = new List<string> { "kalle", "list" };

        //List<string> newlist = list.Select(x => x.ToUpper()).ToList();
        //List<int> newlist2 = list.Select(x => x.Length).ToList();
        //List<Samurai> newlist3 = list.Select(x => new Samurai()).ToList();
        //List<Samurai> newlist4 = list.Select(x => new Samurai { Name = x }).ToList();
        internal List<string> AllSamuraiNameWithAlias()
        {
           //List<Samurai> listan =  context.Samurais.Include(x => x.SecretIdentity).ToList();
           List<string> newlist = context.Samurais.Include(x => x.SecretIdentity).Select(GetAlias).ToList();
           return newlist;
        }

        private string GetAlias(Samurai y)
        {
            return y.Name + " Alias: " + y.SecretIdentity?.Name;
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
