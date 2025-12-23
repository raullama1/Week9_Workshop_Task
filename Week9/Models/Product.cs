using System.ComponentModel.DataAnnotations;

namespace Week9.Models;

// Product model class
public class Product
{
    // Unique product id
    public int Id { get; set; }

    // Product name (required)
    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    // Image URL of product
    [Required(ErrorMessage = "Image is required")]
    [Url(ErrorMessage = "Enter a valid URL")]
    public string Image { get; set; } = string.Empty;

    // Product price
    [Required(ErrorMessage = "Price is required")]
    [Range(0.01, 1000000)]
    public decimal Price { get; set; }

    // Short description
    [Required(ErrorMessage = "Description is required")]
    [StringLength(200, MinimumLength = 5)]
    public string Description { get; set; } = string.Empty;

    // Stock value
    [Range(0, 1000000)]
    public int Stock { get; set; }
}