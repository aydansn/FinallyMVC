using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Finallymvc.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallymvcUserRoleEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcUserRole>
    {
        public void Configure(EntityTypeBuilder<FinallymvcUserRole> builder)
        {
            builder.ToTable("UserRoles", "Membership");
        }
    }
}
