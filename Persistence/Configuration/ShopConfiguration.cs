using Core.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ShopConfiguration : IEntityTypeConfiguration<ShopEntity>
    {
        public void Configure(EntityTypeBuilder<ShopEntity> builder)
        {
           builder.HasKey(e => e.Id);
        }
    }
}
