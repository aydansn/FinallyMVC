using FianllyMVC.Domain.Business.AccountModule;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.AppCode.Providers
{
    public class AppClaimsProvider : IClaimsTransformation
    {
        public static string[] policies = null;
        private readonly IMediator mediator;

        public AppClaimsProvider(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (principal.Identity.IsAuthenticated)
            {
                var query = new ReloadAuthorityQuery
                {
                    User = principal
                };

                await mediator.Send(query);
            }
            return principal;
        }
    }
}
