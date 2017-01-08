using System.Data.Entity;
using Data.Models;

namespace Data.Context
{
    public class HrmContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}