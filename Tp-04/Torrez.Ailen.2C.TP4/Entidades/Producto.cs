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

        /// <summary>
        /// Constructor por defecto para realizar la serializacion.
        /// </summary>
        public Producto()
        {

        }

        /// <summary>
        /// Constructor que inicializa los atributos.
        /// </summary>
        /// <param name="precio">Valor con el que se inicializara el precio</param>
        /// <param name="productos">Valor con el que se inicializara el producto</param>
        public Producto(float precio, VarProductos productos)
        {
            this.Precio = precio;
            this.Productos = productos;

        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo producto.
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura del atributo precio.
        /// </summary>
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

        /// <summary>
        /// Metodo abstracto que sera implementado por sus derivadas.
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();
    }
}
