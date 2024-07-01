using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployee.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Employee>? Employees { get; set; }
    } 
    
}
