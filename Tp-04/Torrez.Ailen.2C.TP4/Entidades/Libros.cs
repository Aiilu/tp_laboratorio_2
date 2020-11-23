using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public  class Libros : Producto
    {
        public enum LibTerror { Anochecer, IT }

        private LibTerror libTerror;

        /// <summary>
        /// Constructor por defecto para realizar la serializacion.
        /// </summary>
        public Libros() : base()
        {
        }

        /// <summary>
        /// Constructor que inicializa los atributos.
        /// </summary>
        /// <param name="precio">Valor con el que se inicializara el precio</param>
        /// <param name="terror">Valor con el que se inicializara los libros de terror</param>
        public Libros(float precio, LibTerror terror) : base(precio, Producto.VarProductos.Libros)
        {
            this.LibrosTerror = terror;
        }

        /// <summary>
        /// Constructor que inicializa los atributos.
        /// </summary>
        /// <param name="precio">Valor con el que inicializara el precio</param>
        public Libros(float precio) : base(precio, Producto.VarProductos.Libros)
        {
    
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo libros de terror.
        /// </summary>
        public LibTerror LibrosTerror
        {
            get
            {
                return this.libTerror;
            }
            set
            {
                this.libTerror = value;
            }
        }

        /// <summary>
        /// Metodo heredado el cual tiene su propia implementacion.
        /// </summary>
        /// <returns>Retorna un string con la informacion de la clase</returns>
        public override string ToString()
        {
            return $"{this.LibrosTerror} ${this.Precio}";
        }
    }
}
