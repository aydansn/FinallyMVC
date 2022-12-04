using FinallyMVC.Domain.Business.BlogModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class BlogsViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public BlogsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await mediator.Send(new BlogAllQuery());
            return View(response);
        }
    }
}
