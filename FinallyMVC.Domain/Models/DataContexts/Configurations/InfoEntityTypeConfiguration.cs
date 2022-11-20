using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class InfoEntityTypeConfiguration : EntityTypeConfiguration<Info>
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
