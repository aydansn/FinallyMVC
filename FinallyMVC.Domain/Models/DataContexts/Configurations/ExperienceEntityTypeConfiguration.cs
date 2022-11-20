using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public  class ExperienceEntityTypeConfiguration : EntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.Property(e => e.ImageURL)
               .IsRequired();

        }
    }
}
