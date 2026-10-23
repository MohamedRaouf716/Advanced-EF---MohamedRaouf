namespace WebApplication1.DTOs
{
    public class UpdateProductDTO
    {
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string? Description { get; set; }

        public int CategoryId { get; set; }
    }
}
