using DB.Core.Migrations;
using DB.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Core
{
    public class TelerikContext : DbContext
    {
        public TelerikContext()
            : base("name=TelerikDB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TelerikContext>());
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Town> Towns { get; set; }
    }
}
