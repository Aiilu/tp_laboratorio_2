using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public List<Alumno> Alumnos
        {
            get
            {

            }
            set
            {

            }
        }

        public List<Profesor> Instructores
        {
            get
            {

            }
            set
            {

            }
        }

        public List<Jornada> Jornadas
        {
            get
            {

            }
            set
            {

            }
        }

        public Jornada this[int i]
        {
            get
            {

            }
            set
            {

            }
        }

        public Universidad()
        {

        }

        public bool Guardar(Universidad uni)
        {
            return false;
        }

        public Universidad Leer()
        {

        }

        private string MostrarDatos(Universidad uni)
        {
            return "a";
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            return false;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return false;
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            return false;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return false;
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {

        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {

        }

        public static Universidad operator +(Universidad g, EClases clase)
        {

        }

        public static Universidad operator +(Universidad u, Alumno a)
        {

        }

        public static Universidad operator +(Universidad u, Profesor i)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
