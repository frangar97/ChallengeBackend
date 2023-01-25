using Core.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .HasOne(x=>x.EmployeeType)
                .WithMany(x=>x.Employees)
                .HasForeignKey(e => e.EmployeeTypeId);
        }
    }
}
