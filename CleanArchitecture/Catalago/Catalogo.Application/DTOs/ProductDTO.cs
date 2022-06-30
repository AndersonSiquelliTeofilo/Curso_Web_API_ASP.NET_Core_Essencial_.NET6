using Catalogo.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [MaxLength(250)]
        public string? ImageUrl { get; set; }

        [Required]
        [Range(1, 9999)]
        public int Inventory { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
