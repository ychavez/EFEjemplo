namespace EFEjemplo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Categoria { get; set; }
        public decimal Precio { get; set; }
    }
}
