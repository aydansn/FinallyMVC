using FinallyMVC.Domain.Business.InfoModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.InfoValidator
{
    public  class InfoCreateCommandValidator : AbstractValidator<InfoCreateCommand>
    {
        public InfoCreateCommandValidator()
        {
            RuleFor(m => m.Body)
                .NotEmpty()
                .WithMessage("Marka adi qeyd edilmeyib");
        }
    }
}
