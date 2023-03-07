using EFEjemplo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFEjemplo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITools _tools;

        public IndexModel(ILogger<IndexModel> logger, ITools tools)
        {
            _logger = logger;
            _tools = tools;
        }

        public void OnGet()
        {
            //Tools tools = new();
            //var algo = tools.TraerAlgo();

            var algo = _tools.TraerAlgo();
            
        }
    }




}