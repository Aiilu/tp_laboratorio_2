using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Libros)), XmlInclude(typeof(Juegos))]
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

        public abstract override string ToString();
    }
}
