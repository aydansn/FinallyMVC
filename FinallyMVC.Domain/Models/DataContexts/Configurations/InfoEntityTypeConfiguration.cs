using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class InfoEntityTypeConfiguration : IEntityTypeConfiguration<Info>
    {
        public void Configure(EntityTypeBuilder<Info> builder)
        {
            builder.Property(i => i.Body)
               .IsRequired();

            builder.Property(i => i.ImageURL)
                .IsRequired();

            builder.Property(i => i.Phone)
                .IsRequired();

        }
    }
}
