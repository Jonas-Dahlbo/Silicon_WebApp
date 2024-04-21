using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Sections;

namespace WebApp.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;

        public AuthenticationController(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [Route("/signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("/signup")]
        public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var exists = await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email);

                if (!exists)
                {
                    var userEntity = new UserFactory().ReturnUserEntity(viewModel);
                    
                    var result = await _userManager.CreateAsync(userEntity, viewModel.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("SignIn, Authentication");
                    }

                }

                ViewData["ErrorMessage"] = "Email already exists";
                return View(viewModel);
            }

            return View(viewModel);
        }
    }
}
