using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Finallymvc.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallymvcRoleClaimEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcRoleClaim>
    {
        public void Configure(EntityTypeBuilder<FinallymvcRoleClaim> builder)
        {
            builder.ToTable("RoleClaims", "Membership");
        }
    }
}
