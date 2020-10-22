using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario :Persona
    {
        private int legajo;

        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected virtual string MostrarDatos()
        {
            return "a";
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return false;
        }

        protected abstract string ParticiparEnClase();
    }
}
