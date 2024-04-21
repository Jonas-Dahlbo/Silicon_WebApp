using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class UserEntity : IdentityUser
{
    
    [ProtectedPersonalData]
    [StringLength(100)]
    public string FirsName { get; set; } = null!;

    [ProtectedPersonalData]
    [StringLength(100)]
    public string LastName { get; set; } = null!;

    public string? Bio { get; set; } = null!;

    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}

