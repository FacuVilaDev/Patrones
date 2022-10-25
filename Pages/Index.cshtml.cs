using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Patrones_GOF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patrones_GOF.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [HttpPost("Singleton")]
        public async Task<IActionResult> OnPostSingleton()
        {
            Conexion c = Conexion.GetConexion();
            c.Conectar();
            c.Desconectar();
            bool respuesta = c.GetType() == typeof(Conexion);
            Console.WriteLine(respuesta);
            return Page();
        }
    }
}
