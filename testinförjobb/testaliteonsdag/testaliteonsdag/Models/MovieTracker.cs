namespace testaliteonsdag.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class MovieTracker : DbContext
    {
        // Your context has been configured to use a 'MovieTracker' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'testaliteonsdag.Models.MovieTracker' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MovieTracker' 
        // connection string in the application configuration file.
        public MovieTracker()
            : base("name=MovieTracker")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Rating { get; set; }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }

    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}