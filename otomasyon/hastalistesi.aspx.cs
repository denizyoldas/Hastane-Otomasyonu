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
            var patrients = (from p in db.Patients
                              join f in db.Fields
                              on p.field equals f.id
                              join s in db.Statuses
                              on p.status equals s.id
                              select new {
                                  id = p.id,
                                  name = p.name,
                                  surname = p.surname,
                                  tcNo = p.tcNo,
                                  fieldName = f.name,
                                  statusName = s.name
                              }).ToList();
            //var patrients = db.Patients.ToList();
            Repeater1.DataSource = patrients;
            Repeater1.DataBind();
        }
    }
}