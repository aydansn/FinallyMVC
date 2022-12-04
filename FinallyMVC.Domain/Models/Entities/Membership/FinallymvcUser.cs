using Microsoft.AspNetCore.Identity;

namespace FinallyMVC.Domain.Models.Entities.Membership
{
    public class FinallymvcUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ProfileImagePath { get; set; }
        public string CoverImagePath { get; set; }

    }
}
