using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructores

        public Universitario() : base()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Metodos

        protected virtual string MostrarDatos()
        {
            StringBuilder datosUniversitario = new StringBuilder();

            datosUniversitario.AppendLine(base.ToString());
            datosUniversitario.AppendLine($"LEGAJO NÚMERO: {this.legajo}");

            return datosUniversitario.ToString();
        }

        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecargas

        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.Dni == pg2.Dni);
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion
    }
}
