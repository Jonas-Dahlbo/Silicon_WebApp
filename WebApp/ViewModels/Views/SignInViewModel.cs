using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels.Views;

public class SignInViewModel
{

    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "A valid Email Address must be entered")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "********")]
    [Required(ErrorMessage = "The correct Password must be entered")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; }
}
