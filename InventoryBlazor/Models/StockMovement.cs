namespace InventoryBlazor.Models;

using System.ComponentModel.DataAnnotations;

public class StockMovement
{
    public int Id { get; set; }

    [Required]
    public int ItemId { get; set; }
    public required Item Item { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]

    public DateTime Date { get; set; }

    [Required]
    public MovementType MovementType { get; set; }


}
