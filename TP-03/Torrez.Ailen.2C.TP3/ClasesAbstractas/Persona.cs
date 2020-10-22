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

        public string Apellido
        {
            get
            {
                return "a";
            }
            set
            {

            }
        }

        public int Dni
        {
            get
            {
                return 1;
            }
            set
            {

            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return ENacionalidad.Argentino;
            }
            set
            {

            }
        }

        public string Nombre
        {
            get
            {
                return "a";
            }
            set
            {

            }
        }

        public string StringToDNI
        {
            set
            {

            }
        }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            return 0;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            return 0;
        }

        private string ValidarNombreApellido(string dato)
        {
            return "a";
        }
    }
}
