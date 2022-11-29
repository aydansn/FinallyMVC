using FinallyMVC.Domain.Business.ExperienceModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.ExperienceValidators
{
    public class ExperienceEditCommandValidator : AbstractValidator<ExperienceEditCommand>
    {
        public ExperienceEditCommandValidator()
        {
            RuleFor(m => m.Id)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Id minimum 1 ola biler");

            RuleFor(b => b.ImageURL)

                .NotNull()
                .WithMessage("Sekil secilmeyib");

        }
    }
}
