using Catalogo.Application.DTOs;

namespace Catalogo.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int? id);
        Task CreateAsync(ProductDTO product);
        Task UpdateAsync(ProductDTO product);
        Task DeleteAsync(int? id);
    }
}
