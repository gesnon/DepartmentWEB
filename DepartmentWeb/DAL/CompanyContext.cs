using DepartmentWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DepartmentWeb.DAL
{
    public class CompanyContext: DbContext

    {
        public CompanyContext() : base ("CompanyContext")
        {
            Database.SetInitializer<CompanyContext>(new DropCreateDatabaseIfModelChanges<CompanyContext>());
        }

        public DbSet<Department> Departments { get; set; }  // каждая строка - это таблица в базе

        public DbSet<Employee> Employees { get; set; } 

        public DbSet<Position> Positions { get; set; }
                 
    }
}