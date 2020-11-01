using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException :Exception
    {
        public ArchivosException() :this("Archivo Invalido.")
        {

        }

        public ArchivosException(string message) :base(message)
        {

        }

        public ArchivosException(Exception innerException) :base("Archivo Invalido.", innerException)
        {

        }
    }
}
