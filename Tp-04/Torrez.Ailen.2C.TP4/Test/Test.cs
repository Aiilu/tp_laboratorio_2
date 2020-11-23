using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;
using ClasesInstanciables;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            Libros libro = new Libros(340);

            Juegos juego = new Juegos(102);

            Libreria libreria = new Libreria();

            libreria.ListaProductos.Add(libro);
            libreria.ListaProductos.Add(juego);

            Console.WriteLine("------------------");

            Console.WriteLine(libreria.ToString());

            Console.WriteLine("------------------");

            Console.ReadKey();
        }
    }
}