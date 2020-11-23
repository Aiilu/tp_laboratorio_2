using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public interface IDAO
    {
        /// <summary>
        /// Metodo a implementar, ofrece la firma para que quien la implemente le de su uso.
        /// </summary>
        /// <param name="nombre">Nombre que se le pasa por parametro</param>
        /// <param name="dni">DNI que se le pasa por parametro</param>
        /// <param name="datos">Datos que se le pasan por parametro</param>
        void InsertarEnTabla(string nombre, int dni, string datos);

        /// <summary>
        /// Metodo a implementar, ofrece la firma para que quien la implemente le de su uso.
        /// </summary>
        /// <param name="nombre">Nombre que se le pasa por parametro</param>
        /// <param name="dni">DNI que se le pasa por parametro</param>
        /// <returns></returns>
        string LeerTabla(string nombre, int dni);
    }
}
