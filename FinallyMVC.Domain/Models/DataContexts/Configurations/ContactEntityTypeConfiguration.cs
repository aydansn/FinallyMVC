using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class ContactEntityTypeConfiguration : EntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(c => c.Body)
               .IsRequired();

            builder.Property(c => c.Phone)
                .IsRequired();

            builder.Property(c => c.Title)
                .IsRequired();

            builder.Property(c => c.ImageURL)
                .IsRequired();


        }
    }
}
