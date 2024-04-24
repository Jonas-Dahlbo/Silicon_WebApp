using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Views;
using WebApp.ViewModels.Views;

namespace WebApp.Controllers
{
    public class CoursesController(SignInManager<UserEntity> signInManager) : Controller
    {
        private readonly SignInManager<UserEntity> _signInManager = signInManager;

        [HttpGet]
        [Route("/courses")]
        public IActionResult Index()
        {
            if (!ModelState.IsValid)
            {
                if (!_signInManager.IsSignedIn(User))
                {
                    return RedirectToAction("Index", "Home");
                }
                var viewModel = new CoursesViewModel();

                ViewData["Title"] = viewModel;
                return View(viewModel);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
