using Microsoft.EntityFrameworkCore;
using OutsysCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_ORM
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(" Data Source=(local); Initial Catalog=OutsysCompany; Integrated Security=true; TrustServerCertificate=True ");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DeptLocation> DeptLocations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<WorksOn> WorksOn { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
    }
}
