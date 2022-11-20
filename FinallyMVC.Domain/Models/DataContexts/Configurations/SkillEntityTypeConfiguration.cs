using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class SkillEntityTypeConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.Property(s => s.Body)
               .IsRequired();

            builder.Property(s => s.job)
                .IsRequired();

            builder.Property(s => s.WorkPlace)
                .IsRequired();


        }
    }
}
