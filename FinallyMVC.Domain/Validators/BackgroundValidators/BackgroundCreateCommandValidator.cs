using FinallyMVC.Domain.Business.BackgroundModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.BackgroundValidators
{
    public class BackgroundCreateCommandValidator : AbstractValidator<BackgroundCreateCommand>
    {
        public BackgroundCreateCommandValidator()
        {
            RuleFor(b => b.Body)
               .NotEmpty()
               .WithMessage("Text bosh buraxila bilmez");

            RuleFor(b => b.Profession)
                .NotNull()
                .WithMessage("Sahe secilmeyib")
                .MaximumLength(250)
                .WithMessage("250 simvoldan cox ola bilmez");

         

            RuleFor(b => b.Place)
                .NotNull()
                .WithMessage("Mekan secilmeyib");

        }
    }
}
