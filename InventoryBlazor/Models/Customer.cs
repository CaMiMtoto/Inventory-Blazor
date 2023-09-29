namespace InventoryBlazor.Models;

using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    [StringLength(100)]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }

    [EmailAddress]
    [StringLength(100)]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [StringLength(100)]
    [DataType(DataType.Text)]
    public string? Address { get; set; }

    public List<Order>? Orders { get; set; }
}
