using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public class Libros : Producto
    {
        //public enum LibTerror { Anochecer, IT }

        //private LibTerror libTerror;

        public Libros() : base()
        {

        }

        /*public Libros(float precio, LibTerror terror) : base(precio, Producto.VarProductos.Libros)
        {
            this.LibrosTerror = terror;
        }*/

        public Libros(float precio) : base(precio, Producto.VarProductos.Libros)
        {
    
        }

        /*public LibTerror LibrosTerror
        {
            get
            {
                return this.libTerror;
            }
            set
            {
                this.libTerror = value;
            }
        }*/

        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.MostrarDatos());

            //datos.AppendLine($"Libro: {this.LibrosTerror}");

            return datos.ToString();
        }
    }
}
