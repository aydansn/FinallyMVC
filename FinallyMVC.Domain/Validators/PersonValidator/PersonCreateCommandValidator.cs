using FinallyMVC.Domain.Business.PersonModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.PersonValidator
{
    public class PersonCreateCommandValidator : AbstractValidator<PersonCreateCommand>
    {
        public PersonCreateCommandValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Marka adi qeyd edilmeyib");
        }
    }
}
