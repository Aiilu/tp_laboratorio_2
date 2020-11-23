using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Archivos;
using MetodExtension;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            Libros libro = new Libros(340, Libros.LibTerror.Anochecer);
            Console.WriteLine("Libro instanciado: ");
            Console.WriteLine(libro.ToString());
            Console.WriteLine("------------------");
            Juegos juego = new Juegos(102, Juegos.JuegosPS4.Ghost);
            Console.WriteLine("Juego instanciado: ");
            Console.WriteLine(juego.ToString());
            Console.WriteLine("------------------");

            Compra compra = new Compra();
            float numero = 50.69f;

            compra.ListaProductos.Add(libro);
            compra.ListaProductos.Add(juego);

            Console.WriteLine("Muestro TODA la lista de compras: ");
            Console.WriteLine(compra);
            Console.WriteLine("------------------");

            compra.InsertarEnTabla("Nombre!",123987,"Datos $10");
            Console.WriteLine("Luego de insertar, muestro lo que devuelve lo leido: ");
            Console.WriteLine(compra.LeerTabla("Nombre!", 123987));


            Archivos<Libros>.GuardarArchivo(libro);
            Console.WriteLine("------------------");
            Console.WriteLine("Luego de guardar el archivo, muestro lo que devuelve la lectura: ");
            Console.WriteLine(Archivos<Libros>.LeerArchivo());
            Console.WriteLine("------------------");

            Console.WriteLine("Metodo de extension implementado: ");
            Console.WriteLine(numero.Mostrar());
            Console.WriteLine("------------------");

            Console.ReadKey();
        }
    }
}