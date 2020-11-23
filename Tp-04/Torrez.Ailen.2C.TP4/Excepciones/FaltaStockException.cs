using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FaltaStockException :Exception
    {
        /// <summary>
        /// Constructor que inicializa los atributos de la Excepcion.
        /// </summary>
        /// <param name="mensaje">Valor que inicializara al mensaje, el cual es pasado a la clase base</param>
        public FaltaStockException(string mensaje) : base(mensaje)
        {

        }


    }
}
