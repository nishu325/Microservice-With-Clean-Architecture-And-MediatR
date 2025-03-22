using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;

namespace MyApp.Infracture.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<EmployeeEntity> Employee { get; set; }
    }
}
