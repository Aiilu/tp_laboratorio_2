using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public  class Juegos : Producto
    {
        public enum JuegosPS4 { Ghost, Horizon }

        private JuegosPS4 juegosPS4;

        /// <summary>
        /// Constructor por defecto para realizar la serializacion.
        /// </summary>
        public Juegos() :base()
        {
        }

        /// <summary>
        /// Constructor que inicializa los atributos.
        /// </summary>
        /// <param name="precio">Valor con el que se inicializara el precio</param>
        /// <param name="juego">Valor con el que se inicializara los juegos de PS4</param>
        public Juegos(float precio, JuegosPS4 juego) :base(precio, Producto.VarProductos.Juegos)
        {
            this.JuegosDePS4 = juego;
        }

        /// <summary>
        /// Constructor que inicializa los atributos.
        /// </summary>
        /// <param name="precio">Valor con el que inicializara el precio</param>
        public Juegos(float precio) : base(precio, Producto.VarProductos.Juegos)
        {
            
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo juegosPS4.
        /// </summary>
        public JuegosPS4 JuegosDePS4
        {
            get
            {
                return this.juegosPS4;
            }
            set
            {
                this.juegosPS4 = value;
            }
        }

        /// <summary>
        /// Metodo heredado el cual tiene su propia implementacion.
        /// </summary>
        /// <returns>Retorna un string con la informacion de la clase</returns>
        public override string ToString()
        {
            return $"{this.JuegosDePS4} ${this.Precio}";
        }
    }
}
