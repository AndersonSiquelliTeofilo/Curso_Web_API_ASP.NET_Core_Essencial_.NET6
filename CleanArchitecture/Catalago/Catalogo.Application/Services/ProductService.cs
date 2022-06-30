using AutoMapper;
using Catalogo.Application.DTOs;
using Catalogo.Domain.Entities;
using Catalogo.Domain.Interfaces;

namespace Catalogo.Application.Interfaces
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(
            IProductRepository productRepository, 
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            var productsEntity = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task<ProductDTO> GetByIdAsync(int? id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<ProductDTO> CreateAsync(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            var productDTO = _mapper.Map<ProductDTO>(await _productRepository.CreateAsync(productEntity));
            return productDTO;
        }

        public async Task<ProductDTO> UpdateAsync(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            var productDTO = _mapper.Map<ProductDTO>(await _productRepository.UpdateAsync(productEntity));
            return productDTO;
        }

        public async Task<ProductDTO> DeleteAsync(int? id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            var productDTO = _mapper.Map<ProductDTO>(await _productRepository.DeleteAsync(productEntity));
            return productDTO;
        }
    }
}
