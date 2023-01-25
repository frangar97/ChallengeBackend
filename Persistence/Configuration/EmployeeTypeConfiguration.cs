using Core.EmployeeType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    internal class EmployeeTypeConfiguration : IEntityTypeConfiguration<EmployeeTypeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeTypeEntity> builder)
        {
           builder.HasKey(e=>e.Id);
        }
    }
}
