using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Producto
    {
        public enum VarProductos { Libros, Juegos }

        private float precio;
        private VarProductos productos;
        
        public Producto()
        {

        }

        public Producto(float precio, VarProductos productos)
        {
            this.Precio = precio;
            this.Productos = productos;

        }

        public VarProductos Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Tipo de Producto: {this.Productos}");
            datos.AppendLine($"Precio: {this.Precio}");

            return datos.ToString();
        }
    }
}
