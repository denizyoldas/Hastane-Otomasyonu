using otomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class durumlistesi : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"].ToString() != "admin")
                Response.Redirect("Default.aspx");
            FieldList();

            if (Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                var status = db.Statuses.Find(id);
                nameText.Text = status.name;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (nameText.Text != null)
            {
                if (id != 0)
                {
                    var status = db.Statuses.Where(s => s.id == id).FirstOrDefault();
                    status.name = nameText.Text;
                    db.SaveChanges();
                }
                else
                {
                    Status status = new Status() { name = nameText.Text };
                    db.Statuses.Add(status);
                    db.SaveChanges();
                }

                FieldList();
            }
        }

        public void FieldList()
        {
            var status = db.Statuses.ToList();
            Repeater1.DataSource = status;
            Repeater1.DataBind();
        }
    }
}