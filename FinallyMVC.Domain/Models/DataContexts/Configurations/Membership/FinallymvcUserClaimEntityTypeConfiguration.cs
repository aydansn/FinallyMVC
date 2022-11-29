using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Finallymvc.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallymvcUserClaimEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcUserClaim>
    {
        public void Configure(EntityTypeBuilder<FinallymvcUserClaim> builder)
        {
            builder.ToTable("UserClaims", "Membership");
        }
    }
}
