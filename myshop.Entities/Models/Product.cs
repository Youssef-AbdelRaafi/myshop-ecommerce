using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace myshop.Entities.Models;
public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    [DisplayName("Image")]
    [ValidateNever]
    public string Img { get; set; } = String.Empty;

    [Required]
    public decimal Price { get; set; }

    [Required]
    [DisplayName("Category")]
    public int CategoryId { get; set; }
    [ValidateNever]
    public Category Category { get; set; } = null!;
}
