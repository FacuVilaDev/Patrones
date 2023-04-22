

using Patrones_GOF.Services.Comportamiento.Bridge;
using Patrones_GOF.Services.Comportamiento.Chain_of_Responsability;
using Patrones_GOF.Services.Comportamiento.Command;
using Patrones_GOF.Services.Comportamiento.Memento;
using Patrones_GOF.Services.Comportamiento.Interpreter;
using Patrones_GOF.Services.Comportamiento.Visitor;
using Patrones_GOF.Services.Estructurales.Builder;
using Patrones_GOF.Services.Estructurales.Facade;
using Patrones_GOF.Services.Estructurales.Proxy;
using Patrones_GOF.Services.Comportamiento.Template;
using Patrones_GOF.Services.Comportamiento.Mediator;
using Patrones_GOF.Services.Comportamiento.Iterator;
using System.Runtime.CompilerServices;
using Patrones_GOF.Services.Comportamiento.State;

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
            Producto productoA = new Producto("Guitarra", 10);
            Producto productoB = new Producto("Piano", 20);
            Producto productoC = new Producto("Bateria", 30);
            Producto productoD = new Producto("Bajo", 40);

            Services.Comportamiento.Observer.Usuario messi = new Services.Comportamiento.Observer.Usuario("Lionel", "Messi");
            Services.Comportamiento.Observer.Usuario maradona = new Services.Comportamiento.Observer.Usuario("Diego", "Maradona");
            Services.Comportamiento.Observer.Usuario dimaria = new Services.Comportamiento.Observer.Usuario("Angel", "DiMaria");

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
            PizzaMuzzaBuilder muzzaBuilder = new();
            PizzaLightBuilder lightBuilder = new();

            Pizza pizaMuzza = muzzaBuilder.BuildPizza();
            Pizza pizaLight = lightBuilder.BuildPizza();
            Pizza pizaItaliana = italianaBuilder.BuildPizza();

            string response = $"Producto: {pizaMuzza}\n";
            response += $"Producto: {pizaLight}\n";
            response += $"Producto: {pizaItaliana}\n";


            return new OkObjectResult(response);
        }
        public async Task<IActionResult> OnPostProxy()
        {
            IRepository repo = new CustomerRepositoryProxy();

            Session.CanSave = true;
            Session.CanGetAll = true;

            Customer p1 = new Customer("Customer 1");
            Customer p2 = new Customer("Customer 2");


            repo.Save(p1);
            repo.Save(p2);

            string response = "";
            foreach (var p in repo.GetAll())
            {
                response += p.Name + "\n";
            }

            return new OkObjectResult(response);
        }
        public async Task<IActionResult> OnPostFacade()
        {
            var shapemaker = new ShapeMaker();
            shapemaker.DrawCircle();
            shapemaker.DrawRectangle();
            shapemaker.DrawSquare();
            return Page();
        }
        static CareTaker caretaker = new CareTaker();
        public async Task<IActionResult> OnPostMemento()
        {
            var p = new Persona();
            p.Nombre = "Pepe";
            caretaker.Add(p.saveToMemento());

            p.Nombre = "Pepe1";
            caretaker.Add(p.saveToMemento());

            p.Nombre = "Pepe2";
            caretaker.Add(p.saveToMemento());

            Memento m1 = caretaker.GetMemento(0);
            Memento m2 = caretaker.GetMemento(1);
            Memento m3 = caretaker.GetMemento(2);

            Console.WriteLine("Viendo memento 1:" + m1.Estado);
            Console.WriteLine("Viendo memento 2:" + m2.Estado);
            Console.WriteLine("Viendo memento 3:" + m3.Estado);
            p.restoreToMemento(m1);
            return Page();
        }
        public async Task<IActionResult> OnPostChainOfResponsability()
        {
            var comprador = new Comprador();
            var gerente = new GerenteZonal();
            var director = new Director();

            gerente.AgregarSiguiente(director);
            comprador.AgregarSiguiente(gerente);

            var c = new Compra();
            double importe = 1;
            while (importe != 0)
            {
                c.Importe = importe;
                comprador.Procesar(c);
                importe++;
            }

            return Page();
        }
        public async Task<IActionResult> OnPostBridge()
        {
            // Creamos una forma y la dibujamos en diferentes colores
            IForma cuadradoRojo = new Cuadrado(new ColorRojo());
            cuadradoRojo.Dibujar();

            IForma circuloRojo = new Circulo(new ColorRojo());
            circuloRojo.Dibujar();
            return Page();
        }
        public async Task<IActionResult> OnPostCommand()
        {
            var empresa = new EmpresaInvoker();
            var producto = new ProductoReceiver();
            producto.Cantidad = 100;

            var ordenAlta = new AltaStockCommand(producto, 10);
            empresa.TomarOrden(ordenAlta);
            var ordenBaja = new BajaStockCommand(producto, 50);
            empresa.TomarOrden(ordenBaja);

            empresa.ProcesarOrdenes();

            Console.Write(string.Format("Total stock es {0}", producto.Cantidad));
            return Page();
        }
        public async Task<IActionResult> OnPostVisitor()
        {
            IVisitor visitante = new VisitanteConcreto();

            Componente dr = new DiscoRigido("ASDASD");
            Componente pb = new PlacaBase("FFFFFFFGGGGG");
            Componente p = new Procesador("AAAAABBBBBB");

            dr.Aceptar(visitante);
            pb.Aceptar(visitante);
            p.Aceptar(visitante);

            return Page();
        }
        public async Task<IActionResult> OnPostInterpreter()
        {
            string[] tree;
            var context = new Context();
            var expressions = new List<IExpression>();
            string val = "ocho menos siete";
            tree = val.Split(' ');
            IExpression exp;
            foreach (var t in tree)
            {
                if (context.GetInteger(t) < 9)
                    exp = new NumericExpression(t);
                else
                    exp = new OperatorExpression(t);
                exp.Interpret(context);
            }
            var respuesta = $"El resultado para {val} es {context.GetResult()}";
            Console.WriteLine(respuesta);
            return Page();
        }
        public async Task<IActionResult> OnPostTemplate()
        {

            var clienteA = new Cliente("Roberto Gómez");
            var clienteB = new Cliente("Marta Sánchez");

            var personal = "Personal";
            var hipotecario = "Hipotecario";

            Credito cH= new CreditoHipotecario(clienteA);
            Credito cP= new CreditoHipotecario(clienteB);


            return Page();
        }
        public async Task<IActionResult> OnPostMediator()
        {
            var chat = new ChatRoom();
            var u1 = new Usuario1("usuario 1");
            var u2 = new Usuario1("usuario 2");

            chat.Registrar(u1);
            chat.Registrar(u2);

            chat.Enviar("Hola, todo bien?", u2, u1);
            chat.Enviar("Bien y vos?", u1, u2);


            return Page();
        }
        public async Task<IActionResult> OnPostIterator()
        {
            Collection collection = new ConcreteCollection();
            IteratorEjemplo iterator = collection.CreateIterator();
           
            //Agregar
            var newItem = new Item("Soda");
            collection.Agregar(newItem);
            var newItem2 = new Item("Azucar");
            collection.Agregar(newItem2);
            var newItem3 = new Item("Limón");
            collection.Agregar(newItem3);
            var newItem4 = new Item("Vodka");
            collection.Agregar(newItem4);

            //Listar
            iterator.First();
            Item i = iterator.CurrentItem();

            var listado = new List<Item>();

            if (i != null)
                listado.Add(i);
            while (!iterator.IsDone())
            {
                iterator.Siguiente();
                listado.Add(iterator.CurrentItem());
            }

            //Primero
            iterator.First();
            var primero = iterator.CurrentItem();

            //Siguiente
            Item siguiente;
            if(iterator.IsDone() == false)
            {
                iterator.Siguiente();
                siguiente = iterator.CurrentItem();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostState()
        {
            var _switch = new Switch();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();

            return Page();
        }
    }
}
