using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class SiteMaster : MasterPage
    {
        DataContext _db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            var user = _db.Users.Find(Session["user"]);
            Label1.Text = user.nameSurname;
            bool vsb = Session["userRole"].ToString() == "admin";
            visible.Visible = vsb;
            visible2.Visible = vsb;
            visible3.Visible = vsb;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}