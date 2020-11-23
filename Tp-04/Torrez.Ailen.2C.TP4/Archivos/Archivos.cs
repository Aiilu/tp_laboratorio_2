using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Archivos
{
    public static class Archivos<T>
        where T : new ()
    {

       public static void GuardarArchivo(Object tipoQueGuardar)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializar = null;

            try
            {
                writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivo", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializar = new XmlSerializer(typeof(T)); 
                serializar.Serialize(writer, (T)tipoQueGuardar); 
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public static T LeerArchivo()
        {
            XmlTextReader read = null;
            XmlSerializer deserializar = null;

            try
            {
                read = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivo");

                deserializar = new XmlSerializer(typeof(T));
                return (T)deserializar.Deserialize(read);
            }
            finally
            {
                if (read != null)
                {
                    read.Close();
                }
            }

        }
    }
}
