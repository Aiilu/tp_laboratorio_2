using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException :Exception
    {
        //Todas las excepciones deberán tener mensajes propios: que tengan al menos un constructor que
        //reciba mensaje y que tengan un constructor sin parámetros que asigne un mensaje por defecto.
        public AlumnoRepetidoException() : this("Alumno Repetido.")
        {

        }

        public AlumnoRepetidoException(string message) :base(message)
        {

        }
    }
}
