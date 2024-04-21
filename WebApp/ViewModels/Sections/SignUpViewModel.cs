using Infrastructure.Filters;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Sections;

public class SignUpViewModel
{
    [Display(Name = "First name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "A valid First Name must be entered")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "A valid Last Name must be entered")]
    [DataType(DataType.Text)]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "A valid Email Address must be entered")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "********")]
    [Required(ErrorMessage = "A valid Password must be entered")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm password", Prompt = "********")]
    [Required(ErrorMessage = "Please confirm your Password")]
    [Compare(nameof(Password), ErrorMessage = "The Passwords do not match, please confirm your Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "I agree to the Terms & Conditions.")]
    [CheckboxRequired(ErrorMessage = "You must agree to the Terms & Conditions to Sign up")]
    public bool TermsConfirmed { get; set; }

}
