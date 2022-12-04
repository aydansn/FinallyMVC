using FinallyMVC.Domain.Business.BackgroundModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class BackgroundsViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public BackgroundsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await mediator.Send(new BackgroundGetAllQuery());
            return View(response);
        }
    }
}
