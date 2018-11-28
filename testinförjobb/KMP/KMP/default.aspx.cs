using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KMP.Models;

namespace KMP
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db= new Newsmaker())
            {
                var myCat = new Category { catName = "Sports", catOrder = 2, catQuery = "sports" };
                db.Categories.Add(myCat);
                // db.SaveChanges();

                var myQry = from b in db.Categories
                            orderby b.catOrder
                            select b;
                var myOut = "";

                foreach (var item in myQry)
                {
                    myOut += "<h3>" + item.catName + "</3>";
                }

                lblOut.Text = myOut;
            }
        }
    }
}