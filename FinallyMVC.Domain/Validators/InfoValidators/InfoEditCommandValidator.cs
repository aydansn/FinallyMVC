using FinallyMVC.Domain.Business.InfoModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.InfoValidators
{
    public class InfoEditCommandValidator : AbstractValidator<InfoEditCommand>
    {
        public InfoEditCommandValidator()
        {
            RuleFor(m => m.Id)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Id minimum 1 ola biler");

            RuleFor(m => m.Body)
                .NotEmpty()
                .WithMessage("Text adi qeyd edilmeyib");

            RuleFor(m => m.Phone)
               .NotEmpty()
               .WithMessage("Nomre qeyd edilmeyib");
            RuleFor(b => b.ImageURL)

                .NotNull()
                .WithMessage("Sekil secilmeyib");
        }
    }
}
