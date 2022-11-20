using FinallyMVC.Domain.Business.SkillModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.SkillValidator
{
    public class SkillCreateCommandValidator : AbstractValidator<SkillCreateCommand>
    {
        public SkillCreateCommandValidator()
        {
            RuleFor(m => m.Body)
                .NotEmpty()
                .WithMessage("Marka adi qeyd edilmeyib");
        }
    }
}
