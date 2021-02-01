using otomasyon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace otomasyon
{
    public class DataContext : DbContext
    {
        public DataContext() : base("sqlim")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}