namespace InventoryBlazor.Models;

using System.ComponentModel.DataAnnotations;

public class OrderItem
{
    public int Id { get; set; }

    [Required]
    public int OrderId { get; set; }
    public required Order Order { get; set; }

    [Required]
    public int ItemId { get; set; }
    public required Item Item { get; set; }

    [Required]
    public int Quantity { get; set; } = 1;

    [Required]
    public decimal Price { get; set; }
    
    

}
