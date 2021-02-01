using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class login : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.Cookies["name"] != null && Request.Cookies["pass"] != null)
                {
                    email.Text = Request.Cookies["name"].Value;
                    password.Text = Request.Cookies["pass"].Value;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(password.Text))
            {
                var user = db.Users.Where(u => u.email == email.Text && u.password == password.Text).FirstOrDefault();

                if (user != null)
                {
                    Session.Add("user", user.id);
                    if (remember.Checked)
                    {
                        Response.Cookies["name"].Value = user.email;
                        Response.Cookies["pass"].Value = user.password;
                        Response.Cookies["name"].Expires = DateTime.Now.AddDays(15);
                        Response.Cookies["pass"].Expires = DateTime.Now.AddDays(15);
                    } else
                    {
                        Response.Cookies["name"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["pass"].Expires = DateTime.Now.AddDays(-1);
                    }
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    hata.Text = "Email Veya Şifre hatalı!!";
                }
            }
            else
            {
                hata.Text = "Email Veya Şifre boş geçilemez!!";
            }
        }
    }
}