using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException :Exception
    {
        /// <summary>
        /// Constructor vacio que asigna un mensaje por defecto.
        /// </summary>
        public NacionalidadInvalidaException() : this("La nacionalidad no se condice con el número de DNI")
        {

        }

        /// <summary>
        /// Inicializa llamando a la base con un mensaje personalizado.
        /// </summary>
        /// <param name="message"></param>
        public NacionalidadInvalidaException(string message) :base(message)
        {

        }
    }
}
