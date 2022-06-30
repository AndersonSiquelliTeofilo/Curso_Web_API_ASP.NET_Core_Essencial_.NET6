using Catalogo.Application.DTOs;

namespace Catalogo.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<CategoryDTO> GetByIdAsync(int? id);
        Task<CategoryDTO> CreateAsync(CategoryDTO category);
        Task<CategoryDTO> UpdateAsync(CategoryDTO category);
        Task<CategoryDTO> DeleteAsync(int? id);
    }
}