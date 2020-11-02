using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero }

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #region Propiedades

        /// <summary>
        /// Propiedad que retorna o setea el apellido.
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad que retorna o setea el DNI.
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
            }
        }

        /// <summary>
        /// Propiedad que retorna o setea la nacionalidad.
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna o setea el nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad que setea el DNI en formato string.
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros.
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Inicializa los atributos de Persona con los datos pasados por parametro.
        /// </summary>
        /// <param name="nombre">Nombre con el que se inicializara el atributo</param>
        /// <param name="apellido">Apellido con el que se inicializara el atributo</param>
        /// <param name="nacionalidad">Nacionalidad con la que se inicializara el atributo</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Inicializa los atributos de Persona con los datos pasados por parametro.
        /// </summary>
        /// <param name="nombre">Nombre con el que se inicializara el atributo</param>
        /// <param name="apellido">Apellido con el que se inicializara el atributo</param>
        /// <param name="dni">DNI con el que se inicializara el atributo</param>
        /// <param name="nacionalidad">Nacionalidad con la que se inicializara el atributo</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.Dni = dni;
        }

        /// <summary>
        /// Inicializa los atributos de Persona con los datos pasados por parametro.
        /// </summary>
        /// <param name="nombre">Nombre con el que se inicializara el atributo</param>
        /// <param name="apellido">Apellido con el que se inicializara el atributo</param>
        /// <param name="dni">DNI con el que se inicializara el atributo</param>
        /// <param name="nacionalidad">Nacionalidad con la que se inicializara el atributo</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Sobreescritura del metodo virtual ToString para retonar datos de la persona.
        /// </summary>
        /// <returns>Retorna un string con los datos de la Persona</returns>
        public override string ToString()
        {
            StringBuilder datosPersona = new StringBuilder();

            datosPersona.AppendLine($"NOMBRE COMPLETO: {this.Apellido}, {this.Nombre}");
            datosPersona.AppendLine($"NACIONALIDAD: {this.Nacionalidad}");

            return datosPersona.ToString();
        }

        #endregion

        #region Validaciones

        /// <summary>
        /// Valida que el dato se encuentre entre los valores requeridos.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la Persona</param>
        /// <param name="dato">Dato a validar (DNI)</param>
        /// <returns>Si cumple las condiciones retorna el dni pasado por parametro, caso contrario se lanza una excepcion</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad is ENacionalidad.Argentino)
            {
                if (dato >= 1 && dato <= 89999999)
                {
                    return dato;
                }
            }
            else
            {
                if (dato >= 90000000 && dato <= 99999999)
                {
                    return dato;
                }
            }

            throw new NacionalidadInvalidaException();
        }

        /// <summary>
        /// Valida que el dato sea valido (que no presente errores de formato).
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">Dato a validar (DNI)</param>
        /// <returns>Si cumple las condiciones retorna el dni pasado por parametro, caso contrario se lanza una excepcion</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if (nacionalidad is ENacionalidad.Argentino)
            {
                if (dato.Length >= 1 && dato.Length <= 8)
                {
                    if (int.TryParse(dato, out dni))
                    {
                        return this.ValidarDni(nacionalidad, dni);
                    }
                }
            }
            else
            {
                if (dato.Length == 8)
                {
                    if (int.TryParse(dato, out dni))
                    {
                        return this.ValidarDni(nacionalidad, dni);
                    }
                }
            }

            throw new DniInvalidoException();
        }

        /// <summary>
        /// Valida que la cadena pasada contenga caracteres válidos
        /// </summary>
        /// <param name="dato">Dato a validar</param>
        /// <returns>En caso de ser valido retorna el dato, caso contrario retorna null</returns>
        private string ValidarNombreApellido(string dato)
        {
            if (dato.All(char.IsLetter))
            {
                return dato;
            }

            return null;
        }

        #endregion
    }
}
