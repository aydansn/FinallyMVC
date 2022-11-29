using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Finallymvc.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallymvcUserLoginEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcUserLogin>
    {
        public void Configure(EntityTypeBuilder<FinallymvcUserLogin> builder)
        {
            builder.ToTable("UserLogins", "Membership");
        }
    }
}
