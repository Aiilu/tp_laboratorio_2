using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {/// <summary>
     /// Valida que el operador ingresado sea un +, -, / o *.
     /// </summary>
     /// <param name="operador">Char con la operacion a validar</param>
     /// <returns>Retorna string con la operacion validada, previamente pasada de char a string</returns>
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return Char.ToString(operador);
            }
            else
            {
                return "+";
            }
        }

        /// <summary>
        /// Valida la operacion y devuelve su resultado
        /// </summary>
        /// <param name="num1">Primer numero de la operacion del tipo Numero</param>
        /// <param name="num2">Segundo numero de la operacion del tipo Numero</param>
        /// <param name="operador">String con la operacion a realizar, previamente pasado a Char</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char operador2 = ' ';
            double resultado = 0;

            char.TryParse(operador, out operador2);

            switch (ValidarOperador(operador2))
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }

            return resultado;
        }
    }
}
