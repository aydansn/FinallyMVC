using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class BackgroundEntityTypeConfiguration : IEntityTypeConfiguration<Background>
    {
        public void Configure(EntityTypeBuilder<Background> builder)
        {
            builder.Property(b => b.Body)
               .IsRequired();

            builder.Property(b => b.Date)
                .IsRequired();

            builder.Property(b => b.Place)
                .IsRequired();

            builder.Property(b => b.Profession)
                .IsRequired();

          
        }
    }
}
