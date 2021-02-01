using otomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class Profile : System.Web.UI.Page
    {
        DataContext _db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                var user = _db.Users.Find(Session["user"]);
                nameSurname.Text = user.nameSurname;
                email.Text = user.email;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var user = _db.Users.Find(Session["user"]);

            user.nameSurname = nameSurname.Text;
            user.email = email.Text;

            if (oldPass.Text != null)
            {
                if (oldPass.Text == user.password)
                {
                    user.password = newPass.Text;
                    _db.SaveChanges();
                    basarili.Visible = true;
                    basarili.Text = "Güncelleme işlemi başarılı";
                } else
                {
                    hata.Visible = true;
                    hata.Text = "Eski şifre hatalı !!";
                }
            } else
            {
                _db.SaveChanges();
                basarili.Visible = true;
                basarili.Text = "Güncelleme işlemi başarılı";
            }
            
        }
    }
}