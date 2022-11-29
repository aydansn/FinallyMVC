using FinallyMVC.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.AccountModule
{
    public class SigninCommand : IRequest<bool>
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public class SigninCommandHandler : IRequestHandler<SigninCommand, bool>
        {
            private readonly SignInManager<FinallymvcUser> signinManager;
            private readonly UserManager<FinallymvcUser> userManager;
            private readonly IActionContextAccessor ctx;

            public SigninCommandHandler(SignInManager<FinallymvcUser> signinManager,
                UserManager<FinallymvcUser> userManager,
                IActionContextAccessor ctx)
            {
                this.signinManager = signinManager;
                this.userManager = userManager;
                this.ctx = ctx;
            }
            public async Task<bool> Handle(SigninCommand request, CancellationToken cancellationToken)
            {
                var user = await userManager.FindByEmailAsync(request.UserName);

                if (user == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Istifadeci adi ve ya sifre sehvdir");
                    goto notFound;
                }

                var result = await signinManager.PasswordSignInAsync(user, request.Password,true,true);

                if (result.Succeeded)
                {
                    return true;
                }
                else if (result.IsLockedOut)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Muveqqeti olaraq sistemden istifade huququnuz legv edilib");
                    goto notFound;
                }
                else if (result.IsNotAllowed)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Sisteme daxil olmaq huququnuz legv edilib");
                    goto notFound;
                }

            notFound:
                return false;
            }
        }

    }
}
