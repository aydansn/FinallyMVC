using FinallyMVC.Domain.Business.PersonModule;
using FinallyMVC.Domain.Business.ServiceModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public ServiceViewComponent(IMediator mediator)
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
