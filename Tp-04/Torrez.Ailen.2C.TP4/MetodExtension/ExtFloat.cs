using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Globalization;

namespace MetodExtension
{
    public static class ExtFloat
    {
        /// <summary>
        /// Metodo de extension, se encarga de formatear el precio con el signo $ y decimales.
        /// </summary>
        /// <param name="num">Numero con el que trabajara</param>
        /// <returns></returns>
        public static string Mostrar(this float num)
        {
            return num.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
