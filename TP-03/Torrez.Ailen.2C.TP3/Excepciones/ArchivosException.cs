using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException :Exception
    {
        /// <summary>
        /// Constructor vacio que asigna un mensaje por defecto.
        /// </summary>
        public ArchivosException() :this("Archivo Invalido.")
        {

        }

        /// <summary>
        /// Inicializa llamando a la base con un mensaje personalizado.
        /// </summary>
        /// <param name="message"></param>
        public ArchivosException(string message) :base(message)
        {

        }

        /// <summary>
        /// Inicializa llamando a la base con un mensaje por defecto y un innerException.
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException) :base("Archivo Invalido.", innerException)
        {

        }
    }
}
