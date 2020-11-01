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

        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }

        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> universidad = new Xml<Universidad>();

            return universidad.Guardar("Universidad.xml", uni);
        }

        public static Universidad Leer()
        {
            Universidad uni = null;
            Xml<Universidad> universidad = new Xml<Universidad>();

            universidad.Leer("Universidad.xml", out uni);

            return uni;
        }

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

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

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

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

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

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if(u != a)
            {
                u.Alumnos.Add(a);
                return u;
            }

            throw new AlumnoRepetidoException();
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if(u != i)
            {
                u.Instructores.Add(i);
            }

            return u;
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }
    }
}
