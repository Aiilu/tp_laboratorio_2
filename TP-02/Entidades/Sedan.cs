using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    /// <summary>
    /// Clase derivada de Vehiculo
    /// </summary>
    public class Sedan : Vehiculo
    {
        public enum ETipo 
        { 
            CuatroPuertas, CincoPuertas
        }

        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas.
        /// Inicializa los atributos de Sedan reutilizando un constructor
        /// </summary>
        /// <param name="marca">Marca con la que se inicializara el atributo</param>
        /// <param name="chasis">Chasis con la que se inicializara el atributo</param>
        /// <param name="color">Color con el que se inicializara el atributo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)  : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }

        /// <summary>
        /// Inicializa los atributos de Sedan llamando al constructor de la base
        /// </summary>
        /// <param name="marca">Marca con la que se inicializara el atributo</param>
        /// <param name="chasis">Chasis con la que se inicializara el atributo</param>
        /// <param name="color">Color con el que se inicializara el atributo</param>
        /// <param name="tipo">Tipo con el que se inicializara el atributo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Los Sedan son medianos
        /// Sobrescribe el metodo heredado, el cual retornara el tamaño del Vehiculo
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Sobrescribe el metodo heredado
        /// </summary>
        /// <returns>Retorna un string con los datos del Vehiculo en cuestion</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine($"TIPO : {this.tipo}");
            //sb.AppendLine(" TIPO: " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
