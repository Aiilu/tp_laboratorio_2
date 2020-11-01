using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
               
            }
        }

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

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        public bool Guardar(Jornada jornada)
        {
            return false;
        }

        public string Leer()
        {
            return "a";
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach(Alumno alumno in j.alumnos)
            {
            }
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return false;
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
