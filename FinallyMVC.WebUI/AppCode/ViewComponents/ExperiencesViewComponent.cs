using FinallyMVC.Domain.Business.ExperienceModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class ExperiencesViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public ExperiencesViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await mediator.Send(new ExperienceAllQuery());
            return View(response);
        }
    }
}
