using FinallyMVC.Domain.AppCode.Extensions;
using FinallyMVC.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.AccountModule
{
    public class SigninCommand : IRequest<FinallymvcUser>
    {
        public string UserName { get; set; }
        public string Password { get; set; }


        public class SigninCommandHandler : IRequestHandler<SigninCommand, FinallymvcUser>
        {
            private readonly SignInManager<FinallymvcUser> signinManager;
            private readonly IActionContextAccessor ctx;

            public SigninCommandHandler(SignInManager<FinallymvcUser> signinManager, IActionContextAccessor ctx)
            {
                this.signinManager = signinManager;
                this.ctx = ctx;
            }


            public async Task<FinallymvcUser> Handle(SigninCommand request, CancellationToken cancellationToken)
            {
                FinallymvcUser user = null;


                if (request.UserName.IsEmail())
                {
                    user = await signinManager.UserManager.FindByEmailAsync(request.UserName);
                }
                else
                {
                    user = await signinManager.UserManager.FindByNameAsync(request.UserName);
                }


                if (user == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Istifadeci adi ve ya sifre sehvdir");

                    return null;
                }

                var result = await signinManager.PasswordSignInAsync(user, request.Password, true, true);


                if (result.IsLockedOut)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Hesabibiz kecici olaraq mehdudlashdirilib");

                    return null;
                }


                if (result.IsNotAllowed)
                {
                    ctx.ActionContext.ModelState.AddModelError("UserName", "Hesaba daxil olmaq mumkun deyil");

                    return null;
                }


                if (result.Succeeded)
                {
                    return user;
                }

                if (!user.EmailConfirmed)
                {
                    await signinManager.SignOutAsync();
                }



                ctx.ActionContext.ModelState.AddModelError("UserName", "Istifadeci adi ve ya sifre sehvdir");
                return null;
            }
        }
    }
}
