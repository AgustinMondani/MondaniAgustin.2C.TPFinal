using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FaltaDeStockException : Exception
    {
        public FaltaDeStockException(string? message) : base(message)
        {
        }

        public FaltaDeStockException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
