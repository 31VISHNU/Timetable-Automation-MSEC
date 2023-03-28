using Microsoft.EntityFrameworkCore;
using TTGenerator.Models.Domain;
using TTGenerator.Models;
using TTGenerator.Models.Domain;

namespace TTGenerator.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Login_credentials> Login_credentials { get; set; }
        public DbSet<CollegeCoordinator> CollegeCoordinator { get; set; }
        public DbSet<Faculty_details> Faculty_details { get;set; }
    }
}
