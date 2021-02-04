using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userRole"].ToString() != "admin")
                Response.Redirect("Default.aspx");
            var user = db.Users.ToList();
            Repeater1.DataSource = user;
            Repeater1.DataBind();
            //visible.Visible = Session["userRole"].ToString() == "admin";
        }
    }
}