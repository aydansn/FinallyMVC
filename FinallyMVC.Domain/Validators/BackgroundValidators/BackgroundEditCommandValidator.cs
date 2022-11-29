using FinallyMVC.Domain.Business.BackgroundModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.BackgroundValidators
{
    public class BackgroundEditCommandValidator : AbstractValidator<BackgroundEditCommand>
    {
        public BackgroundEditCommandValidator()
        {
            RuleFor(m => m.Id)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Id minimum 1 ola biler");

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
