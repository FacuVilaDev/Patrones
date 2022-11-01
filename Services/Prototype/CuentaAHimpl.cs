namespace Patrones_GOF.Services.Prototype
{
    public class CuentaAHimpl : ICuenta
    {
        private string tipo;
        private double monto;
        public CuentaAHimpl()
        {
            tipo = "AHORRO";
        }

        public object Clone()
        {
            CuentaAHimpl cuenta = null;
            try
            {
                cuenta = (CuentaAHimpl) MemberwiseClone();
            }
            catch (Exception ex)
            {
            }
            return cuenta;
        }

        public string ToString()
        {
            return $"CuentaAHImpl [tipo={tipo}, monto = {monto}]";
        }

        public void setMonto(double monto)
        { this.monto = monto; }
        public double getMonto()
        {
            return monto;
        }
    }
}
