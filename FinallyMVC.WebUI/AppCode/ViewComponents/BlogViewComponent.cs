using FinallyMVC.Domain.Business.BlogModule;
using FinallyMVC.Domain.Business.PersonModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public BlogViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new BlogAllQuery();
            var response = await mediator.Send(query);
            return View(response);
        }
    }
}
