using FinallyMVC.Domain.Business.ExperienceModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public ExperienceViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new ExperienceAllQuery();
            var response = await mediator.Send(query);
            return View(response);
        }
    }
}
