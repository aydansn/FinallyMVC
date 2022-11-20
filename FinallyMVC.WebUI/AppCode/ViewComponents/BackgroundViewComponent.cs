using FinallyMVC.Domain.Business.BackgroundModule;
using FinallyMVC.Domain.Business.ExperienceModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class BackgroundViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public BackgroundViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new BackgroundGetAllQuery();
            var response = await mediator.Send(query);
            return View(response);
        }
    }
}
