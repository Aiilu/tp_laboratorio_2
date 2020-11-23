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

        public Libros() : base()
        {
        }

        public Libros(float precio, LibTerror terror) : base(precio, Producto.VarProductos.Libros)
        {
            this.LibrosTerror = terror;
        }

        public Libros(float precio) : base(precio, Producto.VarProductos.Libros)
        {
    
        }

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

        public override string ToString()
        {
            return $"{this.LibrosTerror} ${this.Precio}";
        }
    }
}
