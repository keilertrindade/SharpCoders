using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora.Exceptions
{
    public class DivisionByZeroException : Exception
    {
        public DivisionByZeroException() { }

        public DivisionByZeroException(string? message) : base(message)
        {
        }
    }
}
