using FinallyMVC.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Business.AccountModule
{
    public class SignoutCommand : IRequest<bool>
    {

        public class SignoutCommandHandler : IRequestHandler<SignoutCommand, bool>
        {
            private readonly SignInManager<FinallymvcUser> signinManager;

            public SignoutCommandHandler(SignInManager<FinallymvcUser> signinManager)
            {
                this.signinManager = signinManager;
            }


            public async Task<bool> Handle(SignoutCommand request, CancellationToken cancellationToken)
            {
                await signinManager.SignOutAsync();
                return true;
            }
        }
    }
}
