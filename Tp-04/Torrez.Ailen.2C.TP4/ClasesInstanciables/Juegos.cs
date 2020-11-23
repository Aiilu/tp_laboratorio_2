using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public class Juegos : Producto
    {
        //public enum JuegosPS4 { Ghost, Horizon }

        //private JuegosPS4 juegosPS4;

        /*public Juegos(float precio, JuegosPS4 juego) :base(precio, Producto.VarProductos.Juegos)
        {
            this.JuegosDePS4 = juego;
        }*/

        public Juegos(float precio) : base(precio, Producto.VarProductos.Juegos)
        {
            
        }

        /*public JuegosPS4 JuegosDePS4
        {
            get
            {
                return this.juegosPS4;
            }
            set
            {
                this.juegosPS4 = value;
            }
        }*/

        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.MostrarDatos());

            //datos.AppendLine($"Juego: {this.JuegosDePS4}");

            return datos.ToString();
        }
    }
}
