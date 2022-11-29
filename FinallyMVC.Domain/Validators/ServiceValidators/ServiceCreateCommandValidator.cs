using FinallyMVC.Domain.Business.ServiceModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.ServiceValidators
{
    public class ServiceCreateCommandValidator : AbstractValidator<ServiceCreateCommand>
    {
        public ServiceCreateCommandValidator()
        {
            RuleFor(m => m.Body)
                .NotEmpty()
                .WithMessage("Text adi qeyd edilmeyib");

            RuleFor(b => b.ImageURL)
          .NotNull()
          .WithMessage("Sekil secilmeyib");
            RuleFor(b => b.Title)
                                .NotNull()
                                .WithMessage("Basliq secilmeyib")
                                .NotEmpty()
                                .WithMessage("Basliq bosh buraxila bilmez")
                                .MaximumLength(250)
                                .WithMessage("250 simvoldan cox ola bilmez");
        }
    }
}
