﻿namespace Patrones_GOF.Services.Decorator
{
    public class CafeExpreso : BebidaComponent
    {
        public override double Costo => 12;
        public override string Descripcion => "Café expreso";
    }
}
