using FinallyMVC.Domain.Business.ContactModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class ContactsViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public ContactsViewComponent(IMediator mediator)
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
