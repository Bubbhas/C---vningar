using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samrai
{
    class App
    {
        public void Run()
        {
            //ClearDataBase();
            //AddOneSamurai();
            //AddSomeSamurais();
            //AddSomeBattles();
            //AddOneSamuraiWithRelatedData();
            //ListAllSamuraiNames();
            //Console.WriteLine("Gissa på en samirais riktiga namn");
            //FindSamuraiWithRealName(Console.ReadLine());
            //ListAllQuotesOfType();
            //ListAllQuotesOfTypeAndSamurai();
            //ListAllBattles();
            //AllSamuraiNameWithAlias();
            //ListAllBattles_WithLog();
            //ShowSamuraiInfo();
            ShowSamuraiBattles();

        }

        private void ShowSamuraiBattles()
        {
            var dataAccess = new DataAccess();
            string v = "Gandalf";
            Samurai samuraiBatles =  dataAccess.GetBattlesForSamurai(v);
            if (samuraiBatles == null)
                Console.WriteLine("Finns ingen sådan samurai");
            else
            {
                Console.WriteLine("Samurai " + v + " is participating in the following battles");
                Console.WriteLine();
                Console.WriteLine("Id".PadRight(30) + "Name");
                foreach (var item in samuraiBatles.SamuraiBattle)
                {
                    Console.WriteLine(item.BattleId +"".PadRight(30) + item.Battle.Name);
                }
            }
           

        }

        private void ShowSamuraiInfo()
        {
            var dataAccess = new DataAccess();
            List<SamuraiInfo> Info = dataAccess.GetSamuraiInfo();
            foreach (var item in Info)
            {
                Console.WriteLine(item.Name + item.RealName + item.BattleNames);
            }

        }

        private void ListAllBattles_WithLog()
        {
            var dataAccess = new DataAccess();
            List<Battle> battle = dataAccess.AllBattlesWithLog(DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5), true);
            foreach (var item in battle)
            {
                Console.WriteLine("Name of battle:".PadRight(50) + item.Name);
                Console.WriteLine("Log name:".PadRight(50) + item.BattleLogs.Name);
                foreach (var eventa in item.BattleLogs.BattleEvents.OrderBy(t=>t.StartTime))
                {
                    Console.WriteLine("Event:".PadRight(50) + eventa.Description + " ("/*+eventa.StartTime +"-"+eventa.EndTime+", "*/ +item.Name+")");

                }
                Console.WriteLine();
                
            }
        }

        private void AllSamuraiNameWithAlias()
        {
            var dataAccess = new DataAccess();
            List<string> namesWithAlias = dataAccess.AllSamuraiNameWithAlias();
            DisplayList(namesWithAlias);
        }

        private void DisplayList(List<string> namesWithAlias)
        {
            foreach (var item in namesWithAlias)
            {
                Console.WriteLine(item);
            }

        }

        private void ListAllBattles()
        {
            var dataAccess = new DataAccess();
            List<Battle> Battles = dataAccess.ListAllBattles(DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5), true);
            foreach (var item in Battles)
            {
                Console.WriteLine(item.Name + " " + item.Brutal + " " + item.StartTime + " " + item.EndTime);
            }
        }

        private void ListAllQuotesOfTypeAndSamurai()
        {
            var dataAccess = new DataAccess();
            List<Quote> Quotes = dataAccess.ListAllQuotesOfTypesAndSamurai(TypeOfQuote.Cheesy);
            foreach (var item in Quotes)
            {
                Console.WriteLine(item.SamuraiQuote + " is a "+ item.TypeOfQuote + " quote by " + item.Samurai.Name);
            }
        }
        private void ListAllQuotesOfType()
        {
            var dataAccess = new DataAccess();
            List<Quote> Quotes = dataAccess.ListAllQuotesOfTypes(TypeOfQuote.Cheesy);
            foreach (var item in Quotes)
            {
                Console.WriteLine(item.SamuraiQuote);
            }
        }

        public void FindSamuraiWithRealName(string name)
        {
            var dataAccess = new DataAccess();
            bool TrueSamurai = dataAccess.GetSamuraiIdentity(name);

            if (TrueSamurai)
                Console.WriteLine("Det finns en samurai som heter så");
            else
                Console.WriteLine("Det finns inte en samurai som heter så");

        }
        private void ListAllSamuraiNames()
        {
            var dataAccess = new DataAccess();
            List<Samurai> samurais = dataAccess.GetAllSamurais();
            foreach (var item in samurais)
            {
                Console.WriteLine(item.Name);
            }
        }

        private void ClearDataBase()
        {
            using (var context = new SamuraiContext())
            {
                foreach (var item in context.Samurais)
                {
                    context.Remove(item);
                }
                foreach (var item in context.Quotes)
                {
                    context.Remove(item);
                }
                foreach (var item in context.SecretIdentities)
                {
                    context.Remove(item);
                }
                foreach (var item in context.Battles)
                {
                    context.Remove(item);
                }
                foreach (var item in context.SamuraiBattles)
                {
                    context.Remove(item);
                }
                foreach (var item in context.BattleLogs)
                {
                    context.Remove(item);
                }
                foreach (var item in context.BattleEvents)
                {
                    context.Remove(item);
                }
                context.SaveChanges();
            }
        }

        private void AddOneSamuraiWithRelatedData()
        {
            using (var context = new SamuraiContext())
            {
                var samurai = new Samurai
                {
                    Name = "Gandalf",
                    Sword = "Pinnjävel",
                    Clan = "Ringbärarna",
                    Quotes = new List<Quote>
                    {
                        new Quote
                        {
                            SamuraiQuote = "heeeeeey maakarena",
                            TypeOfQuote =TypeOfQuote.Cheesy
                        }
                    },
                    HairCut = HairCut.Oicho,
                    SecretIdentity = new SecretIdentity
                    {
                        Name = "Galadriel"
                    },
                    SamuraiBattle = new List<SamuraiBattle>
                    {
                       new SamuraiBattle
                       {
                           Battle = new Battle
                           {
                                    Name = "Slaget om de två tornen",
                                    Brutal = true,
                                    StartTime = DateTime.Now,
                                    EndTime = DateTime.Now.AddDays(1),
                                    BattleLogs = new BattleLog
                                    {
                                            Name = "Logg om kriget",
                                            BattleEvents = new List<BattleEvent>
                                        {
                                        new BattleEvent
                                        {
                                            Name = "Aragon Gör stuff",
                                            Description = "Tävling mellan legolas och gimli",
                                            StartTime = DateTime.Now,
                                            EndTime = DateTime.Now.AddDays(1)
                                        },
                                            new BattleEvent
                                            {
                                                Name = "Gandalf",
                                                Description = "Gandalf får spö av sauroman",
                                                StartTime = DateTime.Now.AddDays(1),
                                                EndTime = DateTime.Now.AddDays(2)
                                            }
                                        }
                                    }
                           }
                        }
                    }
                    
            };
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }

        private void AddSomeBattles()
        {
            using (var context = new SamuraiContext())
            {
                List<Battle> battles = new List<Battle>
                {
                    new Battle
                    {
                        Name = "Slaget om midgård",
                        Brutal = true,
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(1),
                        BattleLogs = new BattleLog
                        {
                            Name = "Log of slaget om midgård",
                            BattleEvents = new List<BattleEvent>
                            {
                                new BattleEvent
                                {
                                    Name = "Orcerna anfaller porten",
                                    Description = " Orcerna misslyckas med att anfalla porten",
                                    StartTime = DateTime.Now,
                                    EndTime = DateTime.Now.AddDays(1)
                                },
                                new BattleEvent
                                {
                                    Name = "Frodo",
                                    Description = "Frodo smyger sig förbi orcerna",
                                    StartTime = DateTime.Now.AddDays(1),
                                    EndTime = DateTime.Now.AddDays(2)
                                }
                            }
                        }
                    },
                      new Battle
                    {
                        Name = "The hobbit Fight",
                        Brutal = true,
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(6),
                        BattleLogs = new BattleLog
                        {
                            Name = "Loggan of the logg",
                            BattleEvents = new List<BattleEvent>
                            {
                                new BattleEvent
                                {
                                    Name = "Legolas hjälper alla",
                                    Description = "Legolas hoppar och far, och dödar alla själv",
                                    StartTime = DateTime.Now,
                                    EndTime = DateTime.Now.AddDays(3)
                                },
                                new BattleEvent
                                {
                                    Name = "Gimli",
                                    Description = "Gimli är ett litet barn och slår ner en orc",
                                    StartTime = DateTime.Now.AddDays(1),
                                    EndTime = DateTime.Now.AddDays(4)
                                }
                            }
                        }
                    }

                };
                context.Battles.AddRange(battles);
                context.SaveChanges();
            }
        }

        private void AddSomeSamurais()
        {

            using (var context = new SamuraiContext())
            {
                List<Samurai> samurais = new List<Samurai>
                {
                    new Samurai
                {
                    Name = "Jesper",
                    HairCut = HairCut.Chonmage
                },
                     new Samurai
                {
                    Name = "Kasken",
                    HairCut = HairCut.Chonmage
                },
                      new Samurai
                {
                    Name = "Vurken",
                    HairCut = HairCut.Chonmage
                }
                };

                context.Samurais.AddRange(samurais);
                context.SaveChanges();
            }

        }

        private static void AddOneSamurai()
        {
            var samurai = new Samurai { Name = "Zelda" };

            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }
    }
}
