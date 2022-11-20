using FinallyMVC.Domain.Business.ServiceModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.ServiceValidator
{
    public class ServiceCreateCommandValidator : AbstractValidator<ServiceCreateCommand>
    {
        public ServiceCreateCommandValidator()
        {
            RuleFor(m => m.Body)
                .NotEmpty()
                .WithMessage("Marka adi qeyd edilmeyib");
        }
    }
}
