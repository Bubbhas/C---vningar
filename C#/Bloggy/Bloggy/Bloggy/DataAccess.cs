using Bloggy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bloggy
{
    public class DataAccess
    {
        string conString = @"Server=(localdb)\mssqllocaldb;Database=Bloggy";

        internal List<BlogPost> GetAllBlogPost()
        {
            string sql = @"SELECT BlogPost.Id, BlogPost.Author, BlogPost.Title, Tag.Name 
                        From BlogPost
                        Left Join TagToPost ON BlogPost.Id = TagToPost.PostId
                        Left Join Tag ON TagToPost.TagId = Tag.Id
                        Order By BlogPost.Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var dic = new Dictionary<int, BlogPost>();
                while (reader.Read())
                {
                    int id = reader.GetSqlInt32(0).Value;

                    // Om bloggposten redan finns i listan "result" => peta bara in taggen 

                    // ...annars skapa ny bloggpost

                    if (!dic.ContainsKey(id))
                    {
                        string author = reader.GetSqlString(1).Value;
                        string title = reader.GetSqlString(2).Value;
                    
                        var bp = new BlogPost();
                        bp.Id = id;
                        bp.Title = title;
                        bp.Author = author;
                      
                        dic.Add(id, bp);
                    }
                   if (!reader.GetSqlString(3).IsNull)
                    {
                        dic[id].Tags.Add(reader.GetSqlString(3).Value);
                    }
                }
                return dic.Select(x => x.Value).ToList();
            }
        }

        internal List<Comment> GetAllComments()
        {
            string sql = @"SELECT Comment.Id, Comment.Title, Comment.Text, BlogPost.Id, BlogPost.Title
                            From Comment
                            Join BlogPost On Comment.BlogPost = BlogPost.Id";

            var result = new List<Comment>();

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetSqlInt32(0).Value;
                    string title = reader.GetSqlString(1).Value;
                    string text = reader.GetSqlString(2).Value;
                    int blogId = reader.GetSqlInt32(3).Value;
                    string blogTitle = reader.GetSqlString(4).Value;

                    var c = new Comment();

                    c.Id = id;
                    c.Title = title;
                    c.Text = text;
                    c.PostId = blogId;
                    c.PostTitle = blogTitle;

                    result.Add(c);
                }
            }
            return result;

            }

        internal void UpdateComment(Comment c)
        {
            string sql = @"update Comment 
            set Title = @Title, Text = @Text
            where id = @id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("Id", c.Id));
                command.Parameters.Add(new SqlParameter("Title", c.Title));
                command.Parameters.Add(new SqlParameter("Text", c.Text));
                command.ExecuteNonQuery();
            }
        }

        internal Comment GetCommentById(int commentId)
        {
            string sql = @"Select Comment.Id, Comment.Title, Comment.Text, Comment.BlogPost
            from Comment
            where Id=@Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("Id", commentId));

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                var c = new Comment();

                int id = reader.GetSqlInt32(0).Value;
                string title = reader.GetSqlString(1).Value;
                string text = reader.GetSqlString(2).Value;
                int postId = reader.GetSqlInt32(3).Value;

                c.Id = id;
                c.Title = title;
                c.Text = text;
                c.PostId = postId;

                return c;
            }
        }

        internal void CreateComment(string newTitle, string newText, int blogPost)
        {
            string sql = @"Insert Into Comment(Title, Text, BlogPost)
                            Values(@Title, @Text, @BlogPost)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@Title", newTitle));
                command.Parameters.Add(new SqlParameter("@Text", newText));
                command.Parameters.Add(new SqlParameter("@BlogPost", blogPost));
                command.ExecuteNonQuery();
            }

        }

        internal void CreatePost(string newTitle, string newAuthor, string newText)
        {
            string sql = @"Insert Into BlogPost(Title, Author, BlogText)
                            Values(@Title, @Author, @BlogText)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@Title", newTitle));
                command.Parameters.Add(new SqlParameter("@Author", newAuthor));
                command.Parameters.Add(new SqlParameter("@BlogText", newText));
                command.ExecuteNonQuery();
            }
        }

        internal void MatchTagsToPost(int tagId, BlogPost post)
        {
            string sql = @"INSERT INTO TagToPost(TagId, PostId)
                Values(@TagId, @PostId)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("TagId", tagId));
                command.Parameters.Add(new SqlParameter("PostId", post.Id));
                command.ExecuteNonQuery();
            }
        }

        internal int UpdateTags(string tag)
        {
            string sql = @"INSERT INTO Tag(Name)
                output Inserted.id
                Values(@Name)";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("@Name", tag));
                return (int)command.ExecuteScalar();
            }

        }

        public BlogPost GetBlogPostById(int postid)
        {

            string sql = @"select Id,Title,Author, BlogText 
            from BlogPost
            where ID=@Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("Id", postid));

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                var bp = new BlogPost();

                int id = reader.GetSqlInt32(0).Value;
                string title = reader.GetSqlString(1).Value;
                string author = reader.GetSqlString(2).Value;
                string text = reader.GetSqlString(3).Value;

                bp.Id = id;
                bp.Title = title;
                bp.Author = author;
                bp.BlogText = text;

                return bp;
            }
        }



        internal IDictionary<int, string> GetAllTags()
        {
            string sql = @"SELECT Id, Name From Tag";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                //var result = new List<string>();
                IDictionary<int, string> dict = new Dictionary<int, string>();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetSqlInt32(0).Value;
                    string tagName = reader.GetSqlString(1).Value;
                    dict.Add(id, tagName);
                    //result.Add(tagName);
                }
                return dict;
            }
        }

        internal void UpdateBlogPost(BlogPost post)
        {

            string sql = @"update BlogPost 
            set Title = @Title where id = @id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("Id", post.Id));
                command.Parameters.Add(new SqlParameter("Title", post.Title));
                command.ExecuteNonQuery();
            }
        }
    }
}
