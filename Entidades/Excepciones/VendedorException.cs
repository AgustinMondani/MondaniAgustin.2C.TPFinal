using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class VendedorException : Exception
    {
        public VendedorException(string? message) : base(message)
        {
        }

        public VendedorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
