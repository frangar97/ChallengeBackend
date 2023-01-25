using Core.Employee;
using Core.EmployeeType;
using Core.Shop;
using Core.ShopEmployee;
using Microsoft.EntityFrameworkCore;
using Persistence.Configuration;

namespace Persistence
{
    public class ChallengeContext:DbContext
    {
        public ChallengeContext(DbContextOptions<ChallengeContext> options):base(options) { }
        
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<EmployeeTypeEntity> EmployeeType { get; set; }
        public DbSet<ShopEntity> Shop { get; set; }
        public DbSet<ShopEmployeeEntity> ShopEmployee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ShopConfiguration());
            modelBuilder.ApplyConfiguration(new ShopEmployeeConfiguration());
        }
    }
}
