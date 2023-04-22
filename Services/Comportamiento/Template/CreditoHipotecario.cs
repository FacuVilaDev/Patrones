namespace Patrones_GOF.Services.Comportamiento.Template
{
    public class CreditoHipotecario : Credito
    {
        public CreditoHipotecario(Cliente c) : base(c)
        {
            Verificar();
        }

        protected override string VerificarAcciones()
        {
            return  $"Verificando acciones del cliente {_cliente.ToString()} para un préstamo Hipotecario";
        }

        protected override string VerificarBalance()
        {
            return  $"Verificando balance del cliente {_cliente.ToString()} para un préstamo Hipotecario";
        }

        protected override string VerificarCreditos()
        {
            return  $"Verificando otros créditos del cliente {_cliente.ToString()}  para un préstamo Hipotecario";
        }

        protected override string VerificarIngresos()
        {
            return  $"Verificando ingresos del cliente {_cliente.ToString()}  para un préstamo Hipotecario";
        }
    }
}
