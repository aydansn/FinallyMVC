using FinallyMVC.Domain.Business.InfoModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.InfoValidators
{
    public  class InfoCreateCommandValidator : AbstractValidator<InfoCreateCommand>
    {
        public InfoCreateCommandValidator()
        {
            RuleFor(m => m.Body)
                .NotEmpty()
                .WithMessage("Text adi qeyd edilmeyib");

            RuleFor(m => m.Phone)
               .NotEmpty()
               .WithMessage("Nomre qeyd edilmeyib");
        }
    }
}
