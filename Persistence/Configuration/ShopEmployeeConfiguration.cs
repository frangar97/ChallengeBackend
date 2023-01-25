using Core.ShopEmployee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ShopEmployeeConfiguration : IEntityTypeConfiguration<ShopEmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<ShopEmployeeEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .HasOne(e => e.Employee)
                .WithMany(e=>e.ShopEmployees)
                .HasForeignKey(e => e.EmployeeId);

            builder
                .HasOne(x=>x.Shop)
                .WithMany(x=>x.ShopEmployees)
                .HasForeignKey(x => x.ShopId);
        }
    }
}
