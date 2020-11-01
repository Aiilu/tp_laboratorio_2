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
