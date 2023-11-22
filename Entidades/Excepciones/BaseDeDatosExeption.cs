using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class BaseDeDatosExeption : Exception
    {
        public BaseDeDatosExeption(string? message) : base(message)
        {
        }

        public BaseDeDatosExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
