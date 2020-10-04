using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        private string chasis;
        private ConsoleColor color;
        private EMarca marca;

        /// <summary>
        /// Inicializa los atributos de Vehiculo.
        /// </summary>
        /// <param name="chasis">Chasis con la que se inicializara el atributo</param>
        /// <param name="marca">Marca con la que se inicializara el atributo</param>
        /// <param name="color">Color con el que se inicializara el atributo</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño del Vehiculo
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo utilizando la funcion explicita que devuelve un string.
        /// </summary>
        /// <returns>Retorna los datos del Vehiculo</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Conversion explicita de Vehiculo a string. 
        /// </summary>
        /// <param name="p">Variable del tipo Vehiculo a mostrar</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}\r\n");
            sb.AppendLine($"MARCA : {p.marca}\r\n");
            sb.AppendLine($"COLOR : {p.color}\r\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Vehiculo Uno</param>
        /// <param name="v2">Vehiculo Dos</param>
        /// <returns>Retorna un booleano que indica si los vehiculos son iguales o distintos</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Vehiculo Uno</param>
        /// <param name="v2">Vehiculo Dos</param>
        /// <returns>Retorna un booleano que indica si los vehiculos son iguales o distintos</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
