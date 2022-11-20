using FinallyMVC.Domain.Business.BlogModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.BlogValidator
{
    public class BlogCreateCommandValidator : AbstractValidator<BlogCreateCommand>
    {
        public BlogCreateCommandValidator()
        {
            RuleFor(m => m.Body)
                .NotEmpty()
                .WithMessage("Marka adi qeyd edilmeyib");
        }
    }
}
