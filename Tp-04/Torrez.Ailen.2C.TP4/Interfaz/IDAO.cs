using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace Interfaz
{
    public interface IDAO
    {
        void InsertarEnTabla(List<Producto> lista, string datos);

        string SelectEnTabla();
    }
}
