using FinallyMVC.Domain.Business.PersonModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class PeopleViewComponent:ViewComponent
    {
        private readonly IMediator mediator;

        public PeopleViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new PersonAllQuery();
            var response = await mediator.Send(query);
            var data=response.FirstOrDefault();
            return View(data);
        }
    }
}
