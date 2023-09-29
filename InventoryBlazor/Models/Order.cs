namespace InventoryBlazor.Models;

using System.ComponentModel.DataAnnotations;

public class Order
{
    public int Id { get; set; }

    [Required]
    public int CustomerId { get; set; }
    public required Customer Customer { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [StringLength(400)]
    [DataType(DataType.MultilineText)]
    public string? Notes { get; set; }
    public List<OrderItem>? OrderItems { get; set; }


}
