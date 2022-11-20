using FinallyMVC.Domain.Business.ExperienceModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.ExperienceValidator
{
    public class ExperienceCreateCommandValidator : AbstractValidator<ExperienceCreateCommand>
    {
        public ExperienceCreateCommandValidator()
        {
            RuleFor(m => m.ImageURL)
                .NotEmpty()
                .WithMessage("Marka adi qeyd edilmeyib");
        }
    }
}
