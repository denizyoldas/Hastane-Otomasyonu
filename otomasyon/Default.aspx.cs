﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otomasyon
{
    public partial class _Default : Page
    {
        DataContext db = new DataContext();
        protected void Page_Load(object sender, EventArgs e) {
            var greenCount = db.Patients.Where(p => p.status == 1).Count();
            green.Text = greenCount.ToString();

            var warnCount = db.Patients.Where(p => p.status == 2).Count();
            warn.Text = warnCount.ToString();

            var dangerCount = db.Patients.Where(p => p.status == 3).Count();
            danger.Text = dangerCount.ToString();

            var allCount = db.Patients.Count();
            all.Text = allCount.ToString();

            //var patrients = db.Patients.ToList().Take(10);
                var patrients = (from p in db.Patients
                             join f in db.Fields
                             on p.field equals f.id
                             join s in db.Statuses
                             on p.status equals s.id
                             orderby p.createdDate descending
                             select new
                             {
                                 id = p.id,
                                 name = p.name,
                                 surname = p.surname,
                                 tcNo = p.tcNo,
                                 fieldName = f.name,
                                 statusName = s.name
                             }).ToList().Take(10);
            Repeater1.DataSource = patrients;
            Repeater1.DataBind();
            //green.Text = Session["user"].ToString();
        }
    }
}