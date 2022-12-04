using FinallyMVC.Domain.Business.SkillModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.AppCode.ViewComponents
{
    public class HardSkillsViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public HardSkillsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await mediator.Send(new SkillAllQuery());
            var result = response.Where(s => (int)s.SkillType == 0);
            return View(result);
        }
    }
}
