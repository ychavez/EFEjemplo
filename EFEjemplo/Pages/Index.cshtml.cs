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

            //producContext.Products.Add(new Product { Nombre = "Teclado", Categoria = "Computo", Precio = 100m });
            //producContext.Products.Add(new Product { Nombre = "Mouse", Categoria = "Computo", Precio = 150m });
            //producContext.Products.Add(new Product { Nombre = "Monitor", Categoria = "Computo", Precio = 200m });
            //producContext.Products.Add(producto);

            //producContext.SaveChanges();

            /// select * from

            var productos = producContext.Products.ToList();

            var mouse = producContext.Products.Where(x => x.Nombre == "Mouse");
            var mouse2 = producContext.Products.Find(3);

            var mouse3 = producContext.Products.Skip(2).Take(1).First();

            var mouse4 = productos[3];

            //foreach (var item in productos)
            //{

            //}

            //for (int i = 0; i < productos.Count(); i++)
            //{
            //    var producto = productos[i];
            //}



            //Tools tools = new();
            //var algo = tools.TraerAlgo();

            var algo = _tools.TraerAlgo();
            
        }

        
    }




}