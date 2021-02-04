using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace otomasyon.Models
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int tcNo { get; set; }
        public int field { get; set; }
        public int status { get; set; }
        public DateTime createdDate { get; set; }
    }
}