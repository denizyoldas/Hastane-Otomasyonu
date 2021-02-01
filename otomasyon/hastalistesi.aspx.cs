using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class hastalistesi : System.Web.UI.Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var patrients = db.Patients.ToList();
            Repeater1.DataSource = patrients;
            Repeater1.DataBind();
        }
    }
}