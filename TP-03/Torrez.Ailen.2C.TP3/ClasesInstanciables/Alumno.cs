using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno :Universitario
    {
        public enum EEstadoCuenta { AlDia, Deudor, Becado }

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Constructores

        public Alumno() : base()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma, default)
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Sobrecargas

        protected override string MostrarDatos()
        {
            StringBuilder datosAlumno = new StringBuilder();

            datosAlumno.AppendLine(base.MostrarDatos());

            if (this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                datosAlumno.AppendLine($"ESTADO DE CUENTA: Cuota al día");
            }
            else
            {
                datosAlumno.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta}");
            }

            datosAlumno.AppendLine(this.ParticiparEnClase());

            return datosAlumno.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE {this.claseQueToma}";
        }

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return (a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase);
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma != clase);
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion
    }
}
