using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Inicializa un numero pasado por parametro
        /// </summary>
        /// <param name="numero">Valor con el que se inicializa, es pasado a string para poder reutilizar codigo de otro constructor</param>
        public Numero(double numero) : this(numero.ToString())
        {

        }

        /// <summary>
        /// Inicializa el numero a 0 reutilizando otro constructor
        /// </summary>
        public Numero() : this("0")
        {

        }

        /// <summary>
        /// Inicializa un string pasado por parametro y llama al Set Numero
        /// </summary>
        /// <param name="strNumero">Valor con el que inicializa</param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero; //asignando
        }

        /// <summary>
        /// Realiza la operacion en cuestion para poder validar los numeros que van a ingresar 
        /// </summary>
        /// <param name="steNumero">String que se validara</param>
        /// <returns>Retorna un numero validado o 0</returns>
        private double ValidarNumero(string steNumero)
        {
            double result;

            if (double.TryParse(steNumero, out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Setea el atributo con el nuevo valor, este previamente pasa por ValidarNumero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Suma dos objetos del tipo Numero
        /// </summary>
        /// <param name="n1">Primer numero a sumar</param>
        /// <param name="n2">Segundo numero a sumar</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Resta dos objetos del tipo Numero
        /// </summary>
        /// <param name="n1">El minuendo</param>
        /// <param name="n2">El sustraendo</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Divide dos objetos del tipo Numero.
        /// </summary>
        /// <param name="n1">El divididendo</param>
        /// <param name="n2">El divisor</param>
        /// <returns>Retorna el resultado de la operacion, en caso de dividir por 0, retorna MinValue</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            else
            {
                return double.MinValue;
            }
        }

        /// <summary>
        /// Multiplica dos objetos del tipo Numero
        /// </summary>
        /// <param name="n1">Primer numero a multipllicar</param>
        /// <param name="n2">Segundo numero a multiplicar</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Llama al EsBinario que valida la cadena. Si la cadena es valida convierte el numero a decimal.
        /// En caso contrario retornara un mensaje de error
        /// </summary>
        /// <param name="binario">Texto a convertir a decimal</param>
        /// <returns>Retorna el resultado de la operacion o un mensaje de error</returns>
        public static string BinarioDecimal(string binario)
        {

            if (!EsBinario(binario))
            {
                return "Valor inválido";
            }

            double decimal1 = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    decimal1 += Math.Pow(2, binario.Length - (i + 1));
                }
            }

            return decimal1.ToString();
        }

        /// <summary>
        /// Recibe un numero decimal y lo convierte a binario
        /// </summary>
        /// <param name="numero">Numero que va a pasar a binario</param>
        /// <returns>Retorna el resultado de la operacion (numero binario)</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            int entero = (int)numero;

            while (entero > 0)
            {
                binario = (entero % 2) + binario;

                entero /= 2;
            }

            return binario;
        }

        /// <summary>
        /// Valida que la cadena ingresada sea un numero entero y positivo
        /// </summary>
        /// <param name="numero">Cadena a validar</param>
        /// <returns>Retorna el resultado de la operacion o un mensaje de error</returns>
        public static string DecimalBinario(string numero)
        {
            if (numero == "0")
            {
                return numero;
            }

            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] == ',' || numero[i] == '-' || numero[i] == '.')
                {
                    return "Valor inválido";
                }
            }

            return DecimalBinario(Convert.ToDouble(numero));
        }

        /// <summary>
        /// Valida que la cadena recibida sea un binario. 
        /// </summary>
        /// <param name="binario">Cadena a validar</param>
        /// <returns>En caso de ser un binario retorna True, sino retorna False</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }

            return retorno;
        }
    }
}
