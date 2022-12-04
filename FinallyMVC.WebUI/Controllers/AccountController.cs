using FinallyMVC.Domain.Business.AccountModule;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator mediator;

        public AccountController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommand command)
        {
            var response = await mediator.Send(command);

            if (!ModelState.IsValid)
            {
                return View(command);
            }

            TempData["Message"] = $"{command.Email} - E-poct`a gonderilen linkle qeydiyyati tamamlayin";
            return RedirectToAction(nameof(SignIn));
        }


        [Route("/email-confirm")]
        public async Task<IActionResult> EmailConfirmation(RegisterConfirmationCommand command)
        {
            var response = await mediator.Send(command);

            if (!ModelState.IsValid)
            {
                return View(command);
            }
            return RedirectToAction(nameof(SignIn));
        }


        [Route("/signin.html")]
        public async Task<IActionResult> Signin()
        {
            return View();
        }

        [HttpPost]
        [Route("/signin.html")]
        public async Task<IActionResult> Signin(SigninCommand command)
        {
            var response = await mediator.Send(command);

            if (!ModelState.IsValid)
            {
                return View(command);
            }

            var callbackUrl = Request.Query["ReturnUrl"].ToString();

            if (!string.IsNullOrWhiteSpace(callbackUrl))
            {
                return Redirect(callbackUrl);
            }

            return RedirectToAction("Index", "Home");

        }


        [Route("/accessdenied.html")]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }


        [Route("/signout.html")]
        public async Task<IActionResult> Signout(SignoutCommand command)
        {
            await mediator.Send(command);

            var callback = Request.Headers["Referer"];

            if (!string.IsNullOrWhiteSpace(callback))
            {
                return Redirect(callback);
            }


            return RedirectToAction("Index", "Home");
        }
    }
}
