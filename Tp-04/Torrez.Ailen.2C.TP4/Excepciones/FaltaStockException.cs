using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FaltaStockException :Exception
    {
        public FaltaStockException(string mensaje) : base(mensaje)
        {

        }


    }
}
