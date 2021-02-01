using otomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class hastakayit : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.name = nameText.Text;
            patient.surname = surnameText.Text;
            patient.tcNo = int.Parse(tcNoText.Text);
            patient.status = int.Parse(fieldBox.SelectedValue);
            patient.field = int.Parse(statusBox.SelectedValue);

            db.Patients.Add(patient);
            db.SaveChanges();

            Response.Redirect("hastalistesi.aspx");
        }
    }
}