using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores

        /// <summary>
        /// Constructor sin parametros que llama al de la base.
        /// </summary>
        public Profesor() : base()
        {

        }

        /// <summary>
        /// Constructor estatico que instancia el atributo Random.
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Inicializa los atributos del Profesor llamando al constructor de la base.
        /// </summary>
        /// <param name="id">ID con el que se inicializara el atributo</param>
        /// <param name="nombre">Nombre con el que se inicializara el atributo</param>
        /// <param name="apellido">Apellido con el que se inicializara el atributo</param>
        /// <param name="dni">DNI con el que se inicializara el atributo</param>
        /// <param name="nacionalidad">Nacionalidad con el que se inicializara el atributo</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Asignara dos clases al azar al Profesor. Las dos pueden o no ser la misma.
        /// </summary>
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            Thread.Sleep(100);
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
        }

        /// <summary>
        /// Sobreescritura del metodo heredado que devuelve los datos del Profesor.
        /// </summary>
        /// <returns>Retorna un string con los datos del Profesor</returns>
        protected override string MostrarDatos()
        {
            StringBuilder datosProfesor = new StringBuilder();

            datosProfesor.AppendLine(base.MostrarDatos());

            datosProfesor.AppendLine(this.ParticiparEnClase());

            return datosProfesor.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo heredado.
        /// </summary>
        /// <returns>Retorna un string con las Clases del dia</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder clases = new StringBuilder();

            clases.AppendLine("CLASES DEL DÍA: ");

            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                clases.AppendLine($"{clase}");
            }

            return clases.ToString();
        }

        /// <summary>
        /// Sobreescritura del ToString, el cual hara publicos los datos del Profesor (el metodo MostrarDatos).
        /// </summary>
        /// <returns>Retorna un string con los datos del Profesor</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Un Profesor será igual a un EClase si da esa clase.
        /// </summary>
        /// <param name="i">Profesor a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario retorna false</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases c in i.clasesDelDia)
            {
                if (c == clase)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Un Profesor será igual a un EClase si da esa clase.
        /// </summary>
        /// <param name="i">Profesor a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario retorna false</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion
    }
}
