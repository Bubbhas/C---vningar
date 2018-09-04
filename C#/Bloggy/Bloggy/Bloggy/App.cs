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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Välkommen till huvudmenyn!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("a) gå till huvudmenyn");
            Console.WriteLine("b) Uppdatera en blogpost");
            Console.WriteLine("c) Lägga till en tagg");
            Console.WriteLine("d) Visa alla bloggposts");
            Console.WriteLine("e) Visa alla tags");

            ConsoleKey commad = Console.ReadKey().Key;

            switch (commad)
            {
                case ConsoleKey.A: PageMainMenu(); break;
                case ConsoleKey.B: PageUpdatePost(); break;
                case ConsoleKey.C: UpdateTags(); break;
                case ConsoleKey.D: ShowAllBlogPost(); break;
                case ConsoleKey.E: ShowAllTags(); break;

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
        private void ShowAllTags()
        {
            Console.Clear();
            IDictionary<int, string> allTags = dataacccess.GetAllTags();
            Console.WriteLine("TAGS");
            Console.WriteLine();
            foreach (KeyValuePair<int, string> tags in allTags)
            {
                Console.WriteLine("ID: {0}, Tagg: {1}", tags.Key, tags.Value);
            }
            //Console.WriteLine("Visa alla blogginlägg för denna tagg");
            //List<BlogPost> allPost = dataacccess.GetAllBlogPostToThisTag();

        }
    }
}
