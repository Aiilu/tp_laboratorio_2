using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
            }
        }

        #endregion

        #region Constructores

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) :this(nombre, apellido, nacionalidad)
        {
            this.Dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) :this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            StringBuilder datosPersona = new StringBuilder();

            datosPersona.AppendLine($"NOMBRE COMPLETO: {this.Apellido}, {this.Nombre}");
            datosPersona.AppendLine($"NACIONALIDAD: {this.Nacionalidad}");
            datosPersona.AppendLine($"DNI: {this.Dni}");

            return datosPersona.ToString();
        }

        #endregion

        #region Validaciones

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if(nacionalidad is ENacionalidad.Argentino)
            {
                if(dato >= 1 && dato <= 89999999)
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

            //throw new NacionalidadInvalidaException();
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if(nacionalidad is ENacionalidad.Argentino)
            {
                if(dato.Length >= 1 && dato.Length <= 8)
                {
                    if(int.TryParse(dato, out dni))
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

            //throw new DniInvalidoException();
        }

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
