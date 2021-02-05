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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TcNoDogrula(tcNoText.Text))
            {
                Patient patient = new Patient();
                patient.name = nameText.Text;
                patient.surname = surnameText.Text;
                patient.tcNo = tcNoText.Text;
                patient.status = int.Parse(fieldDrop.SelectedItem.Value);
                patient.field = int.Parse(statusDrop.SelectedItem.Value);
                patient.createdDate = DateTime.Now;

                db.Patients.Add(patient);
                db.SaveChanges();

                Response.Redirect("hastalistesi.aspx");
            } else
            {
                lblAlert.Text = "Tc Numarası Doğrulanamadı!";
                lblAlert.Visible = true;
            }
        }

        public static bool TcNoDogrula(string tcKimlikNo)
        {
            bool returnvalue = false;
            if (tcKimlikNo.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tcKimlikNo);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }
            return returnvalue;
        }
    }
}