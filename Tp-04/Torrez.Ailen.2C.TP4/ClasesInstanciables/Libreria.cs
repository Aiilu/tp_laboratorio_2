using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;
using Interfaz;

namespace ClasesInstanciables
{
    public class Libreria :IDAO
    {
        private List<Producto> listaProductos;

        public Libreria()
        {
            this.listaProductos = new List<Producto>();
        }

        public List<Producto> ListaProductos
        {
            get
            {
                return this.listaProductos;
            }
            set
            {
                this.listaProductos = value;
            }
        }

        public void InsertarEnTabla(List<Producto> lista, string datos)
        {
            throw new NotImplementedException();
        }

        public string SelectEnTabla()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            foreach(Producto p in this.ListaProductos)
            {
                datos.AppendLine(p.MostrarDatos());
            }

            return datos.ToString();
        }

    }
}
