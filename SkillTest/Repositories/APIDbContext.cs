using SkillTest.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillTest.Repositories
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; } 
    }
}
