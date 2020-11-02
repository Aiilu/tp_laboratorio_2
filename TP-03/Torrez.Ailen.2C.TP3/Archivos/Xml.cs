using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
        where T : new()
    {
        /// <summary>
        /// Guarda un objeto pasado por parametro en un archivo xml, en la ruta aclarada.
        /// </summary>
        /// <param name="archivo">Ruta en la que se guardara el archivo</param>
        /// <param name="datos">Objeto a guardar</param>
        /// <returns>Retorna true si se pudo guardar, caso contrario retorna false</returns>
        public bool Guardar(string archivo, T datos)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializacion = null;

            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializacion = new XmlSerializer(typeof(T));
                serializacion.Serialize(writer, datos);
            }
            catch (Exception ex)
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
        /// Lee un archivo xml en la ruta aclarada y guarda lo leido (en su anterior formato, se castea a lo que se quiere).
        /// </summary>
        /// <param name="archivo">Ruta donde va a leer</param>
        /// <param name="datos">Dato donde se guardara lo que se leyo</param>
        /// <returns>Retorna true si lo pudo leer, caso contrario retorna false</returns>
        public bool Leer(string archivo, out T datos)
        {
            XmlTextReader read = null;
            XmlSerializer deserializacion = null;
            datos = default;

            try
            {
                read = new XmlTextReader(archivo);
                deserializacion = new XmlSerializer(typeof(T));
                datos = (T)deserializacion.Deserialize(read);
            }
            catch (Exception ex)
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
