using FinallyMVC.Domain.Business.BackgroundModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.BackgroundValidator
{
    public class BackgroundCreateCommandValidator : AbstractValidator<BackgroundCreateCommand>
    {
        //public BackgroundCreateCommandValidator()
        //{
        //    RuleFor(c => c.Body)
        //        .NotEmpty()
        //        .WithMessage("Ad bosh buraxila bilmez");

        //    RuleFor(c => c.Profession)
        //        .NotEmpty()
        //        .WithMessage("ShortDescription bosh buraxila bilmez")
        //        .MaximumLength(250)
        //        .WithMessage("250 simvoldan cox ola bilmez");

        //    RuleFor(c => c.Date)
        //        .GreaterThanOrEqualTo(1)
        //        .WithMessage("Marka secilmeyib")
        //        .NotNull()
        //        .WithMessage("Marka secilmeyib");

        //    RuleFor(c => c.Place)
        //        .GreaterThanOrEqualTo(1)
        //        .WithMessage("Kategoriya secilmeyib")

        //        .NotNull()
        //        .WithMessage("Kategoriya secilmeyib");

        //    RuleFor(c => c.Profession)
        //        .Custom((list, context) =>
        //        {
        //            if (list == null || list.Count(l => l.IsMain == true) == 0)
        //            {
        //                context.AddFailure("Esas sekil secilmeyib");
        //            }
        //        });

        //    RuleForEach(c => c.Place)
        //        .ChildRules(x =>
        //        {
        //            x.RuleFor(e => e.File)
        //            .NotNull()
        //            .WithMessage("Fayl secilmeyib");

        //        });
        //}
    }
}
