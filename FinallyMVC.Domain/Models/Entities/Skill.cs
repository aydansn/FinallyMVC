using FinallyMVC.Domain.AppCode.Infrastructure;
using FinallyMVC.Domain.Business.Enums;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Skill: BaseEntity
    {
        public string Body { get; set; }
        public string job { get; set; }
        public string WorkPlace { get; set; }

        public SkillType SkillType { get; set; }
    }
}
