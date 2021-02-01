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
                    nameText.Text = patient.name;
                    surnameText.Text = patient.surname;
                    tcNoText.Text = patient.tcNo.ToString();
                    fieldBox.SelectedValue = patient.field.ToString();
                    statusBox.SelectedValue = patient.status.ToString();
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
            patient.tcNo = int.Parse(tcNoText.Text);
            patient.status = int.Parse(fieldBox.SelectedValue);
            patient.field = int.Parse(statusBox.SelectedValue);

            db.SaveChanges();

            Response.Redirect("hastalistesi.aspx");
        }
    }
}