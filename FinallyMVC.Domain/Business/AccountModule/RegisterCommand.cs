using FinallyMVC.Domain.AppCode.Services;
using FinallyMVC.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.AccountModule
{
    public class RegisterCommand : IRequest<FinallymvcUser>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, FinallymvcUser>
        {
            private readonly UserManager<FinallymvcUser> userManager;
            private readonly IActionContextAccessor ctx;
            private readonly IEmailService emailService;
            private readonly ICryptoService cryptoService;

            public RegisterCommandHandler(UserManager<FinallymvcUser> userManager, IActionContextAccessor ctx,
                IEmailService emailService, ICryptoService cryptoService)
            {
                this.userManager = userManager;
                this.ctx = ctx;
                this.emailService = emailService;
                this.cryptoService = cryptoService;
            }

            public async Task<FinallymvcUser> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                var user = await userManager.FindByEmailAsync(request.Email);


                if (user != null)
                {
                    ctx.ActionContext.ModelState.AddModelError("Email", "Bu e-poct artiq istifade olunub");
                    return null;
                }


                user = new FinallymvcUser
                {
                    Email = request.Email,
                    Name = request.Name,
                    Surname = request.Surname,
                    UserName = $"{request.Name}-{Guid.NewGuid()}".ToLower()
                };

                //var countOfUserName = await userManager.Users.CountAsync(u => u.UserName.StartsWith(user.UserName)
                //               , cancellationToken);

                //if (countOfUserName > 0)
                //{
                //    user.UserName = $"{request.Surname}.{request}{countOfUserName + 1}";
                //}


                var result = await userManager.CreateAsync(user, request.Password);

                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ctx.ActionContext.ModelState.AddModelError("Name", item.Description);
                    }

                    return null;
                }

                var token = await userManager.GenerateEmailConfirmationTokenAsync(user);


                string myToken = cryptoService.Encrypt($"{user.Id}-{token}", true);

                string scheme = ctx.ActionContext.HttpContext.Request.Scheme;
                string host = ctx.ActionContext.HttpContext.Request.Host.ToString();


                var url = $"{scheme}://{host}/email-confirm?token={myToken}";

                //{scheme}://{host}/email-confirm?token=1

                await emailService.SendEmailAsync(user.Email,
                    "Registration",
                    $"Qeydiyyati tamamlamaq ucun <a href='{url}'>buraya</a> kecid edin");

                return user;
            }
        }
    }
}
