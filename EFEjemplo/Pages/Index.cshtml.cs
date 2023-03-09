using EFEjemplo.DataContext;
using EFEjemplo.Models;
using EFEjemplo.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

            // insert = add, addRange

            // lectura toda la tabla

            var categorias = producContext.Category.ToList();

            var muebles = categorias.Where(x => x.Categoria == "Muebles").ToList();


            // where en la consulta
            var mueblesCategoria = producContext.Category
                .OrderBy(x=> x.Categoria) // order by
                .Where(x => ( x.Categoria == "Muebles" && x.Categoria == "Comida")  ||  x.Id == 1 ) // where 
                .Take(2).ToList(); // Take se traduce como top x


           

            var mueble = producContext.Category.Find(1); // find busca el elemento por Id

            var muebleFirst = producContext.Category.First(x => x.Categoria == "Muebles"); // select top 1

          //  var proc = producContext.Database.ExecuteSqlRaw("insert into Category values ('Mi otra categoria')"); // ejecutar codigo de sql

            var tablaFromProc = producContext.Category.FromSqlRaw("select * from category").ToList(); // ejecuta codigo de sql pero nos trae un resultado


            var productos = producContext.Products.Include(x=> x.Categoria).ToList(); // select con Join

            /// consultas dinamicas
            /// 
            IQueryable<Product> dinanmycProducts = producContext.Products.AsQueryable();
            
            dinanmycProducts = dinanmycProducts.Include(x => x.Categoria);

            dinanmycProducts = dinanmycProducts.Where(x => x.Nombre == "Muebles");

            dinanmycProducts = dinanmycProducts.OrderBy(x => x.Nombre);

            dinanmycProducts = dinanmycProducts.Take(2);

            var resultDinamycProducts = dinanmycProducts.ToList();







            
        }

        
    }




}