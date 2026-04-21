using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace myshop.Entities.Models;
public class ApplicationUser:IdentityUser
{
    [Required]
    public string Name { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public string City { get; set; } = String.Empty;
}
