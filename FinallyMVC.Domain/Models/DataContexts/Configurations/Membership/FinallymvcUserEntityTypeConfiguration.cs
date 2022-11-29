using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finallymvc.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallymvcUserEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcUser>
    {
        public void Configure(EntityTypeBuilder<FinallymvcUser> builder)
        {
            builder.ToTable("Users", "Membership");
        }
    }
}
