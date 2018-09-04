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
                        Join TagToPost ON BlogPost.Id = TagToPost.PostId
                        Join Tag ON TagToPost.TagId = Tag.Id
                        Order By BlogPost.Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                var result = new List<BlogPost>();

                SqlDataReader reader = command.ExecuteReader();

                int lastId = -1;
                var bp = new BlogPost();

                while (reader.Read())
                {
                    int id = reader.GetSqlInt32(0).Value;

                    if (id==lastId)
                    {
                        string taga = reader.GetSqlString(3).Value;
                        bp.Tags.Add(taga);
                    }
                    else
                    {
                        string author = reader.GetSqlString(1).Value;
                        string title = reader.GetSqlString(2).Value;
                        string tag = reader.GetSqlString(3).Value;

                        bp = new BlogPost();
                        bp.Id = id;
                        bp.Title = title;
                        bp.Author = author;
                        bp.Tags.Add(tag);
                        result.Add(bp);
                    }
                    lastId = id;
                }
                return result;
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

            string sql = @"select Id,Title,Author 
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

                bp.Id = id;
                bp.Title = title;
                bp.Author = author;

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
