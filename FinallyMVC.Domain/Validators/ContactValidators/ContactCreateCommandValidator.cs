using FinallyMVC.Domain.Business.ContactModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.ContactValidators
{
    public class ContactCreateCommandValidator : AbstractValidator<ContactCreateCommand>
    {
        public ContactCreateCommandValidator()
        {
            RuleFor(b => b.Body)
                .NotEmpty()
                .WithMessage("Text bosh buraxila bilmez");

            RuleFor(b => b.Title)
                        .NotNull()
                        .WithMessage("Basliq secilmeyib")
                        .NotEmpty()
                        .WithMessage("Basliq bosh buraxila bilmez")
                        .MaximumLength(250)
                        .WithMessage("250 simvoldan cox ola bilmez");


            RuleFor(b => b.Phone)
                .NotEmpty()
                .WithMessage("Nomre bosh buraxila bilmez")
                .MaximumLength(250)
                .WithMessage("250 simvoldan cox ola bilmez");



        }
    }
}
