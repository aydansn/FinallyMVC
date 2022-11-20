using FinallyMVC.Domain.Business.InfoModule;
using FinallyMVC.Domain.Business.PersonModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class InfoViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public InfoViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new InfoAllQuery();
            var response = await mediator.Send(query);
            return View(response);
        }
    }
}
