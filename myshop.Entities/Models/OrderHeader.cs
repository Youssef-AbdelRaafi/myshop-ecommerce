using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace myshop.Entities.Models;
public class OrderHeader
{
    public int Id { get; set; }

    public string ApplicationUserId { get; set; } = String.Empty;

    [ValidateNever]
    public ApplicationUser ApplicationUser { get; set; } = null!;

    public DateTime OrderDate { get; set; }
    public DateTime ShippingDate { get; set; }

    public decimal TotalPrice { get; set; }

    public string? OrderStatus { get; set; }
    public string? PaymentStatus { get; set; }

    public string? TrakcingNumber { get; set; }
    public string? Carrier { get;set; }

    public DateTime PaymentDate { get; set; }

    //Stripe Properties

    public string? SessionId { get; set; }
    public string? PaymentIntentId { get; set; }

    //User Data
    public string Name { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public string City { get; set; } = String.Empty;
    public string? PhoneNumber { get; set; }

}
