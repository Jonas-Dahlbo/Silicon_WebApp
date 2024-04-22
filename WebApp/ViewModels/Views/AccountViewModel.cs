using Infrastructure.Entities;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.Components;
using WebApp.ViewModels.Sections;

namespace WebApp.ViewModels.Views;

public class AccountViewModel
{

    [Display(Name = "First name")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last name")]
    [DataType(DataType.Text)]
    public string LastName { get; set; } = null!;

    [Display(Name = "Email address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone", Prompt = "Enter your phone")]
    [DataType(DataType.Text)]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Bio", Prompt = "Add a short bio...")]
    [Required(ErrorMessage = "A valid Email Address must be entered")]
    [DataType(DataType.Text)]
    public string Bio { get; set; } = null!;

    [Display(Name = "Address line 1", Prompt = "Enter your address line")]
    [DataType(DataType.Text)]
    public string PrimaryAddress { get; set; } = null!;

    [Display(Name = "Address line 2", Prompt = "Enter your second address line")]
    [DataType(DataType.Text)]
    public string? SecondaryAddress { get; set; } 

    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    [DataType(DataType.Text)]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City", Prompt = "Enter your city")]
    [DataType(DataType.Text)]
    public string City { get; set; } = null!;

    public ImageViewModel ProfileImage { get; set; } = new() { ImageUrl = "images/profile-mid.svg", ImageAlt = "Profile picture"};
}
