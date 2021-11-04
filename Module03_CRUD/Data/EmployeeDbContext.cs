using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Module03_CRUD.Models;

namespace Module03_CRUD.Data
{
    public class EmployeeDbContext : IdentityDbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }
        public DbSet<Module03_CRUD.Models.Company> Company { get; set; }
        public DbSet<Module03_CRUD.Models.Employee> Employee { get; set; }
        
    }
}
