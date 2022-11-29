using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Finallymvc.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallymvcUserTokenEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcUserToken>
    {
        public void Configure(EntityTypeBuilder<FinallymvcUserToken> builder)
        {
            builder.ToTable("UserTokens", "Membership");
        }
    }
}
