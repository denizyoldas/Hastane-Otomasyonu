using otomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class alanlistesi : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        static int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"].ToString() != "admin")
                Response.Redirect("Default.aspx");

            FieldList();

            if (Request.QueryString["id"] != null && id != Convert.ToInt32(Request.QueryString["id"]))
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                var field = db.Fields.Find(id);
                nameText.Text = field.name;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (nameText.Text != null)
            {
                if (id != 0)
                {
                    var field = db.Fields.Where(s => s.id == id).FirstOrDefault();
                    field.name = nameText.Text.ToString();
                    db.SaveChanges();
                }
                else
                {
                    Field field = new Field() { name = nameText.Text };
                    db.Fields.Add(field);
                    db.SaveChanges();
                }

                FieldList();
            }
        }

        public void FieldList()
        {
            var field = db.Fields.ToList();
            Repeater1.DataSource = field;
            Repeater1.DataBind();
        }
    }
}