using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public interface IDAO
    {
        void InsertarEnTabla(string nombre, int dni, string datos);

        string LeerTabla(string nombre, int dni);
    }
}
