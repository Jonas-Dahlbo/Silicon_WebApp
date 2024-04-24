using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Views;
using WebApp.ViewModels.Views;

namespace WebApp.Controllers
{
    public class CoursesController : Controller
    {
        [HttpGet]
        [Route("/courses")]
        public IActionResult Index()
        {
            var viewModel = new CoursesViewModel();

            ViewData["Title"] = viewModel;
            return View(viewModel);
        }
    }
}
