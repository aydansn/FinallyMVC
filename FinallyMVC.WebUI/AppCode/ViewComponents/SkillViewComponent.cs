using FinallyMVC.Domain.Business.PersonModule;
using FinallyMVC.Domain.Business.SkillModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public SkillViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new SkillAllQuery();    
            var response = await mediator.Send(query);
            return View(response);
        }
    }
}
