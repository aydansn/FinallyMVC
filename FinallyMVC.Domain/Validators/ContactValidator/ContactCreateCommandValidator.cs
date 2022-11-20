using FinallyMVC.Domain.Business.ContactModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.ContactValidator
{
    public class ContactCreateCommandValidator : AbstractValidator<ContactCreateCommand>
    {
        public ContactCreateCommandValidator()
        {
            RuleFor(m => m.Body)
              .NotEmpty()
              .WithMessage("Marka adi qeyd edilmeyib");
        }
    }
}
