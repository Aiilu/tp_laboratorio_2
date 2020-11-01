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

        public Jornada(Universidad.EClases clase, Profesor instructor) :this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto text = new Texto();

            return text.Guardar("Jornada.txt", jornada.ToString());
        }

        public static string Leer()
        {
            string resultado;

            Texto text = new Texto();

            text.Leer("Jornada.txt", out resultado);

            return resultado;
        }

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

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

        public override string ToString()
        {
            StringBuilder datosJornada = new StringBuilder();

            datosJornada.AppendLine($"CLASE DE {this.Clase} POR {this.Instructor}");
            datosJornada.AppendLine("ALUMNOS: ");

            foreach(Alumno alumno in this.alumnos)
            {
                datosJornada.AppendLine($"{alumno}");
            }

            datosJornada.AppendLine("<------------------------------------------------>");

            return datosJornada.ToString();
        }
    }
}
