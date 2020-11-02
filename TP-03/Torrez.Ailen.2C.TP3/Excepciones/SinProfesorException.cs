using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException :Exception
    {
        /// <summary>
        /// Constructor vacio que asigna un mensaje por defecto.
        /// </summary>
        public SinProfesorException() :this("No hay Profesor para la clase.")
        {

        }

        /// <summary>
        /// Inicializa llamando a la base con un mensaje personalizado.
        /// </summary>
        /// <param name="message"></param>
        public SinProfesorException(string message) :base(message)
        {

        }
    }
}
