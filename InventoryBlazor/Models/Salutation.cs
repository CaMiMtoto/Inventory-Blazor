namespace InventoryBlazor.Models;

using System.ComponentModel.DataAnnotations;

public class Salutation
{
    public int Id { get; set; }

    [Required]
    [StringLength(10)]
    public required string Title { get; set; }
    public IEnumerable<Supplier>? Suppliers { get; set; }

}
