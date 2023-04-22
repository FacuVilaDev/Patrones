using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patrones_GOF.Services.Comportamiento.Interpreter
{
    public class OperatorExpression : IExpression
    {
        private string _operation;

        public OperatorExpression(string token)
        {
            _operation = token;
        }
        public void Interpret(Context context)
        {
            context.SetOperation(_operation);
        }
    }
}
