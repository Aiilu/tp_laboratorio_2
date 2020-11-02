using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

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
        /// Propiedad que retorna o setea la lista de Profesor.
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna o setea la lista de Jornadas.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna o setea una Jornada específica a través de un indexador.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                return this.Jornadas[i];
            }
            set
            {
                this.Jornadas[i] = value;
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros que instancia las 3 listas (Alumno, Profesor y Jornada).
        /// </summary>
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo estatico que serializará los datos del Universidad en un XML, 
        /// incluyendo todos los datos de sus Profesores, Alumnos y Jornadas.
        /// </summary>
        /// <param name="uni">Universidad a guardar</param>
        /// <returns>Retorna true si se pudo guardar, caso contrario retorna false</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> universidad = new Xml<Universidad>();

            return universidad.Guardar("Universidad.xml", uni);
        }

        /// <summary>
        /// Metodo estatico que retornará una Universidad con todos los datos previamente serializados.
        /// </summary>
        /// <returns>Retorna true si se puedo leer, caso contrario retorna false</returns>
        public static Universidad Leer()
        {
            Universidad uni = null;
            Xml<Universidad> universidad = new Xml<Universidad>();

            universidad.Leer("Universidad.xml", out uni);

            return uni;
        }

        /// <summary>
        /// Metodo estatico que devuelve los datos de la Universidad.
        /// </summary>
        /// <param name="uni">Universidad a mostrar</param>
        /// <returns>Retorna un string con los datos de la Universidad</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder datosUniversidad = new StringBuilder();

            datosUniversidad.AppendLine("JORNADA: ");

            foreach(Jornada jornada in uni.Jornadas)
            {
                datosUniversidad.AppendLine($"{jornada}");
            }
            
            return datosUniversidad.ToString();
        }

        /// <summary>
        /// Sobreescritura del ToString, el cual hara publicos los datos de la Universidad (el metodo MostrarDatos).
        /// </summary>
        /// <returns>Retorna un string con los datos de la Universidad</returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Una Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario retorna false</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach(Alumno alumno in g.Alumnos)
            {
                if(alumno == a)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Una Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario retorna false</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Una Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="i">Profesor a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario retorna false</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor profesor in g.Instructores)
            {
                if (profesor == i)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Una Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="i">Profesor a comparar</param>
        /// <returns>Retorna true si son iguales, caso contrario retorna false</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Busca al primer Profesor capaz de dar la clase solicitada.
        /// </summary>
        /// <param name="u">Universidad a evaluar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>Retorna al primer Profesor capaz de dar la clase solicitada, si no hay,
		/// lanza una excepción.</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach(Profesor profesor in u.Instructores)
            {
                if(profesor == clase)
                {
                    return profesor;
                }
            }

            throw new SinProfesorException();
        }

        /// <summary>
        /// Busca al primer Profesor que no pueda dar la clase solicitada.
        /// </summary>
        /// <param name="u">Universidad a evaluar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>Retorna al primer Profesor que no pueda dar la clase. Caso contrario retorna null</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor != clase)
                {
                    return profesor;
                }
            }

            return null;
        }

        /// <summary>
        /// Se agrega una Jornada nueva a la Universidad para la clase solicitada.
        /// </summary>
        /// <param name="g">Universidad a la que se agregara la Jornada</param>
        /// <param name="clase">Clase solicitada</param>
        /// <returns>Retorna una Universidad con la Jornada nueva o no</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada jornada = new Jornada(clase, g == clase);

            foreach(Alumno alumno in g.Alumnos)
            {
                if (alumno == clase)
                {
                    jornada += alumno;
                }
            }

            g.Jornadas.Add(jornada);
            return g;
        }

        /// <summary>
        /// Se agrega un Alumno a la Universidad, si este no se encuentra ya agregado.
        /// </summary>
        /// <param name="u">Universidad en la que se agregara el Alumno</param>
        /// <param name="a">Alumno a agregar</param>
        /// <returns>Retorna una Universidad con el Alumno nuevo, en caso de existir lanza una excepcion</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if(u != a)
            {
                u.Alumnos.Add(a);
                return u;
            }

            throw new AlumnoRepetidoException();
        }

        /// <summary>
        /// Se agrega un Profesor a la Universidad, si este no se encuentra ya agregado.
        /// </summary>
        /// <param name="u">Universidad en la que se agregara la Clase</param>
        /// <param name="i">Profesor que se agregara</param>
        /// <returns>Retorna una Universidad con el nuevo Profesor o no</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if(u != i)
            {
                u.Instructores.Add(i);
            }

            return u;
        }

        #endregion
    }
}
