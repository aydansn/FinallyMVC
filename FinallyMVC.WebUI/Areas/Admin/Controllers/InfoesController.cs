using FinallyMVC.Domain.Business.InfoModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BigOn.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InfosController : Controller
    {
        private readonly IMediator mediator;

        public InfosController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index(InfoAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(InfoCreateCommand command)
        {
            var response = await mediator.Send(command);
            if (response == null)
            {
                return View(command);
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(InfoSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(InfoEditCommand command)
        {
            var response = await mediator.Send(command);
            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(InfoSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Remove(InfoRemoveCommand command)
        {
            var response = await mediator.Send(command);


            if (response.Error)
            {
                return Json(response);
            }

            var newQuery = new InfoAllQuery();
            var data = await mediator.Send(newQuery);
            return PartialView("_ListBody", data);
        }
    }
}
