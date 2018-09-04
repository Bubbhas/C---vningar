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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Välkommen till huvudmenyn!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("a) gå till huvudmenyn");
            Console.WriteLine("b) Uppdatera en blogpost");
            Console.WriteLine("c) Lägga till en tagg");
            Console.WriteLine("d) Visa alla bloggposts");
            Console.WriteLine("e) Visa alla tags");
            Console.WriteLine("f) Läs ett blogginlägg");
            Console.WriteLine("g) Skapa ett nytt blogginlägg");
            Console.WriteLine("h) Se alla kommentarer");
            Console.WriteLine("i) Skapa en kommentar");
            Console.WriteLine("j) Ändra en kommentar");
            Console.WriteLine("k) Se alla posts för en viss taggjävel");

            ConsoleKey commad = Console.ReadKey().Key;

            switch (commad)
            {
                case ConsoleKey.A: PageMainMenu(); break;
                case ConsoleKey.B: PageUpdatePost(); break;
                case ConsoleKey.C: UpdateTags(); break;
                case ConsoleKey.D: ShowAllBlogPost(); Console.ReadKey(); PageMainMenu(); break;
                case ConsoleKey.E: ShowAllTags(); Console.ReadKey(); PageMainMenu(); break;
                case ConsoleKey.F: ReadAPost(); break;
                case ConsoleKey.G: CreateNewPost(); break;
                case ConsoleKey.H: ShowAllComments(); Console.ReadKey(); PageMainMenu(); break;
                case ConsoleKey.I: CreatNewComment(); break;
                case ConsoleKey.J: UpdateComment(); break;
                //case ConsoleKey.K: SeAllPostsInTag(); break;
                default: Console.Clear(); Console.WriteLine("SKRIV RÄTT!!!!"); Console.ReadKey(); PageMainMenu();  break;
            }
        }

        //private void SeAllPostsInTag()
        //{
        //    ShowAllTags();
        //    Console.WriteLine("Vilken tag väljer du?(Id)");
        //    int tagId = int.Parse(Console.ReadLine());
        //    Comment c = dataacccess.GetTagId(tagId);

        //}

        private void UpdateComment()
        {
            Console.Clear();
            ShowAllComments();
            Console.WriteLine("Vilken kommentar vill du uppdatera?");
            int commentId = int.Parse(Console.ReadLine());

            Comment c = dataacccess.GetCommentById(commentId);
            Console.WriteLine(c.Title + ",   " + c.Text);
            Console.WriteLine("Vad vill du ändra på? (A)Title? (B)Text?");
            if(Console.ReadLine() == "A")
            {
                string newTitle = Console.ReadLine();

                c.Title = newTitle;
                dataacccess.UpdateComment(c);
            }
            else if (Console.ReadLine() == "B")
            {
                string newText = Console.ReadLine();

                c.Text = newText;
                dataacccess.UpdateComment(c);
            }
            else
                Console.WriteLine("Skit I DET DÅ! ÄNDRA INGET!!");

            Console.WriteLine("Kommentaren är uppdaterad. Tryck på valfri knapp för att gå till huvudmenyn.");
            Console.ReadKey();
            PageMainMenu();
        }

        private void CreatNewComment()
        {
            Console.Clear();
            ShowAllBlogPost();
            Console.WriteLine("Vilken bloggpost vill du uppdatera?");
            int postid = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv titeln till kommentaren");
            string newTitle = Console.ReadLine();
            Console.WriteLine("Skriv din kommentar");
            string newText = Console.ReadLine();
            dataacccess.CreateComment(newTitle, newText, postid);
            Console.WriteLine("Kommentaren är skapad. Tryck på valfri knapp för att gå till huvudmenyn.");
            Console.ReadKey();
            PageMainMenu();
        }

        private void ShowAllComments()
        {
            Console.Clear();
            List<Comment> allComments = dataacccess.GetAllComments();
            Console.WriteLine("ID".PadRight(5) + "TITEL".PadRight(30));
            Console.WriteLine();
            foreach (Comment comment in allComments)
            {
                Console.Write(comment.Id.ToString().PadRight(5) + comment.Title.PadRight(30));
                Console.WriteLine("Kommentar: " + comment.Text + "." + "BlogPost: ".PadLeft(30) + comment.PostTitle);
            }
        }

        private void CreateNewPost()
        {
            Console.Clear();
            Console.WriteLine("Skriv titeln till posten");
            string newTitle = Console.ReadLine();
            Console.WriteLine("Skriv ditt namn");
            string newAuthor = Console.ReadLine();
            Console.WriteLine("Titel = " + newTitle);
            Console.WriteLine("Skriv ditt inlägg");
            string newText = Console.ReadLine();
            dataacccess.CreatePost(newTitle, newAuthor, newText);
            Console.WriteLine("Bloggposten är uppdaterad. Tryck på valfri knapp för att gå till huvudmenyn.");
            Console.ReadKey();
            PageMainMenu();
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
        public void ReadAPost()
        {
            Console.Clear();

            ShowAllBlogPost();

            Console.WriteLine("Vilken post vill du läsa?");
            int postid = int.Parse(Console.ReadLine());

            BlogPost post = dataacccess.GetBlogPostById(postid);

            Console.Clear();
            Console.WriteLine("------------" + post.Title + "------------");
            Console.WriteLine(post.BlogText);
            Console.ReadKey();
            PageMainMenu();
        }

        private void ShowAllBlogPost()
        {
            Console.Clear();
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
        }
    }
}
