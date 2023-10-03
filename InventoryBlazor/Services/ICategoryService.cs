namespace InventoryBlazor.Services;

using Models;

public interface ICategoryService
{
    Task<List<ItemCategory?>?> GetCategoriesAsync();
    Task<ItemCategory?> GetCategoryByIdAsync(int id);
    Task CreateCategoryAsync(ItemCategory? category);
    Task UpdateCategoryAsync(ItemCategory? category);
    Task DeleteCategoryAsync(int id);
}
