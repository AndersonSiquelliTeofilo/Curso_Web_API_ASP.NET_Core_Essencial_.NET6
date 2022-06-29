using AutoMapper;
using Catalogo.Application.DTOs;
using Catalogo.Application.Interfaces;
using Catalogo.Domain.Entities;
using Catalogo.Domain.Interfaces;

namespace Catalogo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(
            ICategoryRepository categoryRepository,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            var categoriesEntity = await _categoryRepository.GetCategoriesAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task<CategoryDTO> GetByIdAsync(int? id)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryDTO>(categoryEntity);
        }

        public async Task CreateAsync(CategoryDTO category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            await _categoryRepository.CreateAsync(categoryEntity);
        }

        public async Task UpdateAsync(CategoryDTO category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            await _categoryRepository.UpdateAsync(categoryEntity);
        }

        public async Task DeleteAsync(int? id)
        {
            var categoryEntity = _categoryRepository.GetByIdAsync(id).Result;
            await _categoryRepository.DeleteAsync(categoryEntity);
        }
    }
}