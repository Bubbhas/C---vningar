using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsApp.Models
{
    public class NewsRepository
    {
        private readonly DatabaseContext context;

        public NewsRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(News news)
        {
            context.Add(news);
            context.SaveChanges();
        }

        public IEnumerable<News> GetAll()
        {
            return context.News.ToList();
        }

        public int CountAll()
        {
            return context.News.ToList().Count;
        }


        public News GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool NewsExist(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            News news = context.News.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(news);
            context.SaveChanges();
            
        }

        public void Update(News news)
        {
            context.Update(news);
            context.SaveChanges();
        }

        public void RecreateDatabase()
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
