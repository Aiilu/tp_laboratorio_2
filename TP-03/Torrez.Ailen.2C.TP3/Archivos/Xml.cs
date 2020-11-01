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
