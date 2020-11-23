using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestUnit
    {
        [TestMethod]
        public void PruebaInsert()
        {
            //Arrange
            Compra compra = new Compra();
            //Act
            compra.InsertarEnTabla("Ailen", 42661178, "Anochecer $1000");
            //Assert
            Assert.AreEqual("Anochecer $1000", compra.LeerTabla("Ailen", 42661178));
        }

        [TestMethod]
        public void PruebaSerializacion()
        {
            //Arrange
            Juegos juego = new Juegos(1000f,Juegos.JuegosPS4.Ghost);
            Juegos juego2 = null;
            //Act
            Archivos<Juegos>.GuardarArchivo(juego);
            juego2 = Archivos<Juegos>.LeerArchivo();
            //Assert
            Assert.AreEqual(juego.Precio, juego2.Precio);
            Assert.AreEqual(juego.Productos, juego2.Productos);
            Assert.AreEqual(juego.JuegosDePS4, juego2.JuegosDePS4);
        }
    }
}
