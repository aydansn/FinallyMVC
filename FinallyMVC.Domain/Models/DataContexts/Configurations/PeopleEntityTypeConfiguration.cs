using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class PeopleEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(t => t.Name)
               .IsRequired();

            builder.Property(t => t.Age)
                .IsRequired();

            builder.HasIndex(t => t.Location)
                .IsUnique();

            builder.Property(t => t.Experience)
                .IsRequired();

            builder.Property(t => t.Degree)
                .IsRequired();
            builder.Property(t => t.Careerlevel)
                .IsRequired();
            builder.Property(t => t.Phone)
                .IsRequired();
            builder.Property(t => t.Fax)
                .IsRequired();

            builder.Property(t => t.EMail)
               .IsRequired();

            builder.Property(t => t.WebSite)
               .IsRequired();

        }
    }
}
