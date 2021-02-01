using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class hastasil : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int patientId = Convert.ToInt32(Request.QueryString["id"]);
                var patient = db.Patients.Where(p => p.id == patientId).FirstOrDefault();
                db.Patients.Remove(patient);
                db.SaveChanges();

                Response.Redirect("hastalistesi.aspx");
            }else
            {
                Response.Redirect("hastalistesi.aspx");
            }
        }
    }
}