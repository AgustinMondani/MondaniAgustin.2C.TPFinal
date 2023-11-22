using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ErrorCompraException : Exception
    {
        public ErrorCompraException(string? message) : base(message)
        {
        }

        public ErrorCompraException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
