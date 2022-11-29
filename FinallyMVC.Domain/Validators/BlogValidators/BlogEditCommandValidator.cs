using FinallyMVC.Domain.Business.BlogModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.BlogValidators
{
    public class BlogEditCommandValidator : AbstractValidator<BlogEditCommand>
    {
        public BlogEditCommandValidator()
        {
            RuleFor(m => m.Id)
              .GreaterThanOrEqualTo(1)
              .WithMessage("Id minimum 1 ola biler");

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

            RuleFor(b => b.ImageURL)
                .NotNull()
                .WithMessage("Sekil secilmeyib");

        }
    }
}
