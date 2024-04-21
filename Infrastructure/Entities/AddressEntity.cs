using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class AddressEntity
{
    public int Id { get; set; }

    [ProtectedPersonalData]
    [StringLength(100)]
    public string PrimaryAddress { get; set; } = null!;

    [ProtectedPersonalData]
    [StringLength(100)]
    public string? SecondaryAddress { get; set; } = null!;

    [ProtectedPersonalData]
    [StringLength(10)]
    public string PostalCode { get; set; } = null!;

    [ProtectedPersonalData]
    [StringLength(100)]
    public string City { get; set; } = null!;

    public ICollection<UserEntity> Users { get; set; } = [];
}

