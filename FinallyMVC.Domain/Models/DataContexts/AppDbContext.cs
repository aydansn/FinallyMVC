using FinallyMVC.Domain.Models.Entities;
using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinallyMVC.Domain.Models.DataContexts
{
    public class AppDbContext : IdentityDbContext<FinallymvcUser, FinallymvcRole,int,FinallymvcUserClaim, FinallymvcUserRole, FinallymvcUserLogin, FinallymvcRoleClaim, FinallymvcUserToken   >//DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Service> Serviceses { get; set; }
        public DbSet<Skill> Skills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }

}
