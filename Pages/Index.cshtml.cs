using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
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

        public async Task<IActionResult> OnPostSingleton()
        {
            Conexion c = Conexion.GetConexion();
            c.Conectar();
            c.Desconectar();
            bool respuesta = c.GetType() == typeof(Conexion);
            Console.WriteLine(respuesta);
            return Page();
        }
        public async Task<IActionResult> OnPostFabrica()
        {
            ConexionFabrica fabrica = new ConexionFabrica();
            IConexion cX1 = fabrica.GetConexion("ORACLE");
            cX1.Conectar();
            cX1.Desconectar();
            IConexion cx2 = fabrica.GetConexion("MYSQL");
            cx2.Conectar();
            cx2.Desconectar();
            IConexion cx3 = fabrica.GetConexion("H2");
            cx3.Conectar();
            cx3.Desconectar();
            return Page();
        }
        public async Task<IActionResult> OnPostFabricaAbstracta()
        {
            IFabricaAbstracta fabricaBD = FabricaProductor.GetFactory("BD");
            IConexion cx2 = fabricaBD.GetConexion("MYSQL");
            cx2.Conectar();
            cx2.Desconectar();

            IFabricaAbstracta fabricaREST = FabricaProductor.GetFactory("REST");
            IConexionREST cx3 = fabricaREST.GetREST("COMPRAS");
            cx3.LeerUrl("https://google.com.ar");

            return Page();
        }
    }
}
