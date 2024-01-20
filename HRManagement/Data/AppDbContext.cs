using Microsoft.EntityFrameworkCore;
using HRManagement.Models;
using System.Collections.Generic;

namespace HRManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department_Tbl { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hr_management.db");
        }

        public DbSet<HRManagement.Models.Employee> Employee { get; set; } = default!;
    }
}
