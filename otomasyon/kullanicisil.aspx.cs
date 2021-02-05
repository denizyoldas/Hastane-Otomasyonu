using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class kullanicisil : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["id"] != null) {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
            }
            Response.Redirect("kullanicilistesi.aspx");
        }
    }
}