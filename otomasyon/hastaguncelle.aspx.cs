using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class hastaguncelle : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int patientId = Convert.ToInt32(Request.QueryString["id"]);
                var patient = db.Patients.Where(p => p.id == patientId).FirstOrDefault();

                if (!IsPostBack)
                {
                    var feild = db.Fields.ToList();
                    var status = db.Statuses.ToList();

                    fieldDrop.DataSource = feild;
                    fieldDrop.DataTextField = "name";
                    fieldDrop.DataValueField = "id";
                    fieldDrop.DataBind();

                    statusDrop.DataSource = status;
                    statusDrop.DataTextField = "name";
                    statusDrop.DataValueField = "id";
                    statusDrop.DataBind();

                    nameText.Text = patient.name;
                    surnameText.Text = patient.surname;
                    tcNoText.Text = patient.tcNo.ToString();

                    fieldDrop.Items.FindByValue(patient.field.ToString()).Selected = true;
                    statusDrop.Items.FindByValue(patient.status.ToString()).Selected = true;
                }
            }
            else
            {
                Response.Redirect("hastalistesi.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(Request.QueryString["id"]);
            var patient = db.Patients.Where(p => p.id == patientId).FirstOrDefault();

            patient.name = nameText.Text;
            patient.surname = surnameText.Text;
            patient.tcNo = tcNoText.Text;
            patient.status = int.Parse(fieldDrop.SelectedItem.Value);
            patient.field = int.Parse(statusDrop.SelectedItem.Value);
            patient.createdDate = DateTime.Now;

            db.SaveChanges();

            Response.Redirect("hastalistesi.aspx");
        }
    }
}