using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region Propiedades

        /// <summary>
        /// Propiedad que retorna o setea la lista de Alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna o setea la Clase.
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna o setea al Profesor.
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros que instancia la lista de Alumnos.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Inicializa los atributos de Jornada.
        /// </summary>
        /// <param name="clase">Clase con la que se inicializara el atributo</param>
        /// <param name="instructor">Profesor con el que se inicializara el atributo</param>
        public Jornada(Universidad.EClases clase, Profesor instructor) :this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo estatico que guardará los datos de la Jornada en un archivo de texto. 
        /// </summary>
        /// <param name="jornada">Jornada a guardar</param>
        /// <returns>Retorna true si logro guardar, caso contrario retorna false</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto text = new Texto();

            return text.Guardar("Jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Metodo estatico que lee un archivo de texto con la información de una Jornada y la guarda.
        /// </summary>
        /// <returns>Retorna un string con los datos de la Jornada como texto.</returns>
        public static string Leer()
        {
            string resultado;

            Texto text = new Texto();

            text.Leer("Jornada.txt", out resultado);

            return resultado;
        }

        /// <summary>
        /// Sobreescritura del ToString, el cual devuelve los datos de la Jornada.
        /// </summary>
        /// <returns>Retorna un string con todos los datos de la Jornada</returns>
        public override string ToString()
        {
            StringBuilder datosJornada = new StringBuilder();

            datosJornada.AppendLine($"CLASE DE {this.Clase} POR {this.Instructor}");
            datosJornada.AppendLine("ALUMNOS: ");

            foreach (Alumno alumno in this.alumnos)
            {
                datosJornada.AppendLine($"{alumno}");
            }

            datosJornada.AppendLine("<------------------------------------------------>");

            return datosJornada.ToString();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j">Jornado a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario retorna false</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach(Alumno alumno in j.alumnos)
            {
                if(alumno == a)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j">Jornado a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario retorna false</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega Alumnos a la Jornada, validando previamente que no esten cargados.
        /// </summary>
        /// <param name="j">Jornado a la cual se le agregara un Alumno</param>
        /// <param name="a">Alumno que se quiere agregar</param>
        /// <returns>Retorna la Jornada</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

        #endregion
    }
}
