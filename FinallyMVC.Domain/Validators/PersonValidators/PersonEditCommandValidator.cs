using FinallyMVC.Domain.Business.PersonModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.PersonValidators
{
    public class PersonEditCommandValidator : AbstractValidator<PersonEditCommand>
    {
        public PersonEditCommandValidator()
        {
            RuleFor(m => m.Id)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Id minimum 1 ola biler");

            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("ad bos buraxila bilmez");

            RuleFor(m => m.Age)
                .NotEmpty()
                .WithMessage("yas adi qeyd edilmeyib");

            RuleFor(m => m.Location)
               .NotEmpty()
               .WithMessage("Mekan adi qeyd edilmeyib");


            RuleFor(m => m.Experience)
               .NotEmpty()
               .WithMessage("Tecrube adi qeyd edilmeyib");

            RuleFor(b => b.Degree)
              .NotEmpty()
              .WithMessage("Derece bosh buraxila bilmez");

            RuleFor(b => b.Careerlevel)
                .NotEmpty()
                .WithMessage("Kariyera addimi bosh buraxila bilmez")
                .MaximumLength(250)
                .WithMessage("250 simvoldan cox ola bilmez");

            RuleFor(b => b.Phone)
              .NotEmpty()
              .WithMessage("nomre bosh buraxila bilmez");

            RuleFor(b => b.Fax)

                .NotNull()
                .WithMessage("Fax secilmeyib");


            RuleFor(b => b.EMail)

                .NotNull()
                .WithMessage("Email secilmeyib");
        }
    }
}
