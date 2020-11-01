using ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public sealed class Profesor :Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores

        public Profesor() :base()
        {
            
        }

        static Profesor()
        {
            random = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        private void _randomClases()
        { 
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            Thread.Sleep(100);
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
        }

        #endregion

        #region Sobrecargas
        protected override string MostrarDatos()
        {
            StringBuilder datosProfesor = new StringBuilder();

            datosProfesor.AppendLine(base.ToString());

            datosProfesor.AppendLine(this.ParticiparEnClase());

            return datosProfesor.ToString();
        }

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach(Universidad.EClases c in i.clasesDelDia)
            {
                if(c == clase)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

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

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion
    }
}
