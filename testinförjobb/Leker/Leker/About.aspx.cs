using Leker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Leker
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new MovieTracker())
            {
                var myQry = from b in db.Genres
                            select b;
                var myOut = "";

                lblOut.Text = myOut;


                var myQryMovie = from a in db.Movies
                                 select a;
                var myOutMovie = "";

                lblOutMovie.Text = myOutMovie;



                foreach (var item in myQryMovie)
                {
                    myOutMovie += "<h3>" + item.MovieName + "</3>";
                }

                //var myGen = new Genre
                //{
                //    GenreName = "Drama"
                //};
                //var myGen2 = new Genre
                //{
                //    GenreName = "Comedy"
                //};
                //var myGen3 = new Genre
                //{
                //    GenreName = "Thriller"
                //};

                //db.Genres.Add(myGen);
                //db.Genres.Add(myGen2);
                //db.Genres.Add(myGen3);
                //db.SaveChanges();


            }
        }
    }
}