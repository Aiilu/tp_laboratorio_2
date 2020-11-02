using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using ClasesAbstractas;
using Excepciones;
using System.Globalization;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTesttP3
    {
        /// <summary>
        /// Test que valida que la excepcion DniInvalidoException se lance correctamente. 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestExcepcionDniInvalido()
        {
            // Arrange
            Alumno alumno = null;

            // Act
            alumno = new Alumno(123, "Ailen", "Torrez", "1234a", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }

        /// <summary>
        /// Test que valida que la excepcion NacionalidadInvalidaException se lance correctamente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestExcepcionNacionalidadInvalida()
        {
            // Arrange
            Profesor profesor = null;

            // Act
            profesor = new Profesor(456, "Federico", "Davila", "90000000", Persona.ENacionalidad.Argentino);
        }

        /// <summary>
        /// Test que valida que la excepcion AlumnoRepetidoException se lance correctamente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestExcepcionAlumnoRepetido()
        {
            // Arrange
            Universidad universidad = new Universidad();
            Alumno alumno = new Alumno(1234, "Leonardo", "Magnaghi", "90000000", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
            Alumno alumno2 = new Alumno(5678, "Juan", "Carlos", "90000000", Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD);

            // Act
            universidad += alumno;
            universidad += alumno2;
        }

        /// <summary>
        /// Test que valida que la excepcion SinProfesorException se lance correctamente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestExcepcionSinProfesor()
        {
            // Arrange
            Universidad universidad = new Universidad();
            Profesor profesor = new Profesor(456, "Federico", "Davila", "1234", Persona.ENacionalidad.Argentino);

            // Act
            for(int i = 0; i < 4; i++)
            {
                if (profesor != (Universidad.EClases)i)
                {
                    profesor = (universidad == (Universidad.EClases)i);
                }
            }
        }

        /// <summary>
        /// Test que valida que la lista de Alumnos fue instanciada.
        /// </summary>
        [TestMethod]
        public void TestInstanciaListaAlumnos()
        {
            // Arrange
            Profesor profesor = new Profesor(456, "Federico", "Davila", "1234", Persona.ENacionalidad.Argentino);
            Jornada jornada = new Jornada(Universidad.EClases.Legislacion, profesor);
            
            // Assert
            Assert.IsNotNull(jornada.Alumnos);
        }

        /// <summary>
        /// Test que valida que la lista de Profesores fue instanciada.
        /// </summary>
        [TestMethod]
        public void TestInstanciaListaProfesor()
        {
            // Arrange
            Universidad universidad = new Universidad();

            // Assert
            Assert.IsNotNull(universidad.Instructores);
        }
    }
}
