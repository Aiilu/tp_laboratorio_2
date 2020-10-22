using ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public sealed class Profesor :Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private Random random;

        private Profesor()
        {

        }

        /*
         * public Profesor()
         */

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {

        }

        private void _randomClase()
        {

        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos();
        }

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return false;
        }

        protected override string ParticiparEnClase()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
