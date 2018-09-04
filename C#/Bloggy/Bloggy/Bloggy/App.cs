using Bloggy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggy
{
    public class App
    {
        DataAccess dataacccess = new DataAccess();

        public void Run()
        {

            PageMainMenu();
        }

        private void PageMainMenu()
        {
            Console.WriteLine("Välkommen till huvudmenyn!");

            ShowAllBlogPost();

            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("a) gå till huvudmenyn");
            Console.WriteLine("b) Uppdatera en blogpost");
            Console.WriteLine("c) Lägga till en tagg");

            ConsoleKey commad = Console.ReadKey().Key;

            switch (commad)
            {
                case ConsoleKey.A: PageMainMenu(); break;
                case ConsoleKey.B: PageUpdatePost(); break;
                case ConsoleKey.C: UpdateTags(); break;
            }
        }
        private void UpdateTags()
        {
            Console.Clear();

            Console.WriteLine("Skriv in taggen du vill lägga till?");

            string newTag = Console.ReadLine();
            int tagId = dataacccess.UpdateTags(newTag);

            ShowAllBlogPost();
            Console.WriteLine("Vilken bloggpost vill du uppdatera?");
            int postid = int.Parse(Console.ReadLine());
            BlogPost post = dataacccess.GetBlogPostById(postid);

            dataacccess.MatchTagsToPost(tagId, post);

            Console.WriteLine("Bloggposten är uppdaterad. Tryck på valfri knapp för att gå till huvudmenyn.");
            Console.ReadKey();
            PageMainMenu();
        }
        private void PageUpdatePost()
        {
            Console.Clear();

            ShowAllBlogPost();

            Console.WriteLine("Vilken bloggpost vill du uppdatera?");
            int postid = int.Parse(Console.ReadLine());

            BlogPost post = dataacccess.GetBlogPostById(postid);

            Console.WriteLine("Skriv in ny titel: ");

            string newTitle = Console.ReadLine();

            post.Title = newTitle;

            dataacccess.UpdateBlogPost(post);

            Console.WriteLine("Bloggposten är uppdaterad. Tryck på valfri knapp för att gå till huvudmenyn.");
            Console.ReadKey();
            PageMainMenu();
        }

        private void ShowAllBlogPost()
        {

            List<BlogPost> allPost = dataacccess.GetAllBlogPost();
            Console.WriteLine("ID".PadRight(5) + "TITEL".PadRight(30) + "AUTHOR".PadRight(30) + "TAGS");
            Console.WriteLine();
            foreach (BlogPost bp in allPost)
            {
                Console.Write(bp.Id.ToString().PadRight(5) + bp.Title.PadRight(30) + bp.Author.PadRight(30));
                Console.WriteLine(string.Join(",", bp.Tags));
            }
        }
    }
}
