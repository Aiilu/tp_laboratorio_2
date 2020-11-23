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
        public static string Mostrar(this float num)
        {
            return num.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
