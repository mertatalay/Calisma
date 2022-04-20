using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class NTierSolidContext:DbContext
    {
        public NTierSolidContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-S4L9HBA\\SQLEXPRESS;Database=NTierSolid;Trusted_Connection=True;";
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
