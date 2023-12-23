using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }
        public String? ProductName { get; init; } = String.Empty;
        public decimal Price { get; init; }

        public int? CategoryId { get; init; }
    }
}