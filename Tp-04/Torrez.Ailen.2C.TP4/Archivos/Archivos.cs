using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ClasesAbstractas;
using ClasesInstanciables;

namespace Archivos
{
    public static class Archivos<T>
        where T : new ()
    {
        public static void GuardarArchivo(T tipoQueGuardar)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializar = null;

            try
            {
                writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "archivo", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializar = new XmlSerializer(typeof(T)); 
                serializar.Serialize(writer, tipoQueGuardar); 
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public static T LeerArchivo(string path)
        {
            XmlTextReader read = null;
            XmlSerializer deserializar = null;

            try
            {
                read = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "archivo");

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
