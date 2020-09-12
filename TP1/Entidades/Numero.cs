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
        /// Inicializa un numero
        /// </summary>
        /// <param name="numero"></param>
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
        /// 
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero; //asignando
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steNumero"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
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
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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

            if (string.IsNullOrEmpty(binario))
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
