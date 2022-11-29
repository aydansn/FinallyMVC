using FinallyMVC.Domain.Business.BlogModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.BlogValidators
{
    public class BlogCreateCommandValidator : AbstractValidator<BlogCreateCommand>
    {
        public BlogCreateCommandValidator()
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

        }
    }
}
