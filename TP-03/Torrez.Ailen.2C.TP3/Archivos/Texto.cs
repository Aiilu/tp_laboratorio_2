using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto :IArchivo<string>
    {
        /// <summary>
        /// Guarda en un archivo de texto la informacion pasada por parametro en la ruta aclarada.
        /// </summary>
        /// <param name="archivo">Ruta en la que se guardara el texto</param>
        /// <param name="datos">Informacion a guardar</param>
        /// <returns>Retorna true si se pudo guardar, caso contrario retorna false</returns>
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(archivo, true);
                writer.WriteLine(datos);
            }
            catch(Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }             
            }

            return true;
        }

        /// <summary>
        /// Lee el arhivo de la ruta aclarada y guarda lo leido.
        /// </summary>
        /// <param name="archivo">Ruta donde va a leer</param>
        /// <param name="datos">Dato donde se guardara lo que se leyo</param>
        /// <returns>Retorna true si lo pudo leer, caso contrario retorna false</returns>
        public bool Leer(string archivo, out string datos)
        {
            StreamReader read = null;
            datos = "";

            try
            {
                read = new StreamReader(archivo);
                datos = read.ReadToEnd();
            }
            catch(Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if(read != null)
                {
                    read.Close();
                }
            }

            return true;
        }
    }
}
