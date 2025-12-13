using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Models;

public partial class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Name is not left blank")]

    public string ProductName { get; set; } = null!;
    [Required(ErrorMessage = "Description is not left blank")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "Price is not left blank")]
    public decimal Price { get; set; }

    public decimal? DiscountPercent { get; set; }
    [Required(ErrorMessage = "Stock is not left blank")]
    public int? Stock { get; set; }

    public int? Quantity { get; set; }

    public string? ImageUrl { get; set; }
    [Required(ErrorMessage = "Category is not left blank")]
    public string? CategoryName { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
