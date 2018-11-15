using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Models
{
    public class DataContext : DbContext
    {
        //string a = ConfigurationManager.ConnectionStrings["Models.Properties.Settings.Settings"].ToString();
        public DataContext() : base(@"Data Source=DESKTOP-G95ITR8\SQLEXPRESS;Initial Catalog=CAS_Base;Integrated Security=True") { }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema(string.Empty);
        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

    }
}
