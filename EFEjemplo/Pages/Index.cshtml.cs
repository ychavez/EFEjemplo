using EFEjemplo.DataContext;
using EFEjemplo.Models;
using EFEjemplo.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EFEjemplo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITools _tools;
        private readonly ProducContext producContext;

        public IndexModel(ILogger<IndexModel> logger, ITools tools, ProducContext producContext )
        {
            _logger = logger;
            _tools = tools;
            this.producContext = producContext;
        }

        public void OnGet()
        {

            //var dt = new DataTable();

            //using (var conn = new SqlConnection("asdf/asdf/asdf/sdf/asdf/"))
            //using (var cmd = new SqlCommand("select * from products", conn)) 
            //{
            //    using (var da = new SqlDataAdapter(cmd)) 
            //    {

            //        da.Fill(dt);
            //    }

            //}

            //foreach (DataRow row in dt.Rows)
            //{
            //    int productId = int.Parse( row[0].ToString())
            //}

            //var producto = new Product();

            //producto.Nombre = "CPU";
            //producto.Categoria = "Computo";
            //producto.Precio = 300;
            //producContext.Products.Add(producto);

            //producContext.Products.Add(new Product { Nombre = "Teclado", Categoria = "Computo", Precio = 100m });
            //producContext.Products.Add(new Product { Nombre = "Mouse", Categoria = "Computo", Precio = 150m });
            //producContext.Products.Add(new Product { Nombre = "Monitor", Categoria = "Computo", Precio = 200m });

            //producContext.SaveChanges();

            /// select * from

            var products = producContext.Products.ToList(); // select * from  products;



            //Tools tools = new();
            //var algo = tools.TraerAlgo();

            var algo = _tools.TraerAlgo();

            /*    add-migration {nombre de la migracion}
             *    update-database
             * 
             * Practica: 
             * 1.- crear un proyecto web de razor pages
             * 2.- crear un servicio (inyeccion de dependencias) que tenga un metodo que nos sirva para
             *   imprimir la fecha actual en la consola
             * 3.- configurar la inyeccion de dependencias para este servicio
             * 4.- agregar ese servicio al inde y probar su funcionalidad
             * 
             * 5.- crearemos un modelo que se llamara Actor y tendra las propiedades (Id,nombre, apellido)
             * 6.- agregar Entityframework y realizar inserciones y una lectura en el index
             *    tomar en cuenta la cofiguracion de entityframework y las migraciones)
             */
            
        }

        
    }




}