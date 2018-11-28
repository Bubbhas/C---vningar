namespace KMP.Migrations
{
    using KMP.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KMP.Models.Newsmaker>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(KMP.Models.Newsmaker context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.Categories.Any())
            {
                context.Categories.AddOrUpdate(
                    new Category {catName = "Sports", catOrder = 2, catQuery = "sports" },
                    new Category { catName = "Music", catOrder = 1, catQuery = "musics" }
                    );
                context.SaveChanges();
            }

            if (!context.Articles.Any())
            {
                context.Articles.AddOrUpdate(
                    new Article { headLine = " yeah",
                        postDate = "2017/02/04",
                        summary ="Hello World",
                        CategoryId = 5,
                        fullText="Have fun"
                    }
                    );
                context.SaveChanges();
            }

        }
    }
}
