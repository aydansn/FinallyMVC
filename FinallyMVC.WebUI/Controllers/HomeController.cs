using FinallyMVC.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinallyMVC.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

        private readonly AppDbContext db;

        public HomeController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
