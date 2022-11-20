using FinallyMVC.Domain.Business.ContactModule;
using FinallyMVC.Domain.Business.PersonModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public ContactViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new ContactAllQuery();
            var response = await mediator.Send(query);
            return View(response);
        }
    }
}
