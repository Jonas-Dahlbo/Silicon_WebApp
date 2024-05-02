using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebApp.ViewModels.Views;


namespace WebApp.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {

        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly DataContext _context;

        public ProfileController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, DataContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpGet]
        [Route("/account")]
        public async Task<IActionResult> Account()
        {
            if (ModelState.IsValid)
            {
                if (!_signInManager.IsSignedIn(User))
                { return RedirectToAction("SignIn", "Authentication"); }

                var Id = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
                var userEntity = await _context.Users.Include(i => i.Address).FirstOrDefaultAsync(x => x.Id == Id);

                var viewModel = new AccountViewModel()
                {
                    FirstName = userEntity.FirstName!,
                    LastName = userEntity.LastName!,
                    Email = userEntity.Email!,
                    PhoneNumber = userEntity.PhoneNumber!,
                    Bio = userEntity.Bio!
                };
                if (userEntity.Address != null)
                {
                    viewModel.PrimaryAddress = userEntity.Address.PrimaryAddress;
                    viewModel.SecondaryAddress = userEntity.Address.SecondaryAddress;
                    viewModel.PostalCode = userEntity.Address.PostalCode;
                    viewModel.City = userEntity.Address.City;
                }
                return View(viewModel);
            }
            return RedirectToAction("SignIn", "Authentication");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBasicInfo(AccountViewModel viewModel)
        {


                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    user.FirstName = viewModel.FirstName;
                    user.LastName = viewModel.LastName;
                    user.UserName = viewModel.Email;
                    user.Email = viewModel.Email;
                    user.PhoneNumber = viewModel.PhoneNumber;
                    user.Bio = viewModel.Bio;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded) 
                    { 
                        TempData["StatusMesssage"] = "Basic information updated"; 
                    }
                    else
                    {
                        TempData["StatusMesssage"] = "Unable to save changes";
                    }
                    
                }


            return RedirectToAction("Account","Profile");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAddress(AccountViewModel viewModel)
        {

                var Id = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
                var user = await _context.Users.Include(i => i.Address).FirstOrDefaultAsync(x => x.Id == Id);
                if (user != null)
                {
                    
                    try
                    {
                        if (user.AddressId != null)
                        {
                            user.Address.PrimaryAddress = viewModel.PrimaryAddress;
                            user.Address.SecondaryAddress = viewModel.SecondaryAddress;
                            user.Address.PostalCode = viewModel.PostalCode;
                            user.Address.City = viewModel.City;
                        }
                        else
                        {
                            user.Address = new AddressEntity()
                            {
                                PrimaryAddress = viewModel.PrimaryAddress,
                                SecondaryAddress = viewModel.SecondaryAddress,
                                PostalCode = viewModel.PostalCode,
                                City = viewModel.City,
                            };
                        }

                        _context.Update(user);
                        await _context.SaveChangesAsync();

                        TempData["StatusMesssage"] = "Address information updated";
                    }
                    catch (Exception ex) { TempData["StatusMesssage"] = "Unable to save changes"; }
                }

            return RedirectToAction("Account", "Profile");
        }
    }
}
