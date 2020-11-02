using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructores

        /// <summary>
        /// Constructor sin parametros que llama al de la base.
        /// </summary>
        public Universitario() : base()
        {

        }

        /// <summary>
        /// Inicializa los atributos de Universitario llamando al constructor de la base
        /// </summary>
        /// <param name="legajo">Legajo con el que se inicializara el atributo</param>
        /// <param name="nombre">Nombre con el que se inicializara el atributo</param>
        /// <param name="apellido">Apellido con el que se inicializara el atributo</param>
        /// <param name="dni">DNI con el que se inicializara el atributo</param>
        /// <param name="nacionalidad">Nacionalidad con el que se inicializara el atributo</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo virtual que devuelve los datos del Universitario
        /// </summary>
        /// <returns>Retorna un string con los datos del Universitario</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder datosUniversitario = new StringBuilder();

            datosUniversitario.AppendLine(base.ToString());
            datosUniversitario.AppendLine($"LEGAJO NÚMERO: {this.legajo}");

            return datosUniversitario.ToString();
        }

        /// <summary>
        /// Metodo abstracto que sera implementado por sus derivadas
        /// </summary>
        /// <returns>Retorna un string</returns>
        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Se fija si el objeto recibido es del mismo tipo que el de la instancia
        /// </summary>
        /// <param name="obj">Objeto a evaluar</param>
        /// <returns>Si son iguales retorna true, caos contrario retorna false</returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        /// <summary>
        /// Compara dos Universitarios, serán iguales si y sólo si son del mismo Tipo 
        /// y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="pg1">Universitario 1 a comparar</param>
        /// <param name="pg2">Universitario 2 a comparar</param>
        /// <returns>Retorna true si los universitarios son iguales, o false si no lo son</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.Dni == pg2.Dni);
        }

        /// <summary>
        /// Dos Universitario serán iguales si y sólo si son del mismo Tipo 
        /// y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="pg1">Universitario 1 a comparar</param>
        /// <param name="pg2">Universitario 2 a comparar</param>
        /// <returns>Retorna true si los universitarios son iguales, o false si no lo son</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion
    }
}
