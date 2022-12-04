using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.AppCode.Extensions
{
    public static partial class Extension
    {

        public static int? GetUserId(this ClaimsPrincipal principal)
        {
            var nameIdentifier = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (nameIdentifier == null)
            {
                return null;
            }

            return Convert.ToInt32(nameIdentifier);
        }

        public static int? GetUserId(this IActionContextAccessor ctx)
        {
            return ctx.ActionContext.HttpContext.User.GetUserId();
        }

        public static int? GetUserId(this HttpContext ctx)
        {
            return ctx.User.GetUserId();
        }
    }
}
