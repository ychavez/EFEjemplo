using EFEjemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFEjemplo.DataContext
{
    public class ProducContext : DbContext
    {
        public ProducContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}
