using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patrones_GOF.Services.Comportamiento.Interpreter
{
    public class Context
    {
        private string _nextOp = "";
        private int _operator = 0;
        private int _result = 0;

        public int GetInteger(string input)
        {
            var switchExpr = input.ToLower();
            switch (switchExpr)
            {
                case "cero":
                    return 0;
                case "uno":
                    return 1;
                case "dos":
                    return 2;
                case "tres":
                    return 3;
                case "cuatro":
                    return 4;
                case "cinco":
                    return 5;
                case "seis":
                    return 6;
                case "siete":
                    return 7;
                case "ocho":
                    return 8;
                case "nueve":
                    return 9;
                case "menos":
                    return 45;
                case "mas":
                    return 43;
                case "dividido":
                    return 47;
                case "por":
                    return 42;
                default:
                    throw new Exception("Expresión no reconocida");
            }
        }
        public void SetOperator(int op)
        {
            _operator = op;
        }
        public void SetOperation(string operation)
        {
            if (operation.ToLower().Equals("mas"))
            {
                _nextOp = "+";
            }
            else if (operation.ToLower().Equals("menos"))
            {
                _nextOp = "-";
            }
        }
        public void Calculate()
        {
            if (_nextOp.Equals("+") || _nextOp.Equals(""))
            {
                _result += _operator;
            }
            else if (_nextOp.Equals("-"))
            {
                _result -= _operator;
            }
        }
        public int GetResult()
        {
            return _result;
        }
    }
}
