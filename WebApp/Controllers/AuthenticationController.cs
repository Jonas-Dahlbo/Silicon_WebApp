using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.ViewModels.Views;

namespace WebApp.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public AuthenticationController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        [Route("/signup")]
        public IActionResult SignUp()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
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
                        return RedirectToAction("SignIn", "Authentication");
                    }

                }

                ViewData["ErrorMessage"] = "Email already exists";
                return View(viewModel);
            }

            return View(viewModel);
        }
        
        [HttpGet]
        [Route("/signin")]
        public IActionResult SignIn()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Account", "Profile");
            }

            return View();
        }

        [HttpPost]
        [Route("/signin")]
        public async Task<IActionResult> SignIn(SignInViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Account", "Profile");
                }
            }

            ViewData["ErrorMessage"] = "Incorrect email or password";
            return View(viewModel);
        }

        [HttpGet]
        [Route("/signout")]
        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}
