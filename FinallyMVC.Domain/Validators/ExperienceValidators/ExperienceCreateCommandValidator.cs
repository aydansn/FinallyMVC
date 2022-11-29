using FinallyMVC.Domain.Business.ExperienceModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.ExperienceValidators
{
    public class ExperienceCreateCommandValidator : AbstractValidator<ExperienceCreateCommand>
    {
        public ExperienceCreateCommandValidator()
        {
            RuleFor(b => b.Body)
               .NotEmpty()
               .WithMessage("Text bosh buraxila bilmez");

            RuleFor(b => b.Profession)
                .NotNull()
                .WithMessage("Sahe secilmeyib")
                .MaximumLength(250)
                .WithMessage("250 simvoldan cox ola bilmez");

            RuleFor(b => b.Date)
                .NotNull()
                .WithMessage("Tarix secilmeyib");

            RuleFor(b => b.Place)
                .NotNull()
                .WithMessage("Mekan secilmeyib");

        }
    }
}
