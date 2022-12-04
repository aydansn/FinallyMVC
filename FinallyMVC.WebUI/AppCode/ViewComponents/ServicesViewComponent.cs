using FinallyMVC.Domain.Business.ServiceModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class ServicesViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public ServicesViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new ServiceAllQuery();
            var response = await mediator.Send(query);
            return View(response);
        }
    }
}
