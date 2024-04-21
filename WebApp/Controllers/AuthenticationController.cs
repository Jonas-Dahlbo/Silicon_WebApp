using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Sections;

namespace WebApp.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        [Route("/signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("/signup")]
        public IActionResult SignUp(SignUpViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                
            }

            return View(viewModel);
        }
    }
}
