using Catalogo.Application.DTOs;

namespace Catalogo.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int? id);
        Task<ProductDTO> CreateAsync(ProductDTO product);
        Task<ProductDTO> UpdateAsync(ProductDTO product);
        Task<ProductDTO> DeleteAsync(int? id);
    }
}
