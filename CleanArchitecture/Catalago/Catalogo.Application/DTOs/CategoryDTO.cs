using System.ComponentModel.DataAnnotations;

namespace Catalogo.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(250)]
        public string? ImageUrl { get; set; }
    }
}
