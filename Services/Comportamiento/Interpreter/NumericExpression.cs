using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patrones_GOF.Services.Comportamiento.Interpreter
{
    public class NumericExpression: IExpression
    {
        private string _value;

        public NumericExpression(string token)
        {
            _value = token;
        }

        public void Interpret(Context context)
        {
            context.SetOperator(context.GetInteger(_value));
            context.Calculate();

        }

    }
}
