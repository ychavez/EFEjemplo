using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFEjemplo.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MinLength(2)]
        [MaxLength(100)]
        [Column(TypeName = "VARCHAR")]
        public string Nombre { get; set; } = null!;

        [Range(0,double.MaxValue)]
        public decimal Precio { get; set; }

        public Category Categoria { get; set; } = null!;


    }
}
