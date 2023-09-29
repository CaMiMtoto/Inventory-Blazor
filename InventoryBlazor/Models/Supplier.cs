namespace InventoryBlazor.Models;

using System.ComponentModel.DataAnnotations;

public class Supplier
{

    public int Id { get; set; }

    [Required]
    public int SalutationId { get; set; }
    public required Salutation Salutation { get; set; }

    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    [EmailAddress]
    [StringLength(100)]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [Required]
    [StringLength(20)]
    [DataType(DataType.PhoneNumber)]
    public required string Phone { get; set; }


    [StringLength(100)]
    [DataType(DataType.Text)]
    public string? Address { get; set; }


    [StringLength(100)]
    [DataType(DataType.Url)]
    public string? Website { get; set; }


}
