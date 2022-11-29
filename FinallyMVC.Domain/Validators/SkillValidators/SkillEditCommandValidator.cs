using FinallyMVC.Domain.Business.SkillModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.SkillValidators
{
    public class SkillEditCommandValidator : AbstractValidator<SkillEditCommand>
    {
        public SkillEditCommandValidator()
        {
            RuleFor(m => m.Id)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Id minimum 1 ola biler");
            RuleFor(m => m.Body)
                           .NotEmpty()
                           .WithMessage("Text adi qeyd edilmeyib");

            RuleFor(m => m.job)
                .NotNull()
                .WithMessage("Is adi secilmeyib")
                .NotEmpty()
                .WithMessage("Isin adi qeyd edilmeyib");

            RuleFor(m => m.WorkPlace)
                .NotNull()
                .WithMessage("Is yeri secilmeyib")
                .NotEmpty()
                .WithMessage("Is yeri adi qeyd edilmeyib");
        }
    }
}
