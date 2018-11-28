namespace KMP.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Newsmaker : DbContext
    {
        // Your context has been configured to use a 'Newsmaker' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KMP.Models.Newsmaker' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Newsmaker' 
        // connection string in the application configuration file.
        public Newsmaker()
            : base("name=Newsmaker")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }

    public class Article
    {
        public int ArticleId { get; set; }
        public string headLine { get; set; }
        public string postDate { get; set; }
        public string summary { get; set; }
        public string fullText { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }


    public class Category
    {
        public int CategoryId { get; set; }
        public string catName { get; set; }
        public string catQuery { get; set; }
        public int catOrder { get; set; }

        public virtual List<Article> Articles { get; set; }

    }


    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}