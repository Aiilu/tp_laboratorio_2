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
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestExcepcionDniInvalido()
        {
            // Arrange
            Alumno alumno = null;

            // Act
            alumno = new Alumno(123, "Ailen", "Torrez", "1234a", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestExcepcionNacionalidadInvalida()
        {
            // Arrange
            Profesor profesor = null;

            // Act
            profesor = new Profesor(456, "Federico", "Davila", "90000000", Persona.ENacionalidad.Argentino);
        }

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

        [TestMethod]
        public void TestInstanciaListaAlumnos()
        {
            // Arrange
            Profesor profesor = new Profesor(456, "Federico", "Davila", "1234", Persona.ENacionalidad.Argentino);
            Jornada jornada = new Jornada(Universidad.EClases.Legislacion, profesor);
            
            // Assert
            Assert.IsNotNull(jornada.Alumnos);
        }

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
