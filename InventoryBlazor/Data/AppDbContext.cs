using InventoryBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryBlazor.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}


    // DbSet for your Category model
    public DbSet<ItemCategory> ItemCategories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Salutation> Salutations { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public DbSet<StockMovement> StockMovements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>()
            .HasOne(i => i.ItemCategory)
            .WithMany(ic => ic.Items)
            .HasForeignKey(p => p.ItemCategoryId);

        modelBuilder.Entity<Supplier>()
            .HasOne(p => p.Salutation)
            .WithMany(s => s.Suppliers)
            .HasForeignKey(p => p.SalutationId);

        modelBuilder.Entity<Order>()
            .HasOne(p => p.Customer)
            .WithMany(p => p.Orders)
            .HasForeignKey(p => p.CustomerId);

        modelBuilder.Entity<OrderItem>()
            .HasOne(p => p.Order)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(p => p.OrderId);


        modelBuilder.Entity<OrderItem>()
            .HasOne(p => p.Item)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(p => p.ItemId);

        modelBuilder.Entity<StockMovement>()
            .HasOne(sm => sm.Item)
            .WithMany(p => p.StockMovements)
            .HasForeignKey(sm => sm.ItemId);

    }
}
