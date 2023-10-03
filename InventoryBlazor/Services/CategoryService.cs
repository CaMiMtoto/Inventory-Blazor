namespace InventoryBlazor.Services;

using Data;
using Microsoft.EntityFrameworkCore;
using Models;

public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;

    public CategoryService(AppDbContext context)
    {
        _context = context;
    }


    public async Task<List<ItemCategory?>?> GetCategoriesAsync()
    {
        return await _context.ItemCategories.ToListAsync();
    }
    public async Task<ItemCategory?> GetCategoryByIdAsync(int id)
    {
        return (await _context.ItemCategories.FindAsync(id))!;
    }
    public async Task CreateCategoryAsync(ItemCategory? category)

    {
        _context.ItemCategories.Add(category);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateCategoryAsync(ItemCategory? category)
    {
        _context.ItemCategories.Update(category);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteCategoryAsync(int id)
    {
        var category = await _context.ItemCategories.FindAsync(id);
        if (category != null) _context.ItemCategories.Remove(category);
        await _context.SaveChangesAsync();
    }
}
