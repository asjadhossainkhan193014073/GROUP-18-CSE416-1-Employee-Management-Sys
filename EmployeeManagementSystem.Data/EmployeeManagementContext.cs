using System.Data.Entity;

namespace EmployeeManagementSystem.Data
{

    public class EmployeeManagementContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}