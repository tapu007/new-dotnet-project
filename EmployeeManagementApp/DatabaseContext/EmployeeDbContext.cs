using EmployeeManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.DatabaseContext
{
    public class EmployeeDbContext:DbContext
    {

        public EmployeeDbContext()
        {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-L0SIFSL\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=true");
        }

        public DbSet<Employee> Employees { get; set; }
    }

}

