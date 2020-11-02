using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException :Exception
    {
        /// <summary>
        /// Constructor vacio que asigna un mensaje por defecto.
        /// </summary>
        public DniInvalidoException() :this("DNI Invalido")
        {

        }

        /// <summary>
        /// Constructor que asigna un mensaje por defecto y un innerException.
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e) :this("DNI Invalido", e)
        {

        }

        /// <summary>
        /// Inicializa llamando a la base con un mensaje personalizado.
        /// </summary>
        /// <param name="message"></param>
        public DniInvalidoException(string message) :base(message)
        {

        }

        /// <summary>
        /// Inicializa llamando a la base con un mensaje personalizado y un innerException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string message, Exception e) :base(message, e)
        {

        }
    }
}
