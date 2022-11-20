using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(b => b.Body)
               .IsRequired();

            builder.Property(b => b.Title)
                .IsRequired();

            builder.Property(b => b.ImageURL)
                .IsRequired();

            builder.Property(b => b.PublishDate)
                .IsRequired();


        }
    }
}
