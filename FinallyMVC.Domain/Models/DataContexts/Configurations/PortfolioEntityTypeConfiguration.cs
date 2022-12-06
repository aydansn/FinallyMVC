using FinallyMVC.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations
{
    public class PortfolioEntityTypeConfiguration : IEntityTypeConfiguration<Portfolio>
    {
        public void Configure(EntityTypeBuilder<Portfolio> builder)
        {
            builder.Property(b => b.Name)
               .IsRequired();

            builder.Property(b => b.Link)
                .IsRequired();

            builder.Property(b => b.ImageURL)
                .IsRequired();
        }
    }
}
