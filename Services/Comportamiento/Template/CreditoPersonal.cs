namespace Patrones_GOF.Services.Comportamiento.Template
{
    public class CreditoPersonal : Credito
    {
        public CreditoPersonal(Cliente c) : base(c)
        {
            Verificar();
        }

        protected override string VerificarAcciones()
        {
            return $"Verificando acciones del cliente {_cliente.ToString()} para un préstamo Personal";
        }

        protected override string VerificarBalance()
        {
            return $"Verificando balance del cliente {_cliente.ToString()} para un préstamo Personal";
        }

        protected override string VerificarCreditos()
        {
            return $"Verificando otros créditos del cliente {_cliente.ToString()}  para un préstamo Personal";
        }

        protected override string VerificarIngresos()
        {
            return $"Verificando ingresos del cliente {_cliente.ToString()}  para un préstamo Personal";
        }
    }
}
