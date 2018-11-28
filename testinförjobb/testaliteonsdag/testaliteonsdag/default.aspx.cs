using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using testaliteonsdag.Models;

namespace testaliteonsdag
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(var db = new MovieTracker())
            {
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


                var myQry = from b in db.Genres
                            select b;
                var myOut = "";

                foreach (var item in myQry)
                {
                    myOut += "<h3>" + item.GenreName + "</3>";
                }

                lblOut.Text = myOut;
            }
        }
    }
}