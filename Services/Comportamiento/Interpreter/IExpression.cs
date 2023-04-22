using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patrones_GOF.Services.Comportamiento.Interpreter
{
    interface IExpression
    {
        public void Interpret(Context context);
    }
}
