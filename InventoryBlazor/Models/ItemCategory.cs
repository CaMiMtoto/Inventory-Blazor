using System.ComponentModel.DataAnnotations;

namespace InventoryBlazor.Models;

public class ItemCategory
{
    public int Id { get; set; }

    [StringLength(100)]
    [DataType(DataType.Text)]
    public required string Name { get; set; }

    [StringLength(500)]
    [DataType(DataType.MultilineText)]
    public string? Description { get; set; }

    public List<Item> Items { get; set; } = new();
}
