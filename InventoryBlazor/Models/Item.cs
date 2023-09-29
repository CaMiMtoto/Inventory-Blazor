using System.ComponentModel.DataAnnotations;

namespace InventoryBlazor.Models;

public class Item
{
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Range(0, int.MaxValue)]
    [Display(Name = "Stock Quantity")]
    public int StockQuantity { get; set; } = 0;

    public decimal Price { get; set; }
    public int ItemCategoryId { get; set; }

    public required ItemCategory ItemCategory { get; set; }
    public List<OrderItem>? OrderItems { get; set; }
    public List<StockMovement>? StockMovements { get; set; }
}
