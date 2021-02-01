using otomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class register : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(passwordverfy.Text) && !string.IsNullOrEmpty(username.Text))
            {
                if (password.Text == passwordverfy.Text)
                {
                    User usr = new User();
                    usr.nameSurname = username.Text;
                    usr.email = email.Text;
                    usr.password = password.Text;

                    db.Users.Add(usr);
                    db.SaveChanges();

                    hata.Text = "";
                    onay.Text = "Kayıt işlemi başarılı giriş sayfasına gitmek için tıklayınız.";
                }
                else
                {
                    hata.Text = "Şifreler aynı değil!";
                }
            }
            else
            {
                hata.Text = "Bütün alanları doldurmak zorundasınız!";
            }
        }
    }
}