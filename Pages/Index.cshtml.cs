﻿

using Patrones_GOF.Services.Estructurales.Builder;

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
            return new OkObjectResult(respuesta);
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
        public async Task<IActionResult> OnPostPrototype()
        {
            CuentaAHimpl cuentaAhorro = new CuentaAHimpl();
            cuentaAhorro.setMonto(200);
            CuentaAHimpl cuentaClonada = (CuentaAHimpl)cuentaAhorro.Clone();

            string response = "";
            if (cuentaClonada != null)
                response += $"{cuentaClonada.ToString()}\n";
            response += $"{cuentaClonada == cuentaAhorro}\n";

            return new OkObjectResult(response);
        }

        public async Task<IActionResult> OnPostAdapter()
        {
            Motor motor1 = new MotorNaftero();
            motor1.Arrancar();
            motor1.Acelerar();
            motor1.Detener();
            motor1.CargarCombustible();

            Motor motor2 = new MotorElectricoAdapter();
            motor2.Arrancar();
            motor2.Acelerar();
            motor2.Detener();
            motor2.CargarCombustible();

            Motor motor3 = new MotorDiesel();
            motor3.Arrancar();
            motor3.Acelerar();
            motor3.Detener();
            motor3.CargarCombustible();

            return Page();
        }

        public async Task<IActionResult> OnPostDecorator()
        {
            BebidaComponent cafe = new CafeSolo();
            cafe = new Leche(cafe);
            cafe = new Azucar(cafe);

            Console.WriteLine();

            string response = $"Producto: {cafe.Descripcion} tiene un costo de : ${cafe.Costo}";


            return new OkObjectResult(response);
        }

        public async Task<IActionResult> OnPostComposite()
        {
            Component root = new Directorio("raiz");

            Component archivo1 = new Archivo("archivo1.txt", 10);
            Component archivo2 = new Archivo("archivo2.txt", 30);
            Component archivo3 = new Archivo("archivo3.txt", 120);
            Component archivo4 = new Archivo("archivo4.txt", 800);
            Component archivo5 = new Archivo("archivo5.txt", 340);

            Component dir1 = new Directorio("dir1");
            Component dir2 = new Directorio("dir2");
            Component dir3 = new Directorio("dir3");

            dir1.AgregarHijo(archivo1);
            dir2.AgregarHijo(archivo2);
            dir3.AgregarHijo(archivo3);
            dir3.AgregarHijo(archivo4);
            dir1.AgregarHijo(dir3);

            root.AgregarHijo(dir1);
            root.AgregarHijo(dir2);
            root.AgregarHijo(archivo5);

            string response = $"El tamaño del directorio {root.Nombre} es {root.ObtenerTamaño}.\n";
            response += $"El tamaño del directorio {dir1.Nombre} es {dir1.ObtenerTamaño}.\n";
            response += $"El tamaño del directorio {dir2.Nombre} es {dir2.ObtenerTamaño}.\n";
            response += $"El tamaño del directorio {dir3.Nombre} es {dir3.ObtenerTamaño}.\n";

            return new OkObjectResult(response);
        }
        public async Task<IActionResult> OnPostObserver()
        {
            Producto productoA = new Producto("Guitarra",10);
            Producto productoB = new Producto("Piano",20);
            Producto productoC = new Producto("Bateria",30);
            Producto productoD = new Producto("Bajo", 40);

            Usuario messi = new Usuario("Lionel", "Messi");
            Usuario maradona = new Usuario("Diego", "Maradona");
            Usuario dimaria = new Usuario("Angel", "DiMaria");

            productoA.Agregar(messi);
            productoB.Agregar(messi);

            productoA.Precio = 14;
            productoB.Precio = 13;
            productoC.Precio = 13;
            productoD.Precio = 13;

            productoB.Agregar(maradona);

            productoB.Precio = 12;

            productoA.Agregar(dimaria);
            productoB.Agregar(dimaria);
            productoC.Agregar(dimaria);
            productoD.Agregar(dimaria);

            productoD.Precio = 13;

            productoD.Quitar(dimaria);

            productoD.Precio = 11;

            return Page();
        }

        public async Task<IActionResult> OnPostBuilder()
        {
            PizzaItalianaBuilder italianaBuilder = new();  
            PizzaMuzzaBuilder muzzaBuilder= new();  
            PizzaLightBuilder lightBuilder= new();

            Pizza pizaMuzza = muzzaBuilder.BuildPizza();
            Pizza pizaLight = lightBuilder.BuildPizza();
            Pizza pizaItaliana = italianaBuilder.BuildPizza();

            string response = $"Producto: {pizaMuzza}\n";
            response += $"Producto: {pizaLight}\n";
            response += $"Producto: {pizaItaliana}\n";


            return new OkObjectResult(response);
        }
    }
}
