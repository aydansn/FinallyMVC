using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Finallymvc.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallymvcRoleEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcRole>
    {
        public void Configure(EntityTypeBuilder<FinallymvcRole> builder)
        {
            builder.ToTable("Roles","Membership");
        }
    }
}
