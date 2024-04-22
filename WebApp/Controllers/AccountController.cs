using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels.Views;


namespace WebApp.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public AccountController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        [Route("/account")]
        public async Task<IActionResult> Account()
        {
            if (!_signInManager.IsSignedIn(User))
            { return RedirectToAction("SignIn", "Authentication"); }

            var userEntity = await _userManager.GetUserAsync(User);

            var viewModel = new AccountViewModel() 
            {
                FirstName = userEntity.FirstName!,
                LastName = userEntity.LastName!,
                Email = userEntity.Email!,
                PhoneNumber = userEntity.PhoneNumber!,
                Bio = userEntity.Bio!,

            };
            return View(viewModel);
        }

        [HttpPost]
        [Route("/account")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
