using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno :Universitario
    {
        public enum EEstadoCuenta { AlDia, Deudor, Becado }

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Constructores

        /// <summary>
        /// Constructor sin parametros que llama al de la base.
        /// </summary>
        public Alumno() : base()
        {

        }

        /// <summary>
        /// Inicializa los atributos del Alumno.
        /// </summary>
        /// <param name="id">ID con el que se inicializara el atributo</param>
        /// <param name="nombre">Nombre con el que se inicializara el atributo</param>
        /// <param name="apellido">Apellido con el que se inicializara el atributo</param>
        /// <param name="dni">DNI con el que se inicializara el atributo</param>
        /// <param name="nacionalidad">Nacionalidad con la que se inicializara el atributo</param>
        /// <param name="claseQueToma">Clase con la que que se inicializara el atributo</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma, default)
        {

        }

        /// <summary>
        /// Inicializa los atributos del Alumno llamando al constructor de la base.
        /// </summary>
        /// <param name="id">ID con el que se inicializara el atributo</param>
        /// <param name="nombre">Nombre con el que se inicializara el atributo</param>
        /// <param name="apellido">Apellido con el que se inicializara el atributo</param>
        /// <param name="dni">DNI con el que se inicializara el atributo</param>
        /// <param name="nacionalidad">Nacionalidad con la que se inicializara el atributo</param>
        /// <param name="claseQueToma">Clase con la que que se inicializara el atributo</param>
        /// <param name="estadoCuenta">Estado con el que que se inicializara el atributo</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Sobreescritura del metodo heredado que devuelve los datos del Alumno.
        /// </summary>
        /// <returns>Retorna un string con los datos del Alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder datosAlumno = new StringBuilder();

            datosAlumno.AppendLine(base.MostrarDatos());

            if (this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                datosAlumno.AppendLine($"ESTADO DE CUENTA: Cuota al día");
            }
            else
            {
                datosAlumno.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta}");
            }

            datosAlumno.AppendLine(this.ParticiparEnClase());

            return datosAlumno.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo heredado.
        /// </summary>
        /// <returns>Retorna un string con la clase que toma el Alumno</returns>
        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE {this.claseQueToma}";
        }

        /// <summary>
        /// Sobreescritura del ToString, el cual hara publicos los datos del Alumno (el metodo MostrarDatos).
        /// </summary>
        /// <returns>Retorna un string con los datos del Alumno</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
        /// </summary>
        /// <param name="a">Alumno a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>Retorna true si son iguales, sino false</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return (a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase);
        }

        /// <summary>
        /// Un Alumno será distinto a un EClase sólo si no toma esa clase.
        /// </summary>
        /// <param name="a">Alumno a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>Retorna true si son iguales, sino false</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma != clase);
        }     
       
        #endregion
    }
}
