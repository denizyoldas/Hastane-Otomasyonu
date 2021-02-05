using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class kullaniciguncelle : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        static int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                if (!IsPostBack)
                {
                    var user = db.Users.Find(Convert.ToInt32(Request.QueryString["id"]));
                    nameSurnameText.Text = user.nameSurname;
                    emailText.Text = user.email;
                    roleDrpDwn.Items.FindByValue(user.role.ToString()).Selected = true;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var user = db.Users.Find(Convert.ToInt32(Request.QueryString["id"]));
            user.nameSurname = nameSurnameText.Text;
            user.email = emailText.Text;
            user.role = roleDrpDwn.SelectedItem.Value;

            db.SaveChanges();

            Response.Redirect("kullanicilistesi.aspx");
        }
    }
}