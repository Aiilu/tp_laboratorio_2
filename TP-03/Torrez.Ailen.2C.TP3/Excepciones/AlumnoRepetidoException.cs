using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException :Exception
    {
        /// <summary>
        /// Constructor vacio que asigna un mensaje por defecto.
        /// </summary>
        public AlumnoRepetidoException() : this("Alumno Repetido.")
        {

        }

        /// <summary>
        /// Inicializa llamando a la base con un mensaje personalizado.
        /// </summary>
        /// <param name="message"></param>
        public AlumnoRepetidoException(string message) :base(message)
        {

        }
    }
}
