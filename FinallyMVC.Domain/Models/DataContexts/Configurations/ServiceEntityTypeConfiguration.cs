using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class ServiceEntityTypeConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(s => s.Body)
               .IsRequired();

            builder.Property(s => s.ImageURL)
                .IsRequired();

            builder.Property(s => s.Title)
                .IsRequired();
        }
    }
}
