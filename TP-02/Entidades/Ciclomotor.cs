using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase derivada de Vehiculo
    /// </summary>
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Inicializa los atributos de Ciclomotor llamando al constructor de la clase base.
        /// </summary>
        /// <param name="marca">Marca con la que se inicializara el atributo</param>
        /// <param name="chasis">Chasis con la que se inicializara el atributo</param>
        /// <param name="color">Color con el que se inicializara el atributo</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// Los Ciclomotores son chicos
        /// Sobrescribe el metodo heredado, el cual retornara el tamaño del Vehiculo
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Chico;
            }
        }

        /// <summary>
        /// Sobrescribe el metodo heredado
        /// </summary>
        /// <returns>Retorna un string con los datos del Vehiculo en cuestion</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
