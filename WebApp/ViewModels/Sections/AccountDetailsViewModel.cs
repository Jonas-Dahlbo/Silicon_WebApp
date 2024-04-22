using Infrastructure.Entities;

namespace WebApp.ViewModels.Sections;

public class AccountDetailsViewModel
{
    public UserEntity User { get; set; } = null!;
    public AddressEntity Address { get; set; } = null!;


}
