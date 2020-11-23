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

        public Juegos() :base()
        {
        }

        public Juegos(float precio, JuegosPS4 juego) :base(precio, Producto.VarProductos.Juegos)
        {
            this.JuegosDePS4 = juego;
        }

        public Juegos(float precio) : base(precio, Producto.VarProductos.Juegos)
        {
            
        }

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

        public override string ToString()
        {
            return $"{this.JuegosDePS4} ${this.Precio}";
        }
    }
}
